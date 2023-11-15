using System.Windows.Forms;

namespace RecipeInTraining
{
    partial class createForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.enterRecipe = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.minBox = new System.Windows.Forms.TextBox();
            this.cuisineBox = new System.Windows.Forms.TextBox();
            this.hourBox = new System.Windows.Forms.TextBox();
            this.servingBox = new System.Windows.Forms.TextBox();
            this.authorBox = new System.Windows.Forms.TextBox();
            this.difficultyBox = new System.Windows.Forms.TextBox();
            this.descriptionBox = new System.Windows.Forms.TextBox();
            this.sqlConnection2 = new System.Data.SqlClient.SqlConnection();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.DifficultyBar = new System.Windows.Forms.TrackBar();
            this.button1 = new System.Windows.Forms.Button();
            this.recipeDatabaseDataSet1 = new RecipeInTraining.RecipeDatabaseDataSet();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DifficultyBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recipeDatabaseDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name of Recipe:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // enterRecipe
            // 
            this.enterRecipe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterRecipe.Location = new System.Drawing.Point(1160, 644);
            this.enterRecipe.Margin = new System.Windows.Forms.Padding(6);
            this.enterRecipe.Name = "enterRecipe";
            this.enterRecipe.Size = new System.Drawing.Size(852, 143);
            this.enterRecipe.TabIndex = 36;
            this.enterRecipe.Text = "Enter Recipe";
            this.enterRecipe.UseVisualStyleBackColor = true;
            this.enterRecipe.Click += new System.EventHandler(this.enterRecipe_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(35, 392);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 39);
            this.label4.TabIndex = 38;
            this.label4.Text = "Author:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(35, 95);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(149, 39);
            this.label8.TabIndex = 39;
            this.label8.Text = "Cuisine:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(35, 167);
            this.label9.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(183, 39);
            this.label9.TabIndex = 40;
            this.label9.Text = "Minutes #:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 244);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 39);
            this.label2.TabIndex = 41;
            this.label2.Text = "Hours #:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(35, 316);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(168, 39);
            this.label5.TabIndex = 42;
            this.label5.Text = "Servings:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(35, 473);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(166, 39);
            this.label6.TabIndex = 43;
            this.label6.Text = "Difficulty:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 590);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(209, 39);
            this.label3.TabIndex = 44;
            this.label3.Text = "Description:";
            // 
            // minBox
            // 
            this.minBox.Location = new System.Drawing.Point(370, 167);
            this.minBox.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.minBox.Multiline = true;
            this.minBox.Name = "minBox";
            this.minBox.Size = new System.Drawing.Size(470, 39);
            this.minBox.TabIndex = 45;
            // 
            // cuisineBox
            // 
            this.cuisineBox.Location = new System.Drawing.Point(370, 95);
            this.cuisineBox.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.cuisineBox.Multiline = true;
            this.cuisineBox.Name = "cuisineBox";
            this.cuisineBox.Size = new System.Drawing.Size(470, 39);
            this.cuisineBox.TabIndex = 46;
            // 
            // hourBox
            // 
            this.hourBox.Location = new System.Drawing.Point(370, 244);
            this.hourBox.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.hourBox.Multiline = true;
            this.hourBox.Name = "hourBox";
            this.hourBox.Size = new System.Drawing.Size(470, 39);
            this.hourBox.TabIndex = 47;
            // 
            // servingBox
            // 
            this.servingBox.Location = new System.Drawing.Point(370, 316);
            this.servingBox.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.servingBox.Multiline = true;
            this.servingBox.Name = "servingBox";
            this.servingBox.Size = new System.Drawing.Size(470, 39);
            this.servingBox.TabIndex = 48;
            // 
            // authorBox
            // 
            this.authorBox.Location = new System.Drawing.Point(370, 392);
            this.authorBox.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.authorBox.Multiline = true;
            this.authorBox.Name = "authorBox";
            this.authorBox.Size = new System.Drawing.Size(470, 39);
            this.authorBox.TabIndex = 49;
            // 
            // difficultyBox
            // 
            this.difficultyBox.Location = new System.Drawing.Point(861, 475);
            this.difficultyBox.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.difficultyBox.Multiline = true;
            this.difficultyBox.Name = "difficultyBox";
            this.difficultyBox.ReadOnly = true;
            this.difficultyBox.Size = new System.Drawing.Size(68, 51);
            this.difficultyBox.TabIndex = 50;
            // 
            // descriptionBox
            // 
            this.descriptionBox.Location = new System.Drawing.Point(34, 644);
            this.descriptionBox.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.descriptionBox.Multiline = true;
            this.descriptionBox.Name = "descriptionBox";
            this.descriptionBox.Size = new System.Drawing.Size(1002, 153);
            this.descriptionBox.TabIndex = 51;
            // 
            // sqlConnection2
            // 
            this.sqlConnection2.ConnectionString = "Data Source=ARIESPC;Initial Catalog=RecipeDatabase;Integrated Security=True";
            this.sqlConnection2.FireInfoMessageEventOnUserErrors = false;
            this.sqlConnection2.InfoMessage += new System.Data.SqlClient.SqlInfoMessageEventHandler(this.sqlConnection1_InfoMessage);
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(370, 28);
            this.nameBox.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.nameBox.Multiline = true;
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(470, 39);
            this.nameBox.TabIndex = 12;
            // 
            // DifficultyBar
            // 
            this.DifficultyBar.Location = new System.Drawing.Point(370, 468);
            this.DifficultyBar.Minimum = 1;
            this.DifficultyBar.Name = "DifficultyBar";
            this.DifficultyBar.Size = new System.Drawing.Size(470, 114);
            this.DifficultyBar.TabIndex = 52;
            this.DifficultyBar.Value = 1;
            this.DifficultyBar.Scroll += new System.EventHandler(this.DifficultyBar_Scroll);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(965, 40);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(179, 89);
            this.button1.TabIndex = 53;
            this.button1.Text = "Get Image";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // recipeDatabaseDataSet1
            // 
            this.recipeDatabaseDataSet1.DataSetName = "RecipeDatabaseDataSet";
            this.recipeDatabaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(1182, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(809, 522);
            this.pictureBox1.TabIndex = 54;
            this.pictureBox1.TabStop = false;
            // 
            // createForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(2264, 1212);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DifficultyBar);
            this.Controls.Add(this.descriptionBox);
            this.Controls.Add(this.difficultyBox);
            this.Controls.Add(this.authorBox);
            this.Controls.Add(this.servingBox);
            this.Controls.Add(this.hourBox);
            this.Controls.Add(this.cuisineBox);
            this.Controls.Add(this.minBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.enterRecipe);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "createForm";
            this.Padding = new System.Windows.Forms.Padding(5, 5, 20, 5);
            this.Text = "createForm";
            this.Load += new System.EventHandler(this.createForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DifficultyBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recipeDatabaseDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Button enterRecipe;
        private Label label4;
        private Label label8;
        private Label label9;
        private Label label2;
        private Label label5;
        private Label label6;
        private Label label3;
        private TextBox minBox;
        private TextBox cuisineBox;
        private TextBox hourBox;
        private TextBox servingBox;
        private TextBox authorBox;
        private TextBox difficultyBox;
        private TextBox descriptionBox;
        private System.Data.SqlClient.SqlConnection sqlConnection2;
        private TextBox nameBox;
        private TrackBar DifficultyBar;
        private Button button1;
        private RecipeDatabaseDataSet recipeDatabaseDataSet1;
        private PictureBox pictureBox1;
    }
}