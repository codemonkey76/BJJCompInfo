namespace BJJCompetitionInfo
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
            this.lbEvents = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGetCompetitors = new System.Windows.Forms.Button();
            this.lbCompetitors = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbCompetitorBrackets = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnGetCompetitorsInBracket = new System.Windows.Forms.Button();
            this.lbCompetitorsInBracket = new System.Windows.Forms.ListBox();
            this.cbYears = new System.Windows.Forms.ComboBox();
            this.btnLoadEvents = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.lbAcademies = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbCompetitorsByAcademy = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblCompInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbEvents
            // 
            this.lbEvents.FormattingEnabled = true;
            this.lbEvents.Location = new System.Drawing.Point(10, 99);
            this.lbEvents.Name = "lbEvents";
            this.lbEvents.Size = new System.Drawing.Size(368, 212);
            this.lbEvents.TabIndex = 0;
            this.lbEvents.SelectedIndexChanged += new System.EventHandler(this.lbEvents_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Events";
            // 
            // btnGetCompetitors
            // 
            this.btnGetCompetitors.Location = new System.Drawing.Point(10, 314);
            this.btnGetCompetitors.Name = "btnGetCompetitors";
            this.btnGetCompetitors.Size = new System.Drawing.Size(103, 23);
            this.btnGetCompetitors.TabIndex = 2;
            this.btnGetCompetitors.Text = "Get Competitors ->";
            this.btnGetCompetitors.UseVisualStyleBackColor = true;
            this.btnGetCompetitors.Click += new System.EventHandler(this.btnGetCompetitors_Click);
            // 
            // lbCompetitors
            // 
            this.lbCompetitors.FormattingEnabled = true;
            this.lbCompetitors.Location = new System.Drawing.Point(384, 34);
            this.lbCompetitors.Name = "lbCompetitors";
            this.lbCompetitors.Size = new System.Drawing.Size(166, 303);
            this.lbCompetitors.TabIndex = 3;
            this.lbCompetitors.SelectedIndexChanged += new System.EventHandler(this.lbCompetitors_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(381, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Competitors";
            // 
            // lbCompetitorBrackets
            // 
            this.lbCompetitorBrackets.FormattingEnabled = true;
            this.lbCompetitorBrackets.Location = new System.Drawing.Point(556, 34);
            this.lbCompetitorBrackets.Name = "lbCompetitorBrackets";
            this.lbCompetitorBrackets.Size = new System.Drawing.Size(218, 108);
            this.lbCompetitorBrackets.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(553, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Brackets";
            // 
            // btnGetCompetitorsInBracket
            // 
            this.btnGetCompetitorsInBracket.Location = new System.Drawing.Point(556, 148);
            this.btnGetCompetitorsInBracket.Name = "btnGetCompetitorsInBracket";
            this.btnGetCompetitorsInBracket.Size = new System.Drawing.Size(108, 49);
            this.btnGetCompetitorsInBracket.TabIndex = 12;
            this.btnGetCompetitorsInBracket.Text = "Get Competitors in Bracket";
            this.btnGetCompetitorsInBracket.UseVisualStyleBackColor = true;
            this.btnGetCompetitorsInBracket.Click += new System.EventHandler(this.btnGetCompetitorsInBracket_Click);
            // 
            // lbCompetitorsInBracket
            // 
            this.lbCompetitorsInBracket.FormattingEnabled = true;
            this.lbCompetitorsInBracket.Location = new System.Drawing.Point(556, 200);
            this.lbCompetitorsInBracket.Name = "lbCompetitorsInBracket";
            this.lbCompetitorsInBracket.Size = new System.Drawing.Size(218, 134);
            this.lbCompetitorsInBracket.TabIndex = 13;
            // 
            // cbYears
            // 
            this.cbYears.FormattingEnabled = true;
            this.cbYears.Location = new System.Drawing.Point(10, 25);
            this.cbYears.Name = "cbYears";
            this.cbYears.Size = new System.Drawing.Size(121, 21);
            this.cbYears.TabIndex = 14;
            // 
            // btnLoadEvents
            // 
            this.btnLoadEvents.Location = new System.Drawing.Point(10, 52);
            this.btnLoadEvents.Name = "btnLoadEvents";
            this.btnLoadEvents.Size = new System.Drawing.Size(75, 23);
            this.btnLoadEvents.TabIndex = 15;
            this.btnLoadEvents.Text = "Load Events";
            this.btnLoadEvents.UseVisualStyleBackColor = true;
            this.btnLoadEvents.Click += new System.EventHandler(this.btnLoadEvents_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Year";
            // 
            // lbAcademies
            // 
            this.lbAcademies.FormattingEnabled = true;
            this.lbAcademies.Location = new System.Drawing.Point(10, 364);
            this.lbAcademies.Name = "lbAcademies";
            this.lbAcademies.Size = new System.Drawing.Size(177, 173);
            this.lbAcademies.TabIndex = 17;
            this.lbAcademies.SelectedIndexChanged += new System.EventHandler(this.lbAcademies_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 348);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Academies";
            // 
            // lbCompetitorsByAcademy
            // 
            this.lbCompetitorsByAcademy.FormattingEnabled = true;
            this.lbCompetitorsByAcademy.Location = new System.Drawing.Point(193, 364);
            this.lbCompetitorsByAcademy.Name = "lbCompetitorsByAcademy";
            this.lbCompetitorsByAcademy.Size = new System.Drawing.Size(166, 173);
            this.lbCompetitorsByAcademy.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(190, 348);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(169, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Competitors for Selected Academy";
            // 
            // lblCompInfo
            // 
            this.lblCompInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCompInfo.Location = new System.Drawing.Point(377, 355);
            this.lblCompInfo.Name = "lblCompInfo";
            this.lblCompInfo.Size = new System.Drawing.Size(397, 181);
            this.lblCompInfo.TabIndex = 21;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 544);
            this.Controls.Add(this.lblCompInfo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbCompetitorsByAcademy);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbAcademies);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnLoadEvents);
            this.Controls.Add(this.cbYears);
            this.Controls.Add(this.lbCompetitorsInBracket);
            this.Controls.Add(this.btnGetCompetitorsInBracket);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbCompetitorBrackets);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbCompetitors);
            this.Controls.Add(this.btnGetCompetitors);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbEvents);
            this.Name = "Form1";
            this.Text = "BJJ Competition Info";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbEvents;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGetCompetitors;
        private System.Windows.Forms.ListBox lbCompetitors;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lbCompetitorBrackets;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnGetCompetitorsInBracket;
        private System.Windows.Forms.ListBox lbCompetitorsInBracket;
        private System.Windows.Forms.ComboBox cbYears;
        private System.Windows.Forms.Button btnLoadEvents;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox lbAcademies;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lbCompetitorsByAcademy;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblCompInfo;
    }
}

