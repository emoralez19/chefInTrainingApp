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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.NameOfRecipe = new System.Windows.Forms.Label();
            this.DisplayDiffLabel = new System.Windows.Forms.Label();
            this.DiffLabel = new System.Windows.Forms.Label();
            this.StepsDataGrid = new System.Windows.Forms.DataGridView();
            this.IngredientsLabel = new System.Windows.Forms.Label();
            this.NotesLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DescriptionText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.IngredientsDataGrid = new System.Windows.Forms.DataGridView();
            this.CuisineLabel = new System.Windows.Forms.Label();
            this.DisplayCuisineLabel = new System.Windows.Forms.Label();
            this.TimeDisplayMinutesLabel = new System.Windows.Forms.Label();
            this.DisplayHourTimeLabel = new System.Windows.Forms.Label();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.AppDataGrid = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.AuthorName = new System.Windows.Forms.Label();
            this.ServingAmt = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.DeleteBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.StepsDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IngredientsDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AppDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // NameOfRecipe
            // 
            this.NameOfRecipe.AutoSize = true;
            this.NameOfRecipe.Font = new System.Drawing.Font("Verdana", 15.9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameOfRecipe.Location = new System.Drawing.Point(19, 17);
            this.NameOfRecipe.Name = "NameOfRecipe";
            this.NameOfRecipe.Size = new System.Drawing.Size(490, 65);
            this.NameOfRecipe.TabIndex = 0;
            this.NameOfRecipe.Text = "Name of Recipe";
            // 
            // DisplayDiffLabel
            // 
            this.DisplayDiffLabel.AutoSize = true;
            this.DisplayDiffLabel.Location = new System.Drawing.Point(1525, 347);
            this.DisplayDiffLabel.Name = "DisplayDiffLabel";
            this.DisplayDiffLabel.Size = new System.Drawing.Size(199, 32);
            this.DisplayDiffLabel.TabIndex = 5;
            this.DisplayDiffLabel.Text = "*Not Selected*";
            // 
            // DiffLabel
            // 
            this.DiffLabel.AutoSize = true;
            this.DiffLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DiffLabel.Location = new System.Drawing.Point(1329, 342);
            this.DiffLabel.Name = "DiffLabel";
            this.DiffLabel.Size = new System.Drawing.Size(166, 39);
            this.DiffLabel.TabIndex = 4;
            this.DiffLabel.Text = "Difficulty:";
            // 
            // StepsDataGrid
            // 
            this.StepsDataGrid.AllowUserToAddRows = false;
            this.StepsDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.StepsDataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.StepsDataGrid.BackgroundColor = System.Drawing.Color.LightSalmon;
            this.StepsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.StepsDataGrid.DefaultCellStyle = dataGridViewCellStyle1;
            this.StepsDataGrid.Location = new System.Drawing.Point(30, 699);
            this.StepsDataGrid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.StepsDataGrid.Name = "StepsDataGrid";
            this.StepsDataGrid.RowHeadersVisible = false;
            this.StepsDataGrid.RowHeadersWidth = 102;
            this.StepsDataGrid.RowTemplate.Height = 49;
            this.StepsDataGrid.Size = new System.Drawing.Size(818, 671);
            this.StepsDataGrid.TabIndex = 6;
            // 
            // IngredientsLabel
            // 
            this.IngredientsLabel.AutoSize = true;
            this.IngredientsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IngredientsLabel.Location = new System.Drawing.Point(23, 638);
            this.IngredientsLabel.Name = "IngredientsLabel";
            this.IngredientsLabel.Size = new System.Drawing.Size(119, 39);
            this.IngredientsLabel.TabIndex = 7;
            this.IngredientsLabel.Text = "Steps:";
            // 
            // NotesLabel
            // 
            this.NotesLabel.AutoSize = true;
            this.NotesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NotesLabel.Location = new System.Drawing.Point(893, 279);
            this.NotesLabel.Name = "NotesLabel";
            this.NotesLabel.Size = new System.Drawing.Size(133, 39);
            this.NotesLabel.TabIndex = 8;
            this.NotesLabel.Text = "Author:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(895, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 39);
            this.label1.TabIndex = 10;
            this.label1.Text = "Description:";
            // 
            // DescriptionText
            // 
            this.DescriptionText.Location = new System.Drawing.Point(890, 160);
            this.DescriptionText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DescriptionText.Multiline = true;
            this.DescriptionText.Name = "DescriptionText";
            this.DescriptionText.Size = new System.Drawing.Size(818, 87);
            this.DescriptionText.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(869, 533);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(207, 39);
            this.label2.TabIndex = 12;
            this.label2.Text = "Ingredients:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // IngredientsDataGrid
            // 
            this.IngredientsDataGrid.AllowUserToAddRows = false;
            this.IngredientsDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.IngredientsDataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.IngredientsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.IngredientsDataGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.IngredientsDataGrid.Location = new System.Drawing.Point(876, 593);
            this.IngredientsDataGrid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.IngredientsDataGrid.Name = "IngredientsDataGrid";
            this.IngredientsDataGrid.RowHeadersVisible = false;
            this.IngredientsDataGrid.RowHeadersWidth = 102;
            this.IngredientsDataGrid.RowTemplate.Height = 49;
            this.IngredientsDataGrid.Size = new System.Drawing.Size(841, 478);
            this.IngredientsDataGrid.TabIndex = 13;
            this.IngredientsDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.IngredientsDataGrid_CellContentClick);
            // 
            // CuisineLabel
            // 
            this.CuisineLabel.AutoSize = true;
            this.CuisineLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CuisineLabel.Location = new System.Drawing.Point(890, 342);
            this.CuisineLabel.Name = "CuisineLabel";
            this.CuisineLabel.Size = new System.Drawing.Size(149, 39);
            this.CuisineLabel.TabIndex = 14;
            this.CuisineLabel.Text = "Cuisine:";
            // 
            // DisplayCuisineLabel
            // 
            this.DisplayCuisineLabel.AutoSize = true;
            this.DisplayCuisineLabel.Location = new System.Drawing.Point(1045, 347);
            this.DisplayCuisineLabel.Name = "DisplayCuisineLabel";
            this.DisplayCuisineLabel.Size = new System.Drawing.Size(199, 32);
            this.DisplayCuisineLabel.TabIndex = 15;
            this.DisplayCuisineLabel.Text = "*Not Selected*";
            // 
            // TimeDisplayMinutesLabel
            // 
            this.TimeDisplayMinutesLabel.AutoSize = true;
            this.TimeDisplayMinutesLabel.Location = new System.Drawing.Point(1216, 405);
            this.TimeDisplayMinutesLabel.Name = "TimeDisplayMinutesLabel";
            this.TimeDisplayMinutesLabel.Size = new System.Drawing.Size(43, 32);
            this.TimeDisplayMinutesLabel.TabIndex = 16;
            this.TimeDisplayMinutesLabel.Text = "** ";
            // 
            // DisplayHourTimeLabel
            // 
            this.DisplayHourTimeLabel.AutoSize = true;
            this.DisplayHourTimeLabel.Location = new System.Drawing.Point(1051, 407);
            this.DisplayHourTimeLabel.Name = "DisplayHourTimeLabel";
            this.DisplayHourTimeLabel.Size = new System.Drawing.Size(36, 32);
            this.DisplayHourTimeLabel.TabIndex = 17;
            this.DisplayHourTimeLabel.Text = "**";
            // 
            // TimeLabel
            // 
            this.TimeLabel.AutoSize = true;
            this.TimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeLabel.Location = new System.Drawing.Point(893, 400);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(107, 39);
            this.TimeLabel.TabIndex = 18;
            this.TimeLabel.Text = "Time:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1329, 279);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 39);
            this.label3.TabIndex = 19;
            this.label3.Text = "Servings: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1082, 405);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 32);
            this.label4.TabIndex = 20;
            this.label4.Text = " Hour(s)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1265, 405);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 32);
            this.label5.TabIndex = 21;
            this.label5.Text = "Minute(s)";
            // 
            // AppDataGrid
            // 
            this.AppDataGrid.AllowUserToAddRows = false;
            this.AppDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.AppDataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.AppDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.AppDataGrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.AppDataGrid.Location = new System.Drawing.Point(876, 1148);
            this.AppDataGrid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AppDataGrid.Name = "AppDataGrid";
            this.AppDataGrid.RowHeadersVisible = false;
            this.AppDataGrid.RowHeadersWidth = 102;
            this.AppDataGrid.RowTemplate.Height = 49;
            this.AppDataGrid.Size = new System.Drawing.Size(847, 222);
            this.AppDataGrid.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(883, 1086);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(205, 39);
            this.label6.TabIndex = 22;
            this.label6.Text = "Appliances:";
            // 
            // AuthorName
            // 
            this.AuthorName.AutoSize = true;
            this.AuthorName.Location = new System.Drawing.Point(1045, 284);
            this.AuthorName.Name = "AuthorName";
            this.AuthorName.Size = new System.Drawing.Size(199, 32);
            this.AuthorName.TabIndex = 24;
            this.AuthorName.Text = "*Not Selected*";
            // 
            // ServingAmt
            // 
            this.ServingAmt.AutoSize = true;
            this.ServingAmt.Location = new System.Drawing.Point(1525, 284);
            this.ServingAmt.Name = "ServingAmt";
            this.ServingAmt.Size = new System.Drawing.Size(199, 32);
            this.ServingAmt.TabIndex = 25;
            this.ServingAmt.Text = "*Not Selected*";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(30, 85);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(819, 550);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Location = new System.Drawing.Point(1515, 28);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(209, 65);
            this.DeleteBtn.TabIndex = 27;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // DisplayRecipe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(1761, 1403);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ServingAmt);
            this.Controls.Add(this.AuthorName);
            this.Controls.Add(this.AppDataGrid);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TimeLabel);
            this.Controls.Add(this.DisplayHourTimeLabel);
            this.Controls.Add(this.TimeDisplayMinutesLabel);
            this.Controls.Add(this.DisplayCuisineLabel);
            this.Controls.Add(this.CuisineLabel);
            this.Controls.Add(this.IngredientsDataGrid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DescriptionText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NotesLabel);
            this.Controls.Add(this.IngredientsLabel);
            this.Controls.Add(this.StepsDataGrid);
            this.Controls.Add(this.DisplayDiffLabel);
            this.Controls.Add(this.DiffLabel);
            this.Controls.Add(this.NameOfRecipe);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "DisplayRecipe";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Text = "RecipeDisplay";
            this.Load += new System.EventHandler(this.DisplayRecipe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.StepsDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IngredientsDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AppDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label NameOfRecipe;
        private Label DisplayDiffLabel;
        private Label DiffLabel;
        private DataGridView StepsDataGrid;
        private Label IngredientsLabel;
        private Label NotesLabel;
        private Label label1;
        private TextBox DescriptionText;
        private Label label2;
        private DataGridView IngredientsDataGrid;
        private Label CuisineLabel;
        private Label DisplayCuisineLabel;
        private Label TimeDisplayMinutesLabel;
        private Label DisplayHourTimeLabel;
        private Label TimeLabel;
        private Label label3;
        private Label label4;
        private Label label5;
        private DataGridView AppDataGrid;
        private Label label6;
        private Label AuthorName;
        private Label ServingAmt;
        private PictureBox pictureBox1;
        private Button DeleteBtn;
    }
}