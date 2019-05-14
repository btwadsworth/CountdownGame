using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CountdownGame
{
    public partial class frmAllGames : Form
    {
        /**
         * Ben Wadsworth
         * 5/13/2019
         * This form is just for showing the past games in a DataGridView
         **/
        public frmAllGames()
        {
            InitializeComponent();
        }

        private void allGamesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.allGamesBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.countdownDataSet);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
            

        }

        private void AllGames_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: This line of code loads data into the 'countdownDataSet.AllGames' table. You can move, or remove it, as needed.
                this.allGamesTableAdapter.Fill(this.countdownDataSet.AllGames);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
            

        }
    }
}
