using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JsonEntities = Contracts.Entities.Json;
using Contracts.Entities;
using Business;
using LoadJsonData.JsonLists;
using Newtonsoft.Json;

namespace LoadJsonData
{
    public partial class Form1 : Form
    {
        string JsonData;
        List<Party> parties;
        List<JsonEntities.Party> JsonParties;
        PartyController partyCtr;

        public Form1()
        {
            InitializeComponent();

            JsonData = @"{ 
                        ""parties"": 
                                  [
                                     { ""id"":0, ""name"":""SPD"", ""longname"":""Sozialdemokratische Partei Deutschlands""},
                                     { ""id"":1, ""name"":""CDU"", ""longname"":""Christlich Demokratische Union Deutschlands""},
                                     { ""id"":2, ""name"":""GRÜNE"", ""longname"":""BÜNDNIS 90/DIE GRÜNEN""},
                                     { ""id"":3, ""name"":""FDP"", ""longname"":""Freie Demokratische Partei""},
                                     { ""id"":4, ""name"":""DIE LINKE"", ""longname"":""DIE LINKE""},
                                     { ""id"":5, ""name"":""PIRATEN"", ""longname"":""Piratenpartei Deutschland""},
                                     { ""id"":6, ""name"":""NPD"", ""longname"":""Nationaldemokratische Partei Deutschlands""},
                                     { ""id"":7, ""name"":""Die PARTEI"", ""longname"":""Partei für Arbeit, Rechtsstaat, Tierschutz, Elitenförderung und basisdemokratische Initiative""},
                                     { ""id"":8, ""name"":""RENTNER"", ""longname"":""RENTNER Partei Deutschland""},
                                     { ""id"":9, ""name"":""ÖDP"", ""longname"":""Ökologisch-Demokratische Partei""},
                                     { ""id"":10, ""name"":""AfD"", ""longname"":""Alternative für Deutschland""},
                                     { ""id"":11, ""name"":""HHBL"", ""longname"":""Hamburger Bürger-Liste""},
                                     { ""id"":12, ""name"":""Liberale"", ""longname"":""Neue Liberale""}
                                  ]
                        }";
            
            PartyList jsonPartyList = JsonConvert.DeserializeObject<PartyList>(JsonData);
            JsonParties = jsonPartyList.getParties();

            partyCtr = new PartyController();
            parties = partyCtr.GetParties();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            initGrid();
        }

        private bool doesPartyExist(JsonEntities.Party JsonParty)
        {
            return parties.Any(
                               d => d.NameShort == JsonParty.name
                                 || d.NameLong == JsonParty.longname);
        }

        private void initGrid()
        {
            gridMapping.DataSource = JsonParties.Where(d => !doesPartyExist(d)).ToList();
            DataGridViewComboBoxColumn newColumn = new DataGridViewComboBoxColumn {
                Name = "newParty",
                HeaderText = "Partei schon vorhanden?",
                //DataSource = parties.Select(d => new { d.NameShort, d.Id }).ToList(),
                DisplayMember = "NameShort",
                ValueMember = "NameLong"
            };

            newColumn.Items.Add(new { nameShort = "", nameLong = "" });
            foreach (var comboBoxParty in parties.Select(d => new { d.NameShort, d.NameLong }).ToList())
            {
                newColumn.Items.Add(comboBoxParty);
            }

            gridMapping.Columns.Add(newColumn);
        }

        private void BtSave_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow gridRow in gridMapping.Rows)
            {
                Party newParty = new Party
                {
                    NameLong = gridRow.Cells[3].Value?.ToString(),
                    NameShort = gridRow.Cells[3].FormattedValue?.ToString()
                };
                if (String.IsNullOrEmpty(newParty.NameLong))
                {
                    newParty.NameShort = gridRow.Cells[1].FormattedValue.ToString();
                    newParty.NameLong = gridRow.Cells[2].FormattedValue.ToString();
                    partyCtr.AddParty(newParty);
                    //MessageBox.Show(newParty.NameShort + " – " + newParty.NameLong);
                }
                    
            }
        }
    }
}
