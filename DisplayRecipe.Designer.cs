using System.Windows.Forms;

namespace RecipeInTraining
{
    partial class DisplayRecipe
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
            this.NameOfRecipe = new System.Windows.Forms.Label();
            this.EditRecipeButton = new System.Windows.Forms.Button();
            this.DateLabel = new System.Windows.Forms.Label();
            this.dateDisplayedLabel = new System.Windows.Forms.Label();
            this.DisplayDiffLabel = new System.Windows.Forms.Label();
            this.DiffLabel = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.IngredientsLabel = new System.Windows.Forms.Label();
            this.NotesLabel = new System.Windows.Forms.Label();
            this.NotesDisplayField = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.CuisineLabel = new System.Windows.Forms.Label();
            this.DisplayCuisineLabel = new System.Windows.Forms.Label();
            this.TimeDisplayMinutesLabel = new System.Windows.Forms.Label();
            this.DisplayHourTimeLabel = new System.Windows.Forms.Label();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // NameOfRecipe
            // 
            this.NameOfRecipe.AutoSize = true;
            this.NameOfRecipe.Font = new System.Drawing.Font("Segoe UI Symbol", 14.1F, System.Drawing.FontStyle.Bold);
            this.NameOfRecipe.Location = new System.Drawing.Point(24, 18);
            this.NameOfRecipe.Name = "NameOfRecipe";
            this.NameOfRecipe.Size = new System.Drawing.Size(373, 62);
            this.NameOfRecipe.TabIndex = 0;
            this.NameOfRecipe.Text = "Name of Recipe";
            // 
            // EditRecipeButton
            // 
            this.EditRecipeButton.Location = new System.Drawing.Point(1398, 35);
            this.EditRecipeButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EditRecipeButton.Name = "EditRecipeButton";
            this.EditRecipeButton.Size = new System.Drawing.Size(122, 44);
            this.EditRecipeButton.TabIndex = 1;
            this.EditRecipeButton.Text = "Edit";
            this.EditRecipeButton.UseVisualStyleBackColor = true;
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.Location = new System.Drawing.Point(34, 96);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(82, 32);
            this.DateLabel.TabIndex = 2;
            this.DateLabel.Text = "Date:";
            // 
            // dateDisplayedLabel
            // 
            this.dateDisplayedLabel.AutoSize = true;
            this.dateDisplayedLabel.Location = new System.Drawing.Point(147, 96);
            this.dateDisplayedLabel.Name = "dateDisplayedLabel";
            this.dateDisplayedLabel.Size = new System.Drawing.Size(158, 32);
            this.dateDisplayedLabel.TabIndex = 3;
            this.dateDisplayedLabel.Text = "00/00/0000";
            // 
            // DisplayDiffLabel
            // 
            this.DisplayDiffLabel.AutoSize = true;
            this.DisplayDiffLabel.Location = new System.Drawing.Point(147, 145);
            this.DisplayDiffLabel.Name = "DisplayDiffLabel";
            this.DisplayDiffLabel.Size = new System.Drawing.Size(315, 32);
            this.DisplayDiffLabel.TabIndex = 5;
            this.DisplayDiffLabel.Text = "*Difficulty Not Selected*";
            // 
            // DiffLabel
            // 
            this.DiffLabel.AutoSize = true;
            this.DiffLabel.Location = new System.Drawing.Point(24, 145);
            this.DiffLabel.Name = "DiffLabel";
            this.DiffLabel.Size = new System.Drawing.Size(131, 32);
            this.DiffLabel.TabIndex = 4;
            this.DiffLabel.Text = "Difficulty:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 310);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 102;
            this.dataGridView1.RowTemplate.Height = 49;
            this.dataGridView1.Size = new System.Drawing.Size(818, 480);
            this.dataGridView1.TabIndex = 6;
            // 
            // IngredientsLabel
            // 
            this.IngredientsLabel.AutoSize = true;
            this.IngredientsLabel.Location = new System.Drawing.Point(12, 249);
            this.IngredientsLabel.Name = "IngredientsLabel";
            this.IngredientsLabel.Size = new System.Drawing.Size(163, 32);
            this.IngredientsLabel.TabIndex = 7;
            this.IngredientsLabel.Text = "Ingredients:";
            // 
            // NotesLabel
            // 
            this.NotesLabel.AutoSize = true;
            this.NotesLabel.Location = new System.Drawing.Point(24, 802);
            this.NotesLabel.Name = "NotesLabel";
            this.NotesLabel.Size = new System.Drawing.Size(96, 32);
            this.NotesLabel.TabIndex = 8;
            this.NotesLabel.Text = "Notes:";
            // 
            // NotesDisplayField
            // 
            this.NotesDisplayField.Location = new System.Drawing.Point(24, 857);
            this.NotesDisplayField.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NotesDisplayField.Multiline = true;
            this.NotesDisplayField.Name = "NotesDisplayField";
            this.NotesDisplayField.Size = new System.Drawing.Size(1485, 153);
            this.NotesDisplayField.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(860, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 32);
            this.label1.TabIndex = 10;
            this.label1.Text = "Description:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(866, 145);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(643, 110);
            this.textBox1.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(862, 413);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 32);
            this.label2.TabIndex = 12;
            this.label2.Text = "Appliances:";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(868, 456);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 102;
            this.dataGridView2.RowTemplate.Height = 49;
            this.dataGridView2.Size = new System.Drawing.Size(652, 334);
            this.dataGridView2.TabIndex = 13;
            // 
            // CuisineLabel
            // 
            this.CuisineLabel.AutoSize = true;
            this.CuisineLabel.Location = new System.Drawing.Point(856, 270);
            this.CuisineLabel.Name = "CuisineLabel";
            this.CuisineLabel.Size = new System.Drawing.Size(118, 32);
            this.CuisineLabel.TabIndex = 14;
            this.CuisineLabel.Text = "Cuisine:";
            // 
            // DisplayCuisineLabel
            // 
            this.DisplayCuisineLabel.AutoSize = true;
            this.DisplayCuisineLabel.Location = new System.Drawing.Point(980, 270);
            this.DisplayCuisineLabel.Name = "DisplayCuisineLabel";
            this.DisplayCuisineLabel.Size = new System.Drawing.Size(302, 32);
            this.DisplayCuisineLabel.TabIndex = 15;
            this.DisplayCuisineLabel.Text = "*Cuisine Not Selected*";
            // 
            // TimeDisplayMinutesLabel
            // 
            this.TimeDisplayMinutesLabel.AutoSize = true;
            this.TimeDisplayMinutesLabel.Location = new System.Drawing.Point(992, 320);
            this.TimeDisplayMinutesLabel.Name = "TimeDisplayMinutesLabel";
            this.TimeDisplayMinutesLabel.Size = new System.Drawing.Size(89, 32);
            this.TimeDisplayMinutesLabel.TabIndex = 16;
            this.TimeDisplayMinutesLabel.Text = "** Min";
            // 
            // DisplayHourTimeLabel
            // 
            this.DisplayHourTimeLabel.AutoSize = true;
            this.DisplayHourTimeLabel.Location = new System.Drawing.Point(1095, 320);
            this.DisplayHourTimeLabel.Name = "DisplayHourTimeLabel";
            this.DisplayHourTimeLabel.Size = new System.Drawing.Size(72, 32);
            this.DisplayHourTimeLabel.TabIndex = 17;
            this.DisplayHourTimeLabel.Text = "** Hr";
            // 
            // TimeLabel
            // 
            this.TimeLabel.AutoSize = true;
            this.TimeLabel.Location = new System.Drawing.Point(865, 320);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(85, 32);
            this.TimeLabel.TabIndex = 18;
            this.TimeLabel.Text = "Time:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(865, 364);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 32);
            this.label3.TabIndex = 19;
            this.label3.Text = "Servings: ";
            // 
            // DisplayRecipe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(1558, 1066);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TimeLabel);
            this.Controls.Add(this.DisplayHourTimeLabel);
            this.Controls.Add(this.TimeDisplayMinutesLabel);
            this.Controls.Add(this.DisplayCuisineLabel);
            this.Controls.Add(this.CuisineLabel);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NotesDisplayField);
            this.Controls.Add(this.NotesLabel);
            this.Controls.Add(this.IngredientsLabel);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.DisplayDiffLabel);
            this.Controls.Add(this.DiffLabel);
            this.Controls.Add(this.dateDisplayedLabel);
            this.Controls.Add(this.DateLabel);
            this.Controls.Add(this.EditRecipeButton);
            this.Controls.Add(this.NameOfRecipe);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "DisplayRecipe";
            this.Text = "RecipeDisplay";
            this.Load += new System.EventHandler(this.DisplayRecipe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label NameOfRecipe;
        private Button EditRecipeButton;
        private Label DateLabel;
        private Label dateDisplayedLabel;
        private Label DisplayDiffLabel;
        private Label DiffLabel;
        private DataGridView dataGridView1;
        private Label IngredientsLabel;
        private Label NotesLabel;
        private TextBox NotesDisplayField;
        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private DataGridView dataGridView2;
        private Label CuisineLabel;
        private Label DisplayCuisineLabel;
        private Label TimeDisplayMinutesLabel;
        private Label DisplayHourTimeLabel;
        private Label TimeLabel;
        private Label label3;
    }
}