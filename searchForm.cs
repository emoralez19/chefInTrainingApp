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
using System.Windows.Forms.VisualStyles;

namespace RecipeInTraining
{
    public partial class searchForm : Form
    {
       public SqlConnection DBConnection;
        public static int SelectedRecipeNum;
        public searchForm()
        {
            InitializeComponent();
            RecipesFound.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }



        private void button1_Click(object sender, EventArgs e)
        {
            int numOfEntities = 0;
            string cuisine = CuisineComboBox.Text;
            string difficult= CourseComboBox.Text;
            string time = CookTimeCombo.Text;
            string servings = ServingSizeCombo.Text;
            string name = NameSearchBar.Text;
            string ingredient = IngredientsSearchBar.Text;
            string fromString = "FROM recipeTable as r";
            string whereString = "\nWHERE";
            
            if (!string.IsNullOrEmpty(name))
            {
                whereString += " nameOfDish = @name";
                numOfEntities++;

            }
            if (!string.IsNullOrEmpty(ingredient))
            {
                if(numOfEntities != 0)
                {
                    whereString += (" AND");
                }
                fromString += " JOIN  ingredientTable as i On r.recipeNum = i.recipeNum";
                whereString += " i.ingredient = @ingred";
                numOfEntities++;
            }
            if (!string.IsNullOrEmpty(cuisine) && !cuisine.Equals("*Not selected*"))
            {
                if (numOfEntities == 0)
                {
                    whereString += " r.cuisine = '" + cuisine + "'";

                }
                else if (numOfEntities > 0)
                {
                    whereString += " AND r.cuisine = '" + cuisine + "'";
                }
                numOfEntities++;
            }
            if (!string.IsNullOrEmpty(difficult) && !difficult.Equals("*Not selected*"))
            {
                if (numOfEntities == 0)
                {
                    whereString += " r.difficulty = '" + difficult + "'";
                }
                else if (numOfEntities > 0)
                {
                    whereString += (" AND r.difficulty = " + difficult );
                    // NameSearchBar.Text = whereString;
                }
                numOfEntities++;
            }
            if (!string.IsNullOrEmpty(servings) && !servings.Equals("*Not selected*"))
            {
                if (numOfEntities != 0)
                {
                    whereString += (" AND");
                }
                if(servings.Equals("1 - 4"))
                {
                    whereString += (" serving BETWEEN 0 AND 4");
                }
                else if(servings.Equals("4 - 8"))
                {
                    whereString += (" serving BETWEEN 4 AND 8");
                }
                else if(servings.Equals("8 - 16"))
                {
                    whereString += (" serving BETWEEN 8 AND 16");
                }
                else if(servings.Equals("16 and up"))
                {
                    whereString += (" serving >= 16");
                }
                numOfEntities++;

            }
            if (!string.IsNullOrEmpty(time) && !time.Equals("*Not selected*"))
            {
                if(numOfEntities != 0)
                {
                    whereString += (" AND");
                }
                
                if(time.Equals("0 - 30 min"))
                {
                    whereString += (" timeType = 'min' AND time IN (Select time\r\n\t\t\t\t\t\t\t\t\t\tFROM recipeTable\r\n\t\t\t\t\t\t\t\t\t\tWhere time BETWEEN 0 AND 30);");
                }
                else if (time.Equals("30 min - 59 min"))
                {
                    whereString += (" timeType = 'min' AND time IN (Select time\r\n\t\t\t\t\t\t\t\t\t\tFROM recipeTable\r\n\t\t\t\t\t\t\t\t\t\tWhere time BETWEEN 30 AND 60);");
                }
                else if (time.Equals("1 - 2 hours"))
                {
                    whereString += (" timeType = 'hrs' AND time IN (Select time\r\n\t\t\t\t\t\t\t\t\t\tFROM recipeTable\r\n\t\t\t\t\t\t\t\t\t\tWhere time BETWEEN 1 AND 2);");
                }
                else if (time.Equals("2 - 4 hours"))
                {
                    whereString += (" timeType = 'hrs' AND time IN (Select time\r\n\t\t\t\t\t\t\t\t\t\tFROM recipeTable\r\n\t\t\t\t\t\t\t\t\t\tWhere time BETWEEN 2 AND 4);");
                }
                else if (time.Equals("4 - 8 hours"))
                {
                    whereString += (" timeType = 'hrs' AND time IN (Select time\r\n\t\t\t\t\t\t\t\t\t\tFROM recipeTable\r\n\t\t\t\t\t\t\t\t\t\tWhere time BETWEEN 4 AND 8);");
                }
                else if (time.Equals("8 hours and up"))
                {
                    whereString += (" r.timeType = 'hrs' AND r.time IN (Select time\r\n\t\t\t\t\t\t\t\t\t\tFROM recipeTable\r\n\t\t\t\t\t\t\t\t\t\tWhere time >= 8);");
                }
                numOfEntities++;
                
            }


            try
            {
                SqlCommand cmdRetrieveData = DBConnection.CreateCommand();
                if (whereString.Equals("\nWHERE"))
                {
                    cmdRetrieveData.CommandText = @"SELECT nameOfDish, description, serving, time, timeType, difficulty, cuisine, r.recipeNum " + fromString;
                }
                else
                {
                   
                    cmdRetrieveData.CommandText = @"SELECT nameOfDish, description, serving, time, timeType, difficulty, cuisine, r.recipeNum " +
                                                  fromString + " " + whereString;
                    cmdRetrieveData.Parameters.AddWithValue("@name", name);
                    cmdRetrieveData.Parameters.AddWithValue("@ingred", ingredient);
                }


                SqlDataReader reader = cmdRetrieveData.ExecuteReader();
            


                DataTable tempTable = new DataTable();

                tempTable.Load(reader);

                RecipesFound.DataSource = tempTable;
                RecipesFound.Columns[0].HeaderText = "Name";
                RecipesFound.Columns[1].HeaderText = "Description";
                RecipesFound.Columns[2].HeaderText = "Serving";
                RecipesFound.Columns[3].HeaderText = "Time";
                RecipesFound.Columns[4].HeaderText = "Time Type";
                RecipesFound.Columns[5].HeaderText = "Difficulty";
                RecipesFound.Columns[6].HeaderText = "Cuisine";

                RecipesFound.Columns[7].Visible = false;
                reader.Close();
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex + "\nPlease try again"); }

            numOfEntities = 0;
            fromString = "FROM recipeTable as r";
            whereString = "\nWHERE";
        }

        private void CuisineComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void searchForm_Load(object sender, EventArgs e)
        {

            //------------------------------------------------   
            //     Loading up the comboboxes
            //------------------------------------------------

            //-------
            //Cuisine
            //-------
            if (DBConnection.State == ConnectionState.Closed)
            {
                DBConnection.Open();
            }
            SqlCommand cmdLoadCuisine = DBConnection.CreateCommand();
            cmdLoadCuisine.CommandText = "SELECT cuisine From recipeTable group by cuisine ";
            SqlDataReader CuisineReader = cmdLoadCuisine.ExecuteReader();
            CuisineComboBox.Items.Add("*Not selected*");
            while (CuisineReader.Read())
            {
                if (!CuisineComboBox.Items.Contains(CuisineReader[0]))
                {
                    CuisineComboBox.Items.Add(CuisineReader[0]);
                }
            }
            CuisineReader.Close();

            //--------
            //Servings
            //--------
            ServingSizeCombo.Items.Add("*Not selected*");
            ServingSizeCombo.Items.Add("1 - 4");
            ServingSizeCombo.Items.Add("4 - 8");
            ServingSizeCombo.Items.Add("8 - 16");
            ServingSizeCombo.Items.Add("16 and up");

            //------
            // Time
            //------
            CookTimeCombo.Items.Add("*Not selected*");
            CookTimeCombo.Items.Add("0 - 30 min");
            CookTimeCombo.Items.Add("30 min - 59 min");
            CookTimeCombo.Items.Add("1 - 2 hours");
            CookTimeCombo.Items.Add("2 - 4 hours");
            CookTimeCombo.Items.Add("4 - 8 hours");
            CookTimeCombo.Items.Add("8 hours and up");

            //----------
            //Difficulty
            //----------
            SqlCommand cmdLoadDiff = DBConnection.CreateCommand();
            cmdLoadDiff.CommandText = "SELECT difficulty From recipeTable group by difficulty ";
            SqlDataReader Diffreader = cmdLoadDiff.ExecuteReader();
            CourseComboBox.Items.Add("*Not selected*");

            while (Diffreader.Read())
            {
                if (!CourseComboBox.Items.Contains(Diffreader[0]))
                {
                    CourseComboBox.Items.Add(Diffreader[0]);
                    
                }
            }
            cmdLoadCuisine.CommandText = "SELECT course From recipeTable  ";


            Diffreader.Close();
            MessageBox.Show("cuisines loaded");
        }

        private void IngredientsSearchBar_TextChanged(object sender, EventArgs e)
        {

        }

        private void RecipesFound_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string SelectedRecipeNum = RecipesFound.SelectedRows[0].Cells["recipeNum"].Value.ToString();
            
            DisplayRecipe formRecipe = new DisplayRecipe();
            formRecipe.RecipeConnection = DBConnection;
            formRecipe.RecipeKey = int.Parse(SelectedRecipeNum);
            formRecipe.ShowDialog();
      
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void NameSearchBar_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
