using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecipeInTraining
{
    public partial class createForm : Form
    {
        public SqlConnection CreateDBConnection;

        public createForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void enterRecipe_Click(object sender, EventArgs e)
        {
            SqlCommand cmdAddRecipe = CreateDBConnection.CreateCommand();
            cmdAddRecipe.CommandText = "INSERT INTO recipeTable VALUES(@nameOfDish, @cuisine, @time, @timeType, @serving, @difficulty, @author, @description, @Picture)";

            if (!string.IsNullOrEmpty(nameBox.Text))
            {
                cmdAddRecipe.Parameters.AddWithValue("@nameOfDish", nameBox.Text);
            }
            else
            {
                MessageBox.Show("Invalid Name, Please try again");
            }
            if (!string.IsNullOrEmpty(cuisineBox.Text))
            {
                cmdAddRecipe.Parameters.AddWithValue("@cuisine", cuisineBox.Text);
            }
            else { MessageBox.Show("Invalid cuisine, Please try again"); }

            try
            {

                if (hourBox.Text.Length != 0)
                {
                    // if there is a value in minutes box, the hour box value is more than 0, and the minutes box value is more than 0 and less than 60 add to database
                    if (minBox.Text.Length != 0 && int.Parse(hourBox.Text) > 0 && int.Parse(minBox.Text) > 0 && int.Parse(minBox.Text) < 60)
                    {
                        cmdAddRecipe.Parameters.AddWithValue("@time", (float.Parse(hourBox.Text)) + (float.Parse(minBox.Text) / 60));

                        cmdAddRecipe.Parameters.AddWithValue("@timeType", "hrs");
                    }
                    // if the minutes box value is empty and the hour box value is greater than 0 add to database
                    else if (minBox.Text.Length == 0 && int.Parse(hourBox.Text) > 0)
                    {
                        cmdAddRecipe.Parameters.AddWithValue("@time", hourBox.Text);

                        cmdAddRecipe.Parameters.AddWithValue("@timeType", "hrs");
                    }
                    // show error
                    else
                    {
                        MessageBox.Show("invalid time type");
                    }
                }
                else
                {
                    // if the minutes box value is greater than 0 and less than 60 add to value
                    if (int.Parse(minBox.Text) > 0 && int.Parse(minBox.Text) < 60)
                    {
                        cmdAddRecipe.Parameters.AddWithValue("@time", minBox.Text);

                        cmdAddRecipe.Parameters.AddWithValue("@timeType", "min");
                    }
                    // show error
                    else
                    {
                        MessageBox.Show("Invalid time type");
                    }
                }
                

                if (int.Parse(servingBox.Text) > 0)
                {
                    cmdAddRecipe.Parameters.AddWithValue("@serving", servingBox.Text);
                }
                else
                {
                    MessageBox.Show("Invalid Serving, Please try again");
                    servingBox.Text = "";
                }

                if (int.Parse(difficultyBox.Text) > 0)
                {
                    cmdAddRecipe.Parameters.AddWithValue("@difficulty", difficultyBox.Text);
                }
                else
                {
                    MessageBox.Show("Invalid Difficulty, Please try again"); //negative serving size
                    servingBox.Text = "";
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Invalid input please try again"); //user enters aring
            }


            //author
            if (!string.IsNullOrEmpty(authorBox.Text))
            {
                cmdAddRecipe.Parameters.AddWithValue("@author", authorBox.Text);
            }
            else { MessageBox.Show("Invalid Author. Please try again"); }

            cmdAddRecipe.Parameters.AddWithValue("@description", descriptionBox.Text);

            if (pictureBox1.Image == null)
            {
                string filePath = @"C:\Users\Quixy\Desktop\St Mary's\Files and Database\RecipeImages\Default.jpg";
                FileStream fs = new FileStream (filePath, FileMode.Open, FileAccess.Read);
                BinaryReader picReader = new BinaryReader(fs);
                byte[] arrayPic = picReader.ReadBytes((int)fs.Length);
                cmdAddRecipe.Parameters.AddWithValue("@Picture", arrayPic);

            }
            
            if (pictureBox1.Image != null)
            {
                string filePath = pictureBox1.Name;
                FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read);
                BinaryReader picReader = new BinaryReader(fs);
                byte[] arrayPic = picReader.ReadBytes((int)fs.Length);
                cmdAddRecipe.Parameters.AddWithValue("@Picture", arrayPic);
            }
            
            try
            {
                cmdAddRecipe.ExecuteNonQuery();
                MessageBox.Show("Recipe has been added.");
                stepsForm newForm = new stepsForm();
                newForm.CreateStepsConnection = CreateDBConnection;
                newForm.ShowDialog();
            }
            catch ( Exception ex)
            {
                //MessageBox.Show(ex.Message);

            }

           

        }
        private void sqlConnection1_InfoMessage(object sender, SqlInfoMessageEventArgs e)
        {

        }

        private void createForm_Load(object sender, EventArgs e)
        {
            difficultyBox.Text = "1";
        }

        private void DifficultyBar_Scroll(object sender, EventArgs e)
        {
            difficultyBox.Text = DifficultyBar.Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog filePath = new OpenFileDialog();
                filePath.InitialDirectory = @"C:\Users\Quixy\Desktop\St Mary's\Files and Database\RecipeImages";
                filePath.Filter = "Image Files| *.jpg";
                filePath.ShowDialog();
                pictureBox1.Image = Image.FromFile(filePath.FileName);
                pictureBox1.Name = filePath.FileName;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message + "\nPlease try again");
            }
        }

    }
}
