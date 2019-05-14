namespace CountdownGame
{
    partial class frmMainGame
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnCreateTeams = new System.Windows.Forms.Button();
            this.lblScoreboard = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblTeamTwoName = new System.Windows.Forms.Label();
            this.lblT1R1 = new System.Windows.Forms.Label();
            this.lblT2R1 = new System.Windows.Forms.Label();
            this.lblTeamOneName = new System.Windows.Forms.Label();
            this.lblT1R2 = new System.Windows.Forms.Label();
            this.lblT1R3 = new System.Windows.Forms.Label();
            this.lblT1R4 = new System.Windows.Forms.Label();
            this.lblTeamOneTotal = new System.Windows.Forms.Label();
            this.lblT2R2 = new System.Windows.Forms.Label();
            this.lblT2R3 = new System.Windows.Forms.Label();
            this.lblT2R4 = new System.Windows.Forms.Label();
            this.lblTeamTwoTotal = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.btnPlayNextRound = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(82, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(378, 82);
            this.label1.TabIndex = 0;
            this.label1.Text = "COUNTDOWN";
            // 
            // btnCreateTeams
            // 
            this.btnCreateTeams.BackColor = System.Drawing.Color.MediumBlue;
            this.btnCreateTeams.Font = new System.Drawing.Font("Impact", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateTeams.ForeColor = System.Drawing.Color.White;
            this.btnCreateTeams.Location = new System.Drawing.Point(194, 94);
            this.btnCreateTeams.Name = "btnCreateTeams";
            this.btnCreateTeams.Size = new System.Drawing.Size(155, 56);
            this.btnCreateTeams.TabIndex = 1;
            this.btnCreateTeams.Text = "CREATE TEAMS";
            this.btnCreateTeams.UseVisualStyleBackColor = false;
            this.btnCreateTeams.Click += new System.EventHandler(this.BtnCreateTeams_Click);
            // 
            // lblScoreboard
            // 
            this.lblScoreboard.AutoSize = true;
            this.lblScoreboard.Font = new System.Drawing.Font("Impact", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScoreboard.ForeColor = System.Drawing.Color.White;
            this.lblScoreboard.Location = new System.Drawing.Point(157, 94);
            this.lblScoreboard.Name = "lblScoreboard";
            this.lblScoreboard.Size = new System.Drawing.Size(232, 48);
            this.lblScoreboard.TabIndex = 2;
            this.lblScoreboard.Text = "SCOREBOARD";
            this.lblScoreboard.Visible = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetDouble;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.8718F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.0641F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.0641F));
            this.tableLayoutPanel1.Controls.Add(this.lblTeamTwoName, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblT1R1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblT2R1, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblTeamOneName, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblT1R2, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblT1R3, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblT1R4, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblTeamOneTotal, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.lblT2R2, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblT2R3, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblT2R4, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblTeamTwoTotal, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.label13, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label14, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label15, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label16, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label17, 0, 5);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(32, 156);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(478, 330);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // lblTeamTwoName
            // 
            this.lblTeamTwoName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTeamTwoName.AutoSize = true;
            this.lblTeamTwoName.Font = new System.Drawing.Font("Impact", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeamTwoName.ForeColor = System.Drawing.Color.White;
            this.lblTeamTwoName.Location = new System.Drawing.Point(335, 16);
            this.lblTeamTwoName.Name = "lblTeamTwoName";
            this.lblTeamTwoName.Size = new System.Drawing.Size(91, 25);
            this.lblTeamTwoName.TabIndex = 1;
            this.lblTeamTwoName.Text = "Team Two";
            // 
            // lblT1R1
            // 
            this.lblT1R1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblT1R1.AutoSize = true;
            this.lblT1R1.Font = new System.Drawing.Font("Impact", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblT1R1.ForeColor = System.Drawing.Color.White;
            this.lblT1R1.Location = new System.Drawing.Point(176, 70);
            this.lblT1R1.Name = "lblT1R1";
            this.lblT1R1.Size = new System.Drawing.Size(30, 25);
            this.lblT1R1.TabIndex = 2;
            this.lblT1R1.Text = "---";
            // 
            // lblT2R1
            // 
            this.lblT2R1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblT2R1.AutoSize = true;
            this.lblT2R1.Font = new System.Drawing.Font("Impact", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblT2R1.ForeColor = System.Drawing.Color.White;
            this.lblT2R1.Location = new System.Drawing.Point(366, 70);
            this.lblT2R1.Name = "lblT2R1";
            this.lblT2R1.Size = new System.Drawing.Size(30, 25);
            this.lblT2R1.TabIndex = 3;
            this.lblT2R1.Text = "---";
            // 
            // lblTeamOneName
            // 
            this.lblTeamOneName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTeamOneName.AutoSize = true;
            this.lblTeamOneName.Font = new System.Drawing.Font("Impact", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeamOneName.ForeColor = System.Drawing.Color.White;
            this.lblTeamOneName.Location = new System.Drawing.Point(146, 16);
            this.lblTeamOneName.Name = "lblTeamOneName";
            this.lblTeamOneName.Size = new System.Drawing.Size(90, 25);
            this.lblTeamOneName.TabIndex = 0;
            this.lblTeamOneName.Text = "Team One";
            // 
            // lblT1R2
            // 
            this.lblT1R2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblT1R2.AutoSize = true;
            this.lblT1R2.Font = new System.Drawing.Font("Impact", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblT1R2.ForeColor = System.Drawing.Color.White;
            this.lblT1R2.Location = new System.Drawing.Point(176, 124);
            this.lblT1R2.Name = "lblT1R2";
            this.lblT1R2.Size = new System.Drawing.Size(30, 25);
            this.lblT1R2.TabIndex = 2;
            this.lblT1R2.Text = "---";
            // 
            // lblT1R3
            // 
            this.lblT1R3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblT1R3.AutoSize = true;
            this.lblT1R3.Font = new System.Drawing.Font("Impact", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblT1R3.ForeColor = System.Drawing.Color.White;
            this.lblT1R3.Location = new System.Drawing.Point(176, 178);
            this.lblT1R3.Name = "lblT1R3";
            this.lblT1R3.Size = new System.Drawing.Size(30, 25);
            this.lblT1R3.TabIndex = 2;
            this.lblT1R3.Text = "---";
            // 
            // lblT1R4
            // 
            this.lblT1R4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblT1R4.AutoSize = true;
            this.lblT1R4.Font = new System.Drawing.Font("Impact", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblT1R4.ForeColor = System.Drawing.Color.White;
            this.lblT1R4.Location = new System.Drawing.Point(176, 232);
            this.lblT1R4.Name = "lblT1R4";
            this.lblT1R4.Size = new System.Drawing.Size(30, 25);
            this.lblT1R4.TabIndex = 2;
            this.lblT1R4.Text = "---";
            // 
            // lblTeamOneTotal
            // 
            this.lblTeamOneTotal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTeamOneTotal.AutoSize = true;
            this.lblTeamOneTotal.Font = new System.Drawing.Font("Impact", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeamOneTotal.ForeColor = System.Drawing.Color.White;
            this.lblTeamOneTotal.Location = new System.Drawing.Point(173, 279);
            this.lblTeamOneTotal.Name = "lblTeamOneTotal";
            this.lblTeamOneTotal.Size = new System.Drawing.Size(36, 42);
            this.lblTeamOneTotal.TabIndex = 2;
            this.lblTeamOneTotal.Text = "0";
            // 
            // lblT2R2
            // 
            this.lblT2R2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblT2R2.AutoSize = true;
            this.lblT2R2.Font = new System.Drawing.Font("Impact", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblT2R2.ForeColor = System.Drawing.Color.White;
            this.lblT2R2.Location = new System.Drawing.Point(366, 124);
            this.lblT2R2.Name = "lblT2R2";
            this.lblT2R2.Size = new System.Drawing.Size(30, 25);
            this.lblT2R2.TabIndex = 3;
            this.lblT2R2.Text = "---";
            // 
            // lblT2R3
            // 
            this.lblT2R3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblT2R3.AutoSize = true;
            this.lblT2R3.Font = new System.Drawing.Font("Impact", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblT2R3.ForeColor = System.Drawing.Color.White;
            this.lblT2R3.Location = new System.Drawing.Point(366, 178);
            this.lblT2R3.Name = "lblT2R3";
            this.lblT2R3.Size = new System.Drawing.Size(30, 25);
            this.lblT2R3.TabIndex = 3;
            this.lblT2R3.Text = "---";
            // 
            // lblT2R4
            // 
            this.lblT2R4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblT2R4.AutoSize = true;
            this.lblT2R4.Font = new System.Drawing.Font("Impact", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblT2R4.ForeColor = System.Drawing.Color.White;
            this.lblT2R4.Location = new System.Drawing.Point(366, 232);
            this.lblT2R4.Name = "lblT2R4";
            this.lblT2R4.Size = new System.Drawing.Size(30, 25);
            this.lblT2R4.TabIndex = 3;
            this.lblT2R4.Text = "---";
            // 
            // lblTeamTwoTotal
            // 
            this.lblTeamTwoTotal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTeamTwoTotal.AutoSize = true;
            this.lblTeamTwoTotal.Font = new System.Drawing.Font("Impact", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeamTwoTotal.ForeColor = System.Drawing.Color.White;
            this.lblTeamTwoTotal.Location = new System.Drawing.Point(363, 279);
            this.lblTeamTwoTotal.Name = "lblTeamTwoTotal";
            this.lblTeamTwoTotal.Size = new System.Drawing.Size(36, 42);
            this.lblTeamTwoTotal.TabIndex = 3;
            this.lblTeamTwoTotal.Text = "0";
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Impact", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(11, 70);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(75, 25);
            this.label13.TabIndex = 2;
            this.label13.Text = "Round 1";
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Impact", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(10, 124);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(77, 25);
            this.label14.TabIndex = 2;
            this.label14.Text = "Round 2";
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Impact", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(10, 178);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(78, 25);
            this.label15.TabIndex = 2;
            this.label15.Text = "Round 3";
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Impact", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(10, 232);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(77, 25);
            this.label16.TabIndex = 2;
            this.label16.Text = "Round 4";
            // 
            // label17
            // 
            this.label17.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Impact", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(20, 287);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(58, 25);
            this.label17.TabIndex = 2;
            this.label17.Text = "TOTAL";
            // 
            // btnPlayNextRound
            // 
            this.btnPlayNextRound.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnPlayNextRound.Font = new System.Drawing.Font("Impact", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlayNextRound.Location = new System.Drawing.Point(32, 492);
            this.btnPlayNextRound.Name = "btnPlayNextRound";
            this.btnPlayNextRound.Size = new System.Drawing.Size(478, 62);
            this.btnPlayNextRound.TabIndex = 4;
            this.btnPlayNextRound.Text = "PLAY NEXT ROUND";
            this.btnPlayNextRound.UseVisualStyleBackColor = false;
            this.btnPlayNextRound.Visible = false;
            this.btnPlayNextRound.Click += new System.EventHandler(this.btnPlayNextRound_Click);
            // 
            // frmMainGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Blue;
            this.ClientSize = new System.Drawing.Size(543, 577);
            this.Controls.Add(this.btnPlayNextRound);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.btnCreateTeams);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblScoreboard);
            this.Name = "frmMainGame";
            this.Text = "frmMainGame";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCreateTeams;
        private System.Windows.Forms.Label lblScoreboard;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblTeamOneName;
        private System.Windows.Forms.Label lblTeamTwoName;
        private System.Windows.Forms.Label lblT1R1;
        private System.Windows.Forms.Label lblT2R1;
        private System.Windows.Forms.Label lblT1R2;
        private System.Windows.Forms.Label lblT1R3;
        private System.Windows.Forms.Label lblT1R4;
        private System.Windows.Forms.Label lblTeamOneTotal;
        private System.Windows.Forms.Label lblT2R2;
        private System.Windows.Forms.Label lblT2R3;
        private System.Windows.Forms.Label lblT2R4;
        private System.Windows.Forms.Label lblTeamTwoTotal;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button btnPlayNextRound;
    }
}