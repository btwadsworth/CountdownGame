namespace CountdownGame
{
    partial class frmCreateTeams
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxTeamOneName = new System.Windows.Forms.TextBox();
            this.txtBoxTeamTwoName = new System.Windows.Forms.TextBox();
            this.lblWarning1 = new System.Windows.Forms.Label();
            this.lblWarning2 = new System.Windows.Forms.Label();
            this.btnSaveTeamNames = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(109, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(303, 82);
            this.label1.TabIndex = 0;
            this.label1.Text = "TEAM ONE:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Impact", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(97, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(326, 82);
            this.label2.TabIndex = 3;
            this.label2.Text = "TEAM TWO:";
            // 
            // txtBoxTeamOneName
            // 
            this.txtBoxTeamOneName.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxTeamOneName.Location = new System.Drawing.Point(12, 94);
            this.txtBoxTeamOneName.MaxLength = 20;
            this.txtBoxTeamOneName.Name = "txtBoxTeamOneName";
            this.txtBoxTeamOneName.Size = new System.Drawing.Size(497, 53);
            this.txtBoxTeamOneName.TabIndex = 1;
            // 
            // txtBoxTeamTwoName
            // 
            this.txtBoxTeamTwoName.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxTeamTwoName.Location = new System.Drawing.Point(12, 284);
            this.txtBoxTeamTwoName.MaxLength = 20;
            this.txtBoxTeamTwoName.Name = "txtBoxTeamTwoName";
            this.txtBoxTeamTwoName.Size = new System.Drawing.Size(497, 53);
            this.txtBoxTeamTwoName.TabIndex = 4;
            // 
            // lblWarning1
            // 
            this.lblWarning1.AutoSize = true;
            this.lblWarning1.Font = new System.Drawing.Font("Impact", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWarning1.ForeColor = System.Drawing.Color.Yellow;
            this.lblWarning1.Location = new System.Drawing.Point(137, 150);
            this.lblWarning1.Name = "lblWarning1";
            this.lblWarning1.Size = new System.Drawing.Size(247, 18);
            this.lblWarning1.TabIndex = 2;
            this.lblWarning1.Text = "(Team name may not excede 20 characters)";
            // 
            // lblWarning2
            // 
            this.lblWarning2.AutoSize = true;
            this.lblWarning2.Font = new System.Drawing.Font("Impact", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWarning2.ForeColor = System.Drawing.Color.Yellow;
            this.lblWarning2.Location = new System.Drawing.Point(137, 340);
            this.lblWarning2.Name = "lblWarning2";
            this.lblWarning2.Size = new System.Drawing.Size(247, 18);
            this.lblWarning2.TabIndex = 5;
            this.lblWarning2.Text = "(Team name may not excede 20 characters)";
            // 
            // btnSaveTeamNames
            // 
            this.btnSaveTeamNames.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnSaveTeamNames.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSaveTeamNames.Font = new System.Drawing.Font("Impact", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveTeamNames.Location = new System.Drawing.Point(12, 391);
            this.btnSaveTeamNames.Name = "btnSaveTeamNames";
            this.btnSaveTeamNames.Size = new System.Drawing.Size(497, 66);
            this.btnSaveTeamNames.TabIndex = 6;
            this.btnSaveTeamNames.Text = "LET\'S PLAY COUNTDOWN!";
            this.btnSaveTeamNames.UseVisualStyleBackColor = false;
            this.btnSaveTeamNames.Click += new System.EventHandler(this.btnSaveTeamNames_Click);
            // 
            // frmCreateTeams
            // 
            this.AcceptButton = this.btnSaveTeamNames;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Blue;
            this.ClientSize = new System.Drawing.Size(520, 478);
            this.ControlBox = false;
            this.Controls.Add(this.btnSaveTeamNames);
            this.Controls.Add(this.lblWarning2);
            this.Controls.Add(this.lblWarning1);
            this.Controls.Add(this.txtBoxTeamTwoName);
            this.Controls.Add(this.txtBoxTeamOneName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmCreateTeams";
            this.Text = "frmCreateTeams";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxTeamOneName;
        private System.Windows.Forms.TextBox txtBoxTeamTwoName;
        private System.Windows.Forms.Label lblWarning1;
        private System.Windows.Forms.Label lblWarning2;
        private System.Windows.Forms.Button btnSaveTeamNames;
    }
}