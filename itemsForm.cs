using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecipeInTraining
{
    public partial class itemsForm : Form
    {
        public SqlConnection CreateItemsConnection;
        public itemsForm()
        {
            InitializeComponent();
        }

        private void itemBtn_Click(object sender, EventArgs e)
        {
            // opens connection
            if (CreateItemsConnection.State == ConnectionState.Closed)
            {
                CreateItemsConnection.Open();
            }

            // adds item to Database
            SqlCommand cmdAddItem = CreateItemsConnection.CreateCommand();
            cmdAddItem.CommandText = "INSERT INTO itemDesc VALUES(@itemName, @description, @recipeNum)";

            if (!string.IsNullOrEmpty(nameBox.Text))
            {
                cmdAddItem.Parameters.AddWithValue("itemName", nameBox.Text);
            }else { MessageBox.Show("Invalid Input: Please enter valid input"); }

            cmdAddItem.Parameters.AddWithValue("@description", descriptionBox.Text);
            
            cmdAddItem.Parameters.AddWithValue("recipeNum", RecipesFound.CurrentRow.Cells[0].Value);
            try
            {
                cmdAddItem.ExecuteNonQuery();
                MessageBox.Show("Item has been added.");
            }
            catch { MessageBox.Show("Item was not added"); }

            // clear textBox code
            nameBox.Text = "";
            descriptionBox.Text = "";

            SqlCommand GetItems = CreateItemsConnection.CreateCommand();
            GetItems.CommandText = @"SELECT itemName, description
                                     FROM itemDesc
                                     WHERE recipeNum = " + RecipesFound.CurrentRow.Cells[0].Value;
            SqlDataReader ItemReader = GetItems.ExecuteReader();
            DataTable ItemTable = new DataTable();
            ItemTable.Load(ItemReader);
            ItemDataTable.DataSource = ItemTable;
            ItemDataTable.Columns[0].HeaderText = "Applicance";
            ItemDataTable.Columns[1].HeaderText = "Description";
            ItemDataTable.Columns[0].Width = 75;
            ItemReader.Close();
        }

        private void itemsForm_Load(object sender, EventArgs e)
        {
            // opens connection
            if (CreateItemsConnection.State == ConnectionState.Closed)
            {
                CreateItemsConnection.Open();
            }

            SqlCommand cmdRetrieveData = CreateItemsConnection.CreateCommand();
            cmdRetrieveData.CommandText = @"SELECT recipeNum, nameOfDish, cuisine, time, timeType, serving, difficulty, author, description
                                             FROM recipeTable
                                             ORDER by recipeNum
                                             OFFSET(SELECT COUNT(*) -1 FROM recipeTable) rows";
            SqlDataReader reader = cmdRetrieveData.ExecuteReader();
            DataTable tempTable = new DataTable();
            tempTable.Load(reader);

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
            reader.Close();

        }

        private void SeeRecipeBtn_Click(object sender, EventArgs e)
        {
            string SelectedRecipeNum = RecipesFound.CurrentRow.Cells[0].Value.ToString();

            DisplayRecipe formRecipe = new DisplayRecipe();
            formRecipe.RecipeConnection = CreateItemsConnection;
            formRecipe.RecipeKey = int.Parse(SelectedRecipeNum);
            formRecipe.ShowDialog();
        }
    }
}
