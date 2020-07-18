namespace ParteienAnalyse
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBoxParties = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxNameShort = new System.Windows.Forms.TextBox();
            this.textBoxNameLong = new System.Windows.Forms.TextBox();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxAnswers = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxConnectionScores = new System.Windows.Forms.TextBox();
            this.panelVisual = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // listBoxParties
            // 
            this.listBoxParties.FormattingEnabled = true;
            this.listBoxParties.Location = new System.Drawing.Point(12, 31);
            this.listBoxParties.Name = "listBoxParties";
            this.listBoxParties.Size = new System.Drawing.Size(120, 602);
            this.listBoxParties.TabIndex = 0;
            this.listBoxParties.SelectedIndexChanged += new System.EventHandler(this.listBoxParties_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Parteien";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(188, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kürzel";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(140, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Voller Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(140, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Antworten:";
            // 
            // textBoxNameShort
            // 
            this.textBoxNameShort.Location = new System.Drawing.Point(191, 57);
            this.textBoxNameShort.Name = "textBoxNameShort";
            this.textBoxNameShort.ReadOnly = true;
            this.textBoxNameShort.Size = new System.Drawing.Size(95, 20);
            this.textBoxNameShort.TabIndex = 3;
            // 
            // textBoxNameLong
            // 
            this.textBoxNameLong.Location = new System.Drawing.Point(143, 106);
            this.textBoxNameLong.Name = "textBoxNameLong";
            this.textBoxNameLong.ReadOnly = true;
            this.textBoxNameLong.Size = new System.Drawing.Size(261, 20);
            this.textBoxNameLong.TabIndex = 3;
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(143, 57);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.ReadOnly = true;
            this.textBoxId.Size = new System.Drawing.Size(40, 20);
            this.textBoxId.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(143, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Id";
            // 
            // textBoxAnswers
            // 
            this.textBoxAnswers.Location = new System.Drawing.Point(143, 158);
            this.textBoxAnswers.Multiline = true;
            this.textBoxAnswers.Name = "textBoxAnswers";
            this.textBoxAnswers.ReadOnly = true;
            this.textBoxAnswers.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxAnswers.Size = new System.Drawing.Size(261, 149);
            this.textBoxAnswers.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(135, 330);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Beziehungen";
            // 
            // textBoxConnectionScores
            // 
            this.textBoxConnectionScores.Location = new System.Drawing.Point(138, 346);
            this.textBoxConnectionScores.Multiline = true;
            this.textBoxConnectionScores.Name = "textBoxConnectionScores";
            this.textBoxConnectionScores.ReadOnly = true;
            this.textBoxConnectionScores.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxConnectionScores.Size = new System.Drawing.Size(266, 286);
            this.textBoxConnectionScores.TabIndex = 6;
            // 
            // panelVisual
            // 
            this.panelVisual.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelVisual.Location = new System.Drawing.Point(410, 12);
            this.panelVisual.Name = "panelVisual";
            this.panelVisual.Size = new System.Drawing.Size(1199, 621);
            this.panelVisual.TabIndex = 7;
            this.panelVisual.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1621, 644);
            this.Controls.Add(this.panelVisual);
            this.Controls.Add(this.textBoxConnectionScores);
            this.Controls.Add(this.textBoxAnswers);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.textBoxNameLong);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxNameShort);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxParties);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxParties;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxNameShort;
        private System.Windows.Forms.TextBox textBoxNameLong;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxAnswers;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxConnectionScores;
        private System.Windows.Forms.Panel panelVisual;
    }
}

