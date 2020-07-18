using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business;
using Contracts.Entities;
using Newtonsoft.Json;

namespace ParteienAnalyse
{
    public partial class Form1 : Form
    {
        List<Party> parties = new List<Party>();
        List<DrawingAction> actions = new List<DrawingAction>();
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                PartyController controller = new PartyController();
                parties = controller.GetParties();

                foreach (var party in parties)
                {
                    listBoxParties.Items.Add(party.NameShort);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void listBoxParties_SelectedIndexChanged(object sender, EventArgs e)
        {
            Party selectedParty = parties.Find(d => d.NameShort == listBoxParties.SelectedItem.ToString());
            fillTextBoxes(selectedParty);
            fillAnswers(selectedParty);
            fillConnections(selectedParty);
            drawVisualisation(selectedParty);

        }

        private void fillTextBoxes(Party party)
        {

            textBoxId.Text = party.Id.ToString();
            textBoxNameShort.Text = party.NameShort;
            textBoxNameLong.Text = party.NameLong;
        }

        private void fillAnswers(Party party)
        {
            textBoxAnswers.Clear();
            foreach (var answer in party.Answers)
            {
                textBoxAnswers.Text += writeTextBoxLine(answer.QuestionText, answer.OptionText);
            }
        }

        private void fillConnections(Party party)
        {
            textBoxConnectionScores.Clear();
            foreach (var connectionScore in party.ConnectionScores)
            {
                textBoxConnectionScores.Text +=
                    writeTextBoxLine(connectionScore.Party.NameShort, connectionScore.Score.ToString());
            }
        }

        private void drawVisualisation(Party party)
        {
            int basicX = 5;
            int basicY = 50;
            
            actions.Add(new DrawingAction(party.NameShort, basicX, basicY));

            Dictionary<int, DrawingAction> dictDrawingActions = new Dictionary<int, DrawingAction>();

            foreach (var connectionScore in party.ConnectionScores)
            {
                if (connectionScore.Score > -1)
                {
                    int distance = (76 - connectionScore.Score) * 14;
                    int y;

                    if (!dictDrawingActions.ContainsKey(distance))
                    {
                        dictDrawingActions[distance] = new DrawingAction(connectionScore.Party.NameShort, basicX + distance, basicY);
                    }
                    else
                    {
                        dictDrawingActions[distance].PartyName += "    " + connectionScore.Party.NameShort;
                    }
                }
            }

            foreach (int key in dictDrawingActions.Keys)
            {
                actions.Add(dictDrawingActions[key]);
            }

            panelVisual.Invalidate();
        }

        private void drawPartyLine(int x, int y, string partyName)
        {
            using (Brush pen = new SolidBrush(Color.Red))
            {
                // Draw Line
                Graphics graphic = panelVisual.CreateGraphics();
                graphic.FillRectangle(pen, x, y, 2, panelVisual.Height-y);
            }
        }

        private void drawPartyName(int x, int y, string partyName)
        {
            using (Brush pen = new SolidBrush(Color.Red))
            {
                // Draw Party Name
                Graphics graphic = panelVisual.CreateGraphics();
                StringFormat format = new StringFormat(StringFormatFlags.DirectionVertical);
                graphic.DrawString(partyName, new Font("Arial", 8), new SolidBrush(Color.Black), x, y + 35, format);

            }
        }

        private string writeTextBoxLine(string text1, string text2)
        {
            return text1 + "\t" + text2 + "\r\n";
        }

        private void drawAxis(Graphics graphic)
        {
            using (Brush brush = new SolidBrush(Color.Black))
            {
                // Axis
                graphic.FillRectangle(brush, 5, 70, panelVisual.Width, 10);
                // Max
                graphic.DrawString("76", new Font("Arial", 13), brush, 0, 40);
            }

            // Minimal possible Score
            using (Brush brush = new SolidBrush(Color.Blue))
            {
                graphic.FillRectangle(brush, 76 * 14, 50, 10, 50);
                graphic.DrawString("0", new Font("Arial", 13), brush, 76 * 14 - 2, 105);

            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            drawAxis(e.Graphics);

            foreach (var drawingAction in actions)
            {
                drawPartyLine(drawingAction.X, drawingAction.Y, drawingAction.PartyName);
                drawPartyName(drawingAction.X, drawingAction.Y, drawingAction.PartyName);

            }
            actions.Clear();
        }
        
    }
}
