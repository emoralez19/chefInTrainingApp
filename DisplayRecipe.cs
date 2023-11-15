using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.Odbc;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace RecipeInTraining
{
    public partial class DisplayRecipe : Form
    {
        public SqlConnection RecipeConnection;
        public int RecipeKey;
        public DisplayRecipe()
        {
            InitializeComponent();
            
        }

        private void DisplayRecipe_Load(object sender, EventArgs e)
        {

            //name of Recipe
            SqlCommand retrieveData = RecipeConnection.CreateCommand();
            retrieveData.CommandText = "SELECT nameOfDish, Difficulty, cuisine, time, timeType, description, serving, Author" +
                                        " From recipeTable  Where recipeNum = " + RecipeKey;
            SqlDataReader retrieveDataReader = retrieveData.ExecuteReader();

            retrieveDataReader.Read();
            NameOfRecipe.Text = retrieveDataReader[0].ToString();
            DisplayDiffLabel.Text = retrieveDataReader[1].ToString();
            DisplayCuisineLabel.Text = retrieveDataReader[2].ToString();

            float tempTime = float.Parse(retrieveDataReader[3].ToString());
            string tempTimeType = retrieveDataReader[4].ToString();
            if (tempTimeType.Equals("min"))
            {
                TimeDisplayMinutesLabel.Text = tempTime.ToString();
                DisplayHourTimeLabel.Text = "0";
            }
            else
            {
                float minute = tempTime % 1 * 60;
                float hour = (tempTime - (tempTime % 1));
                DisplayHourTimeLabel.Text = hour.ToString();
                TimeDisplayMinutesLabel.Text = Math.Round(minute).ToString();
            }

            DescriptionText.Text = retrieveDataReader[5].ToString();
            ServingAmt.Text = retrieveDataReader[6].ToString();
            AuthorName.Text = retrieveDataReader[7].ToString();

            retrieveDataReader.Close();

            SqlCommand GetIngredients = RecipeConnection.CreateCommand();
            GetIngredients.CommandText = @"SELECT ingredient, ingAmt, amtType
                                           FROM ingredientTable
                                           WHERE recipeNum = " + RecipeKey;
            SqlDataReader IngredientsReader = GetIngredients.ExecuteReader();
            DataTable IngTable = new DataTable();
            IngTable.Load(IngredientsReader);
            IngredientsDataGrid.DataSource = IngTable;
            IngredientsDataGrid.Columns[0].HeaderText = "Ingredient";
            IngredientsDataGrid.Columns[1].HeaderText = "Amount";
            IngredientsDataGrid.Columns[2].HeaderText = "Amount Type";
            IngredientsReader.Close();

            SqlCommand GetSteps = RecipeConnection.CreateCommand();
            GetSteps.CommandText = @"SELECT stepNum, step
                                     FROM stepsTable
                                     WHERE recipeNum = " + RecipeKey+ " GROUP BY stepNum, step";
            SqlDataReader StepsReader = GetSteps.ExecuteReader();
            DataTable StepsTable = new DataTable();
            StepsTable.Load(StepsReader);
            StepsDataGrid.DataSource = StepsTable;
            StepsDataGrid.Columns[0].HeaderText = "Order";
            StepsDataGrid.Columns[1].HeaderText = "Step";
            StepsDataGrid.Columns[0].Width= 50;
            StepsReader.Close();

            SqlCommand GetItems = RecipeConnection.CreateCommand();
            GetItems.CommandText = @"SELECT itemName, description
                                     FROM itemDesc
                                     WHERE recipeNum = " + RecipeKey;
            SqlDataReader ItemReader = GetItems.ExecuteReader();
            DataTable ItemTable = new DataTable();
            ItemTable.Load(ItemReader);
            AppDataGrid.DataSource = ItemTable;
            AppDataGrid.Columns[0].HeaderText = "Applicance";
            AppDataGrid.Columns[1].HeaderText = "Description";
            AppDataGrid.Columns[0].Width = 75;
            ItemReader.Close();

            SqlCommand GetPic = RecipeConnection.CreateCommand();
            GetPic.CommandText = @"SELECT Picture
                                     FROM recipeTable
                                     WHERE recipeNum = " + RecipeKey;
            SqlDataReader picReader = GetPic.ExecuteReader();

            try
            {
                picReader.Read();
                byte[] picArr = (byte[])picReader[0];
                Stream picMem = new MemoryStream(picArr);
                picMem.Seek(0, SeekOrigin.Begin);
                pictureBox1.Image = Image.FromStream(picMem);
            }
            catch { }
          picReader.Close();
           
            
        }

        private void EditRecipeButton_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void IngredientsDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            SqlCommand DeleteIngData = RecipeConnection.CreateCommand();
            DeleteIngData.CommandText = "Delete from ingredientTable where recipeNum = " + RecipeKey;
            DeleteIngData.ExecuteNonQuery();
            //DeleteIngData.EndExecuteNonQuery();
           


            SqlCommand DeleteAppData = RecipeConnection.CreateCommand();
            DeleteAppData.CommandText = "Delete from itemDesc where recipeNum = " + RecipeKey;
            DeleteAppData.ExecuteNonQuery();

            SqlCommand DeleteStepsData = RecipeConnection.CreateCommand();
            DeleteStepsData.CommandText = "Delete from stepsTable where recipeNum = " + RecipeKey;
            DeleteStepsData.ExecuteNonQuery();

            SqlCommand DeleteRecipeData = RecipeConnection.CreateCommand();
            DeleteRecipeData.CommandText = "Delete from recipeTable where recipeNum = " + RecipeKey;
            DeleteRecipeData.ExecuteNonQuery();

            this.Close();
        }
    }
}
