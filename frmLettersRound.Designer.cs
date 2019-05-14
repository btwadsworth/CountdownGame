namespace CountdownGame
{
    partial class FrmLettersRound
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLettersRound));
            this.lblLetter1 = new System.Windows.Forms.Label();
            this.lblLetter2 = new System.Windows.Forms.Label();
            this.lblLetter3 = new System.Windows.Forms.Label();
            this.lblLetter4 = new System.Windows.Forms.Label();
            this.lblLetter5 = new System.Windows.Forms.Label();
            this.lblLetter7 = new System.Windows.Forms.Label();
            this.lblLetter6 = new System.Windows.Forms.Label();
            this.lblLetter8 = new System.Windows.Forms.Label();
            this.lblLetter9 = new System.Windows.Forms.Label();
            this.grpBoxLetters = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtBoxAnswerTeam1 = new System.Windows.Forms.TextBox();
            this.lblTeam1 = new System.Windows.Forms.Label();
            this.btnConsonant = new System.Windows.Forms.Button();
            this.btnVowel = new System.Windows.Forms.Button();
            this.video = new AxWMPLib.AxWindowsMediaPlayer();
            this.lblMessage = new System.Windows.Forms.Label();
            this.lblTeam2 = new System.Windows.Forms.Label();
            this.txtBoxAnswerTeam2 = new System.Windows.Forms.TextBox();
            this.btnCheckWords = new System.Windows.Forms.Button();
            this.lblScoreTeam1 = new System.Windows.Forms.Label();
            this.lblScoreTeam2 = new System.Windows.Forms.Label();
            this.btnTeamOneManualOverride = new System.Windows.Forms.Button();
            this.btnTeamTwoManualOverride = new System.Windows.Forms.Button();
            this.btnEndRound = new System.Windows.Forms.Button();
            this.grpBoxLetters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.video)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLetter1
            // 
            resources.ApplyResources(this.lblLetter1, "lblLetter1");
            this.lblLetter1.Name = "lblLetter1";
            // 
            // lblLetter2
            // 
            resources.ApplyResources(this.lblLetter2, "lblLetter2");
            this.lblLetter2.Name = "lblLetter2";
            // 
            // lblLetter3
            // 
            resources.ApplyResources(this.lblLetter3, "lblLetter3");
            this.lblLetter3.Name = "lblLetter3";
            // 
            // lblLetter4
            // 
            resources.ApplyResources(this.lblLetter4, "lblLetter4");
            this.lblLetter4.Name = "lblLetter4";
            // 
            // lblLetter5
            // 
            resources.ApplyResources(this.lblLetter5, "lblLetter5");
            this.lblLetter5.Name = "lblLetter5";
            // 
            // lblLetter7
            // 
            resources.ApplyResources(this.lblLetter7, "lblLetter7");
            this.lblLetter7.Name = "lblLetter7";
            // 
            // lblLetter6
            // 
            resources.ApplyResources(this.lblLetter6, "lblLetter6");
            this.lblLetter6.Name = "lblLetter6";
            // 
            // lblLetter8
            // 
            resources.ApplyResources(this.lblLetter8, "lblLetter8");
            this.lblLetter8.Name = "lblLetter8";
            // 
            // lblLetter9
            // 
            resources.ApplyResources(this.lblLetter9, "lblLetter9");
            this.lblLetter9.Name = "lblLetter9";
            // 
            // grpBoxLetters
            // 
            this.grpBoxLetters.BackColor = System.Drawing.Color.RoyalBlue;
            this.grpBoxLetters.Controls.Add(this.lblLetter1);
            this.grpBoxLetters.Controls.Add(this.lblLetter6);
            this.grpBoxLetters.Controls.Add(this.lblLetter2);
            this.grpBoxLetters.Controls.Add(this.lblLetter9);
            this.grpBoxLetters.Controls.Add(this.lblLetter3);
            this.grpBoxLetters.Controls.Add(this.lblLetter8);
            this.grpBoxLetters.Controls.Add(this.lblLetter4);
            this.grpBoxLetters.Controls.Add(this.lblLetter7);
            this.grpBoxLetters.Controls.Add(this.lblLetter5);
            resources.ApplyResources(this.grpBoxLetters, "grpBoxLetters");
            this.grpBoxLetters.Name = "grpBoxLetters";
            this.grpBoxLetters.TabStop = false;
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.Name = "label10";
            // 
            // txtBoxAnswerTeam1
            // 
            resources.ApplyResources(this.txtBoxAnswerTeam1, "txtBoxAnswerTeam1");
            this.txtBoxAnswerTeam1.Name = "txtBoxAnswerTeam1";
            this.txtBoxAnswerTeam1.TextChanged += new System.EventHandler(this.ValidateAndChangeCase);
            // 
            // lblTeam1
            // 
            resources.ApplyResources(this.lblTeam1, "lblTeam1");
            this.lblTeam1.ForeColor = System.Drawing.Color.White;
            this.lblTeam1.Name = "lblTeam1";
            // 
            // btnConsonant
            // 
            resources.ApplyResources(this.btnConsonant, "btnConsonant");
            this.btnConsonant.Name = "btnConsonant";
            this.btnConsonant.UseVisualStyleBackColor = true;
            this.btnConsonant.Click += new System.EventHandler(this.btnConsonant_Click);
            // 
            // btnVowel
            // 
            resources.ApplyResources(this.btnVowel, "btnVowel");
            this.btnVowel.Name = "btnVowel";
            this.btnVowel.UseVisualStyleBackColor = true;
            this.btnVowel.Click += new System.EventHandler(this.btnVowel_Click);
            // 
            // video
            // 
            resources.ApplyResources(this.video, "video");
            this.video.Name = "video";
            this.video.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("video.OcxState")));
            this.video.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.TimesUp);
            // 
            // lblMessage
            // 
            resources.ApplyResources(this.lblMessage, "lblMessage");
            this.lblMessage.ForeColor = System.Drawing.Color.White;
            this.lblMessage.Name = "lblMessage";
            // 
            // lblTeam2
            // 
            resources.ApplyResources(this.lblTeam2, "lblTeam2");
            this.lblTeam2.ForeColor = System.Drawing.Color.White;
            this.lblTeam2.Name = "lblTeam2";
            // 
            // txtBoxAnswerTeam2
            // 
            resources.ApplyResources(this.txtBoxAnswerTeam2, "txtBoxAnswerTeam2");
            this.txtBoxAnswerTeam2.Name = "txtBoxAnswerTeam2";
            this.txtBoxAnswerTeam2.TextChanged += new System.EventHandler(this.ValidateAndChangeCase);
            // 
            // btnCheckWords
            // 
            resources.ApplyResources(this.btnCheckWords, "btnCheckWords");
            this.btnCheckWords.Name = "btnCheckWords";
            this.btnCheckWords.UseVisualStyleBackColor = true;
            this.btnCheckWords.Click += new System.EventHandler(this.btnCheckWords_Click);
            // 
            // lblScoreTeam1
            // 
            resources.ApplyResources(this.lblScoreTeam1, "lblScoreTeam1");
            this.lblScoreTeam1.ForeColor = System.Drawing.Color.White;
            this.lblScoreTeam1.Name = "lblScoreTeam1";
            // 
            // lblScoreTeam2
            // 
            resources.ApplyResources(this.lblScoreTeam2, "lblScoreTeam2");
            this.lblScoreTeam2.ForeColor = System.Drawing.Color.White;
            this.lblScoreTeam2.Name = "lblScoreTeam2";
            // 
            // btnTeamOneManualOverride
            // 
            resources.ApplyResources(this.btnTeamOneManualOverride, "btnTeamOneManualOverride");
            this.btnTeamOneManualOverride.Name = "btnTeamOneManualOverride";
            this.btnTeamOneManualOverride.UseVisualStyleBackColor = true;
            this.btnTeamOneManualOverride.Click += new System.EventHandler(this.BtnTeamOneManualOverride_Click);
            // 
            // btnTeamTwoManualOverride
            // 
            resources.ApplyResources(this.btnTeamTwoManualOverride, "btnTeamTwoManualOverride");
            this.btnTeamTwoManualOverride.Name = "btnTeamTwoManualOverride";
            this.btnTeamTwoManualOverride.UseVisualStyleBackColor = true;
            this.btnTeamTwoManualOverride.Click += new System.EventHandler(this.BtnTeamTwoManualOverride_Click);
            // 
            // btnEndRound
            // 
            resources.ApplyResources(this.btnEndRound, "btnEndRound");
            this.btnEndRound.Name = "btnEndRound";
            this.btnEndRound.UseVisualStyleBackColor = true;
            this.btnEndRound.Click += new System.EventHandler(this.btnEndRound_Click);
            // 
            // FrmLettersRound
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Blue;
            this.ControlBox = false;
            this.Controls.Add(this.btnEndRound);
            this.Controls.Add(this.btnTeamTwoManualOverride);
            this.Controls.Add(this.btnTeamOneManualOverride);
            this.Controls.Add(this.lblScoreTeam2);
            this.Controls.Add(this.lblScoreTeam1);
            this.Controls.Add(this.btnCheckWords);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.video);
            this.Controls.Add(this.btnVowel);
            this.Controls.Add(this.btnConsonant);
            this.Controls.Add(this.lblTeam2);
            this.Controls.Add(this.lblTeam1);
            this.Controls.Add(this.txtBoxAnswerTeam2);
            this.Controls.Add(this.txtBoxAnswerTeam1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.grpBoxLetters);
            this.Name = "FrmLettersRound";
            this.grpBoxLetters.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.video)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLetter1;
        private System.Windows.Forms.Label lblLetter2;
        private System.Windows.Forms.Label lblLetter3;
        private System.Windows.Forms.Label lblLetter4;
        private System.Windows.Forms.Label lblLetter5;
        private System.Windows.Forms.Label lblLetter7;
        private System.Windows.Forms.Label lblLetter6;
        private System.Windows.Forms.Label lblLetter8;
        private System.Windows.Forms.Label lblLetter9;
        private System.Windows.Forms.GroupBox grpBoxLetters;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtBoxAnswerTeam1;
        private System.Windows.Forms.Label lblTeam1;
        private System.Windows.Forms.Button btnConsonant;
        private System.Windows.Forms.Button btnVowel;
        private AxWMPLib.AxWindowsMediaPlayer video;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Label lblTeam2;
        private System.Windows.Forms.TextBox txtBoxAnswerTeam2;
        private System.Windows.Forms.Button btnCheckWords;
        private System.Windows.Forms.Label lblScoreTeam1;
        private System.Windows.Forms.Label lblScoreTeam2;
        private System.Windows.Forms.Button btnTeamOneManualOverride;
        private System.Windows.Forms.Button btnTeamTwoManualOverride;
        private System.Windows.Forms.Button btnEndRound;
    }
}

