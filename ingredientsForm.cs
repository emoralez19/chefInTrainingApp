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

namespace RecipeInTraining
{

    public partial class ingredientsForm : Form
    {
        public SqlConnection CreateIngredientsConnection;

        public ingredientsForm()
        {
            InitializeComponent();
        }

        private void loadRecipe_Click(object sender, EventArgs e)
        {
            /*// opens connection
            if (CreateIngredientsConnection.State == ConnectionState.Closed)
            {
                CreateIngredientsConnection.Open();
            }

            SqlCommand cmdRetrieveData = CreateIngredientsConnection.CreateCommand();


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

        private void ingredientBtn_Click(object sender, EventArgs e)
        {
            // opens connection
            if (CreateIngredientsConnection.State == ConnectionState.Closed)
            {
                CreateIngredientsConnection.Open();
            }

            // add ingredient to database

            SqlCommand cmdAddIngredient = CreateIngredientsConnection.CreateCommand();
            cmdAddIngredient.CommandText = "INSERT INTO ingredientTable VALUES(@recipeNum, @ingredient, @ingAmt, @amtType)";

            cmdAddIngredient.Parameters.AddWithValue("@recipeNum", RecipesFound.CurrentRow.Cells[0].Value);

            if (!string.IsNullOrEmpty(ingredientBox.Text))
            {
                cmdAddIngredient.Parameters.AddWithValue("@ingredient", ingredientBox.Text);
            }
            else { MessageBox.Show("Invalid input: Please Enter a valid input"); }

            try
            {
                if (Int32.Parse(ingAmtBox.Text) > 0)
                {
                    cmdAddIngredient.Parameters.AddWithValue("@ingAmt", ingAmtBox.Text);
                }
                else { MessageBox.Show("Invalid input: Please enter a valid input"); }
            }
            catch(Exception ex) { MessageBox.Show("Error: " + ex.Message + "\nPlease try again"); }

            if (!string.IsNullOrEmpty(amtTypeBox.Text))
            {
                cmdAddIngredient.Parameters.AddWithValue("@amtType", amtTypeBox.Text);
            }
            else { MessageBox.Show("Invalid input: Please enter a valid input"); }

            try
            {
                cmdAddIngredient.ExecuteNonQuery();
                MessageBox.Show("Ingredient has been added.");
            }catch(Exception ex) { MessageBox.Show("Ingredient was not added"); }

            // clear textBox code
            ingredientBox.Text = "";
            ingAmtBox.Text = "";
            amtTypeBox.Text = "";

            
            SqlCommand GetIngredients = CreateIngredientsConnection.CreateCommand();
            GetIngredients.CommandText = @"SELECT ingredient, ingAmt, amtType
                                           FROM ingredientTable
                                           WHERE recipeNum = " + RecipesFound.CurrentRow.Cells[0].Value;
            SqlDataReader IngredientsReader = GetIngredients.ExecuteReader();
            DataTable IngTable = new DataTable();
            IngTable.Load(IngredientsReader);
            IngredientsDataTable.DataSource = IngTable;
            IngredientsDataTable.Columns[0].HeaderText = "Ingredient";
            IngredientsDataTable.Columns[1].HeaderText = "Amount";
            IngredientsDataTable.Columns[2].HeaderText = "Amount Type";
            IngredientsReader.Close();

        }

        private void itemsBtn_Click(object sender, EventArgs e)
        {   
            // opens items form
            itemsForm newForm = new itemsForm();
            newForm.CreateItemsConnection = CreateIngredientsConnection;
            newForm.ShowDialog();
            this.Close();
        }

        private void ingredientsForm_Load(object sender, EventArgs e)
        {

            if (CreateIngredientsConnection.State == ConnectionState.Closed)
            {
                CreateIngredientsConnection.Open();
            }

            SqlCommand cmdRetrieveData = CreateIngredientsConnection.CreateCommand();
            cmdRetrieveData.CommandText = @"SELECT recipeNum, nameOfDish, cuisine, time, timeType, serving, difficulty, author, description
                                             FROM recipeTable
                                             ORDER by recipeNum
                                             OFFSET(SELECT COUNT(*) -1 FROM recipeTable) rows";

            SqlDataReader reader = cmdRetrieveData.ExecuteReader();
            DataTable tempTable = new DataTable();
            tempTable.Load(reader);
            
            RecipesFound.DataSource = tempTable;
           // RecipesFound.Columns[0].Visible = false;
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
