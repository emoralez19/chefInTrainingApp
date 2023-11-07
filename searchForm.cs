using System;
using System.Collections.Generic;
using System.Collections.Specialized;
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
    public partial class searchForm : Form
    {
       public SqlConnection DBConnection;
        public searchForm()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            int numOfEntities = 0;
            string cuisine = CuisineComboBox.Text;
            string difficult= CourseComboBox.Text;
            string time = CookTimeCombo.Text;
            string servings = ServingSizeCombo.Text;
            string whereString = "\nWHERE";

            if (!string.IsNullOrEmpty(cuisine))
            {
               
                if (numOfEntities == 0)
                {
                    //IngredientsSearchBar.Text = numOfEntities.ToString();
                    whereString += " cuisine = '" + cuisine + "'";
                    //NameSearchBar.Text = whereString;
                }
                else if (numOfEntities > 1)
                {
                    whereString.Concat(" AND cuisine = '" + cuisine + "'");
                }
                numOfEntities++;
            }
            if (!string.IsNullOrEmpty(difficult))
            {
                if (numOfEntities == 0)
                {
                    whereString += " difficulty = '" + difficult + "'";
                }
                else if (numOfEntities > 0)
                {
                    whereString += (" AND difficulty = " + difficult );
                    //NameSearchBar.Text = whereString;
                }
            }
            if (!string.IsNullOrEmpty(time))
            {

            }
            if (!string.IsNullOrEmpty(servings))
            {

            }


            SqlCommand cmdRetrieveData = DBConnection.CreateCommand();
            cmdRetrieveData.CommandText = @"SELECT nameOfDish, description, serving, time, cuisine
                                            FROM recipeTable " + whereString;


            SqlDataReader reader = cmdRetrieveData.ExecuteReader();



            DataTable tempTable = new DataTable();

            tempTable.Load(reader);

            RecipesFound.DataSource = tempTable;

            reader.Close();
        }

        private void CuisineComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*string CuisineText = CuisineComboBox.Text;

            SqlCommand cmdRetrieveCuisine = DBConnection.CreateCommand();
            cmdRetrieveCuisine.CommandText = @"SELECT *
                                               FROM recipeTable 
                                               WHERE Cuisine = '" + CuisineText + "'";

            SqlDataReader reader = cmdRetrieveCuisine.ExecuteReader();

            // SqlDataReader reader = cmdRetrieveCuisine.ExecuteReader();

            DataTable tempTable = new DataTable();
            tempTable.Load(reader);

            RecipesFound.DataSource = tempTable;

            reader.Close();*/
        }

        private void searchForm_Load(object sender, EventArgs e)
        {
            
        //------------------------------------------------   
        //     Loading up the comboboxes
        //------------------------------------------------
            
            //-------
            //Cuisine
            //-------
            SqlCommand cmdLoadCuisine = DBConnection.CreateCommand();
            cmdLoadCuisine.CommandText = "SELECT cuisine From recipeTable ";
            SqlDataReader CuisineReader = cmdLoadCuisine.ExecuteReader();

            while (CuisineReader.Read())
            {
                CuisineComboBox.Items.Add(CuisineReader[0].ToString());
            }
            CuisineReader.Close();

            //--------
            //Servings
            //--------
            ServingSizeCombo.Items.Add("1 - 4");
            ServingSizeCombo.Items.Add("5 - 8");
            ServingSizeCombo.Items.Add("8 - 16");
            ServingSizeCombo.Items.Add("17 and up");

            //------
            // Time
            //------
            CookTimeCombo.Items.Add("0-30 min");
            CookTimeCombo.Items.Add("30 minutes - 1 hour");
            CookTimeCombo.Items.Add("1 - 2 hours");
            CookTimeCombo.Items.Add("2 - 4 hours");
            CookTimeCombo.Items.Add("4 - 8 hours");
            CookTimeCombo.Items.Add("8 hours and up");

            //----------
            //Difficulty
            //----------
            SqlCommand cmdLoadDiff = DBConnection.CreateCommand();
            cmdLoadDiff.CommandText = "SELECT difficulty From recipeTable ";
            SqlDataReader Diffreader = cmdLoadDiff.ExecuteReader();

            while (Diffreader.Read())
            {
                CourseComboBox.Items.Add(Diffreader[0].ToString());
            }
            cmdLoadCuisine.CommandText = "SELECT course From recipeTable ";


            Diffreader.Close();
            MessageBox.Show("cuisines loaded");
        }

        private void IngredientsSearchBar_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
