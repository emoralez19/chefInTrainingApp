using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecipeInTraining
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            searchForm newForm = new searchForm();
            newForm.DBConnection = sqlConnection1;
            newForm.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                sqlConnection1.Open();
                MessageBox.Show("DB is connected");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
