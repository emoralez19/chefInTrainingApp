using System.Windows.Forms;

namespace RecipeInTraining
{
    partial class searchForm : Form
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NameSearchBar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.IngredientsSearchBar = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CuisineComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ServingSizeCombo = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.CookTimeCombo = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.CourseComboBox = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.RecipesFound = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.RecipesFound)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 14.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(314, 62);
            this.label1.TabIndex = 0;
            this.label1.Text = "Recipe Finder";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 39);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name: ";
            // 
            // NameSearchBar
            // 
            this.NameSearchBar.Location = new System.Drawing.Point(310, 69);
            this.NameSearchBar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NameSearchBar.Name = "NameSearchBar";
            this.NameSearchBar.Size = new System.Drawing.Size(284, 38);
            this.NameSearchBar.TabIndex = 2;
            this.NameSearchBar.TextChanged += new System.EventHandler(this.NameSearchBar_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(657, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 39);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ingredient:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // IngredientsSearchBar
            // 
            this.IngredientsSearchBar.Location = new System.Drawing.Point(901, 76);
            this.IngredientsSearchBar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.IngredientsSearchBar.Name = "IngredientsSearchBar";
            this.IngredientsSearchBar.Size = new System.Drawing.Size(248, 38);
            this.IngredientsSearchBar.TabIndex = 4;
            this.IngredientsSearchBar.TextChanged += new System.EventHandler(this.IngredientsSearchBar_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(263, 39);
            this.label4.TabIndex = 5;
            this.label4.Text = "Type of Cuisine:";
            // 
            // CuisineComboBox
            // 
            this.CuisineComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CuisineComboBox.FormattingEnabled = true;
            this.CuisineComboBox.Location = new System.Drawing.Point(310, 144);
            this.CuisineComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CuisineComboBox.Name = "CuisineComboBox";
            this.CuisineComboBox.Size = new System.Drawing.Size(284, 39);
            this.CuisineComboBox.TabIndex = 6;
            this.CuisineComboBox.SelectedIndexChanged += new System.EventHandler(this.CuisineComboBox_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(657, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(218, 39);
            this.label5.TabIndex = 7;
            this.label5.Text = "Serving Size:";
            // 
            // ServingSizeCombo
            // 
            this.ServingSizeCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ServingSizeCombo.FormattingEnabled = true;
            this.ServingSizeCombo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ServingSizeCombo.Location = new System.Drawing.Point(901, 144);
            this.ServingSizeCombo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ServingSizeCombo.Name = "ServingSizeCombo";
            this.ServingSizeCombo.Size = new System.Drawing.Size(248, 39);
            this.ServingSizeCombo.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(8, 210);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(188, 39);
            this.label6.TabIndex = 9;
            this.label6.Text = "Cook time: ";
            // 
            // CookTimeCombo
            // 
            this.CookTimeCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CookTimeCombo.FormattingEnabled = true;
            this.CookTimeCombo.Location = new System.Drawing.Point(305, 212);
            this.CookTimeCombo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CookTimeCombo.Name = "CookTimeCombo";
            this.CookTimeCombo.Size = new System.Drawing.Size(289, 39);
            this.CookTimeCombo.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(657, 216);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(155, 39);
            this.label7.TabIndex = 11;
            this.label7.Text = "Difficulty:";
            // 
            // CourseComboBox
            // 
            this.CourseComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CourseComboBox.FormattingEnabled = true;
            this.CourseComboBox.Location = new System.Drawing.Point(901, 215);
            this.CourseComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CourseComboBox.Name = "CourseComboBox";
            this.CourseComboBox.Size = new System.Drawing.Size(248, 39);
            this.CourseComboBox.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1230, 74);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(328, 175);
            this.button1.TabIndex = 13;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // RecipesFound
            // 
            this.RecipesFound.AllowUserToAddRows = false;
            this.RecipesFound.AllowUserToDeleteRows = false;
            this.RecipesFound.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.RecipesFound.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.RecipesFound.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.RecipesFound.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.RecipesFound.DefaultCellStyle = dataGridViewCellStyle3;
            this.RecipesFound.Location = new System.Drawing.Point(8, 286);
            this.RecipesFound.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RecipesFound.Name = "RecipesFound";
            this.RecipesFound.RowHeadersVisible = false;
            this.RecipesFound.RowHeadersWidth = 102;
            this.RecipesFound.RowTemplate.Height = 49;
            this.RecipesFound.Size = new System.Drawing.Size(1602, 911);
            this.RecipesFound.TabIndex = 14;
            this.RecipesFound.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.RecipesFound_CellContentClick);
            // 
            // searchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1618, 1204);
            this.Controls.Add(this.RecipesFound);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CourseComboBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.CookTimeCombo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ServingSizeCombo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CuisineComboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.IngredientsSearchBar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NameSearchBar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "searchForm";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Text = "Recipe Finder";
            this.Load += new System.EventHandler(this.searchForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RecipesFound)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox NameSearchBar;
        private Label label3;
        private TextBox IngredientsSearchBar;
        private Label label4;
        private ComboBox CuisineComboBox;
        private Label label5;
        private ComboBox ServingSizeCombo;
        private Label label6;
        private ComboBox CookTimeCombo;
        private Label label7;
        private ComboBox CourseComboBox;
        private Button button1;
        private DataGridView RecipesFound;
    }
}