namespace CountdownGame
{
    partial class frmAllGames
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
            this.components = new System.ComponentModel.Container();
            this.countdownDataSet = new CountdownGame.CountdownDataSet();
            this.allGamesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.allGamesTableAdapter = new CountdownGame.CountdownDataSetTableAdapters.AllGamesTableAdapter();
            this.tableAdapterManager = new CountdownGame.CountdownDataSetTableAdapters.TableAdapterManager();
            this.allGamesDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.countdownDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.allGamesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.allGamesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // countdownDataSet
            // 
            this.countdownDataSet.DataSetName = "CountdownDataSet";
            this.countdownDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // allGamesBindingSource
            // 
            this.allGamesBindingSource.DataMember = "AllGames";
            this.allGamesBindingSource.DataSource = this.countdownDataSet;
            // 
            // allGamesTableAdapter
            // 
            this.allGamesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AllGamesTableAdapter = this.allGamesTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DictionaryTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = CountdownGame.CountdownDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // allGamesDataGridView
            // 
            this.allGamesDataGridView.AllowUserToAddRows = false;
            this.allGamesDataGridView.AllowUserToDeleteRows = false;
            this.allGamesDataGridView.AutoGenerateColumns = false;
            this.allGamesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.allGamesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.allGamesDataGridView.DataSource = this.allGamesBindingSource;
            this.allGamesDataGridView.Location = new System.Drawing.Point(9, 10);
            this.allGamesDataGridView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.allGamesDataGridView.Name = "allGamesDataGridView";
            this.allGamesDataGridView.ReadOnly = true;
            this.allGamesDataGridView.RowTemplate.Height = 24;
            this.allGamesDataGridView.Size = new System.Drawing.Size(456, 189);
            this.allGamesDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Game";
            this.dataGridViewTextBoxColumn1.HeaderText = "Game";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 60;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Winner";
            this.dataGridViewTextBoxColumn2.HeaderText = "Winner";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 66;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "WinningScore";
            this.dataGridViewTextBoxColumn3.HeaderText = "WinningScore";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 99;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Loser";
            this.dataGridViewTextBoxColumn4.HeaderText = "Loser";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 58;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn5.DataPropertyName = "LosingScore";
            this.dataGridViewTextBoxColumn5.HeaderText = "LosingScore";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 91;
            // 
            // frmAllGames
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 217);
            this.Controls.Add(this.allGamesDataGridView);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmAllGames";
            this.Text = "AllGames";
            this.Load += new System.EventHandler(this.AllGames_Load);
            ((System.ComponentModel.ISupportInitialize)(this.countdownDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.allGamesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.allGamesDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CountdownDataSet countdownDataSet;
        private System.Windows.Forms.BindingSource allGamesBindingSource;
        private CountdownDataSetTableAdapters.AllGamesTableAdapter allGamesTableAdapter;
        private CountdownDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView allGamesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}