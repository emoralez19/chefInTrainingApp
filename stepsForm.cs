using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.Odbc;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecipeInTraining
{
 
    public partial class stepsForm : Form
    {
        public SqlConnection CreateStepsConnection;

        public stepsForm()
        {
            InitializeComponent();
        }


        private void RecipesFound_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void loadRecipe_Click(object sender, EventArgs e)
        {
           /* // opens connection
            if (CreateStepsConnection.State == ConnectionState.Closed)
            {
                CreateStepsConnection.Open();
            }

            SqlCommand cmdRetrieveData = CreateStepsConnection.CreateCommand();


            // sql statement to populate the database
            cmdRetrieveData.CommandText = @"SELECT recipeNum, nameOfDish, cuisine, time, timeType, serving, difficulty, author, description
                                             FROM recipeTable
                                             ORDER by recipeNum
                                             OFFSET(SELECT COUNT(*) -1 FROM recipeTable) rows";


            SqlDataReader reader = cmdRetrieveData.ExecuteReader();

            DataTable tempTable = new DataTable();

            tempTable.Load(reader);

            RecipesFound.DataSource = tempTable;*/
        }

        private int i = 0;

        private void enterBtn_Click(object sender, EventArgs e)
        {
            // opens connection
            if (CreateStepsConnection.State == ConnectionState.Closed)
            {
                CreateStepsConnection.Open();
            }

            // add form to database
            SqlCommand cmdAddSteps = CreateStepsConnection.CreateCommand();
            cmdAddSteps.CommandText = "INSERT INTO stepsTable VALUES(@recipeNum, @stepNum, @step)";

            cmdAddSteps.Parameters.AddWithValue("@recipeNum", RecipesFound.CurrentRow.Cells[0].Value);

            // increment step value by 1
            if (!string.IsNullOrEmpty(stepBox.Text))
            {
                i++;
                cmdAddSteps.Parameters.AddWithValue("@stepNum", i);

                cmdAddSteps.Parameters.AddWithValue("@step", stepBox.Text);

                cmdAddSteps.ExecuteNonQuery();
                MessageBox.Show("Step has been added.");
            }
            else
            {
                MessageBox.Show("Invalid input: Please add a step");
            }

            // clear textBox code
            stepBox.Text = "";

            SqlCommand GetSteps = CreateStepsConnection.CreateCommand();
            GetSteps.CommandText = @"SELECT stepNum, step
                                     FROM stepsTable
                                     WHERE recipeNum = " + RecipesFound.CurrentRow.Cells[0].Value + " GROUP BY stepNum, step";
            SqlDataReader StepsReader = GetSteps.ExecuteReader();
            DataTable StepsTable = new DataTable();
            StepsTable.Load(StepsReader);
            StepsDataTable.DataSource = StepsTable;
            StepsDataTable.Columns[0].HeaderText = "Order";
            StepsDataTable.Columns[1].HeaderText = "Step";
            StepsDataTable.Columns[0].Width = 50;
            StepsReader.Close();

        }

        private void ingredientsBtn_Click(object sender, EventArgs e)
        {
            //closes form
            this.Close();

            // opens ingredients form
            ingredientsForm newForm = new ingredientsForm();
            newForm.CreateIngredientsConnection = CreateStepsConnection;
            newForm.ShowDialog();
        }

        private void StepsDataTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void stepsForm_Load(object sender, EventArgs e)
        {
            // opens connection
            if (CreateStepsConnection.State == ConnectionState.Closed)
            {
                CreateStepsConnection.Open();
            }

            SqlCommand cmdRetrieveData = CreateStepsConnection.CreateCommand();
            cmdRetrieveData.CommandText = @"SELECT recipeNum, nameOfDish, cuisine, time, timeType, serving, difficulty, author, description
                                             FROM recipeTable
                                             ORDER by recipeNum
                                             OFFSET(SELECT COUNT(*) -1 FROM recipeTable) rows";
            SqlDataReader reader = cmdRetrieveData.ExecuteReader();
            DataTable tempTable = new DataTable();
            tempTable.Load(reader);

            RecipesFound.DataSource = tempTable;

            RecipesFound.DataSource = tempTable;

            //RecipesFound.Columns[0].Visible = false;
            RecipesFound.Columns[1].HeaderText = "Name";
            RecipesFound.Columns[2].HeaderText = "Cuisine";
            RecipesFound.Columns[3].HeaderText = "Time";
            RecipesFound.Columns[4].HeaderText = "Type";
            RecipesFound.Columns[5].HeaderText = "Servings";
            RecipesFound.Columns[6].HeaderText = "Difficulty";
            RecipesFound.Columns[7].HeaderText = "Author";
            RecipesFound.Columns[8].HeaderText = "Description";
        }
    }
}
