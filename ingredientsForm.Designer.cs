namespace RecipeInTraining
{
    partial class ingredientsForm
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
            this.sqlConnection4 = new System.Data.SqlClient.SqlConnection();
            this.RecipesFound = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.ingredientBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ingAmtBox = new System.Windows.Forms.TextBox();
            this.amtTypeBox = new System.Windows.Forms.TextBox();
            this.ingredientBtn = new System.Windows.Forms.Button();
            this.itemsBtn = new System.Windows.Forms.Button();
            this.IngredientsDataTable = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.RecipesFound)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IngredientsDataTable)).BeginInit();
            this.SuspendLayout();
            // 
            // sqlConnection4
            // 
            this.sqlConnection4.ConnectionString = "Data Source=ARIESPC;Initial Catalog=RecipeDatabase;Integrated Security=True";
            this.sqlConnection4.FireInfoMessageEventOnUserErrors = false;
            // 
            // RecipesFound
            // 
            this.RecipesFound.AllowUserToAddRows = false;
            this.RecipesFound.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.RecipesFound.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.RecipesFound.BackgroundColor = System.Drawing.Color.Maroon;
            this.RecipesFound.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.RecipesFound.DefaultCellStyle = dataGridViewCellStyle1;
            this.RecipesFound.Location = new System.Drawing.Point(22, 46);
            this.RecipesFound.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.RecipesFound.Name = "RecipesFound";
            this.RecipesFound.RowHeadersVisible = false;
            this.RecipesFound.RowHeadersWidth = 102;
            this.RecipesFound.RowTemplate.Height = 49;
            this.RecipesFound.Size = new System.Drawing.Size(2000, 205);
            this.RecipesFound.TabIndex = 41;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 346);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 54);
            this.label1.TabIndex = 43;
            this.label1.Text = "Ingredient:";
            // 
            // ingredientBox
            // 
            this.ingredientBox.Location = new System.Drawing.Point(306, 346);
            this.ingredientBox.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.ingredientBox.Multiline = true;
            this.ingredientBox.Name = "ingredientBox";
            this.ingredientBox.Size = new System.Drawing.Size(765, 54);
            this.ingredientBox.TabIndex = 44;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 469);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(417, 54);
            this.label2.TabIndex = 45;
            this.label2.Text = "Ingredient Amount:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 599);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(314, 54);
            this.label3.TabIndex = 46;
            this.label3.Text = "Amount Type:";
            // 
            // ingAmtBox
            // 
            this.ingAmtBox.Location = new System.Drawing.Point(461, 469);
            this.ingAmtBox.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.ingAmtBox.Multiline = true;
            this.ingAmtBox.Name = "ingAmtBox";
            this.ingAmtBox.Size = new System.Drawing.Size(610, 58);
            this.ingAmtBox.TabIndex = 47;
            // 
            // amtTypeBox
            // 
            this.amtTypeBox.Location = new System.Drawing.Point(359, 599);
            this.amtTypeBox.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.amtTypeBox.Multiline = true;
            this.amtTypeBox.Name = "amtTypeBox";
            this.amtTypeBox.Size = new System.Drawing.Size(712, 54);
            this.amtTypeBox.TabIndex = 48;
            // 
            // ingredientBtn
            // 
            this.ingredientBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ingredientBtn.Location = new System.Drawing.Point(23, 735);
            this.ingredientBtn.Margin = new System.Windows.Forms.Padding(6);
            this.ingredientBtn.Name = "ingredientBtn";
            this.ingredientBtn.Size = new System.Drawing.Size(387, 138);
            this.ingredientBtn.TabIndex = 49;
            this.ingredientBtn.Text = "Enter Ingredients";
            this.ingredientBtn.UseVisualStyleBackColor = true;
            this.ingredientBtn.Click += new System.EventHandler(this.ingredientBtn_Click);
            // 
            // itemsBtn
            // 
            this.itemsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemsBtn.Location = new System.Drawing.Point(609, 735);
            this.itemsBtn.Margin = new System.Windows.Forms.Padding(6);
            this.itemsBtn.Name = "itemsBtn";
            this.itemsBtn.Size = new System.Drawing.Size(441, 138);
            this.itemsBtn.TabIndex = 52;
            this.itemsBtn.Text = "Go to Items";
            this.itemsBtn.UseVisualStyleBackColor = true;
            this.itemsBtn.Click += new System.EventHandler(this.itemsBtn_Click);
            // 
            // IngredientsDataTable
            // 
            this.IngredientsDataTable.AllowUserToAddRows = false;
            this.IngredientsDataTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.IngredientsDataTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.IngredientsDataTable.BackgroundColor = System.Drawing.Color.Maroon;
            this.IngredientsDataTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.IngredientsDataTable.DefaultCellStyle = dataGridViewCellStyle2;
            this.IngredientsDataTable.Location = new System.Drawing.Point(1125, 346);
            this.IngredientsDataTable.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.IngredientsDataTable.Name = "IngredientsDataTable";
            this.IngredientsDataTable.RowHeadersVisible = false;
            this.IngredientsDataTable.RowHeadersWidth = 102;
            this.IngredientsDataTable.RowTemplate.Height = 49;
            this.IngredientsDataTable.Size = new System.Drawing.Size(897, 640);
            this.IngredientsDataTable.TabIndex = 53;
            // 
            // ingredientsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(2066, 1031);
            this.Controls.Add(this.IngredientsDataTable);
            this.Controls.Add(this.itemsBtn);
            this.Controls.Add(this.ingredientBtn);
            this.Controls.Add(this.amtTypeBox);
            this.Controls.Add(this.ingAmtBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ingredientBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RecipesFound);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "ingredientsForm";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Text = "ingredientsForm";
            this.Load += new System.EventHandler(this.ingredientsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RecipesFound)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IngredientsDataTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Data.SqlClient.SqlConnection sqlConnection4;
        private System.Windows.Forms.DataGridView RecipesFound;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ingredientBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ingAmtBox;
        private System.Windows.Forms.TextBox amtTypeBox;
        private System.Windows.Forms.Button ingredientBtn;
        private System.Windows.Forms.Button itemsBtn;
        private System.Windows.Forms.DataGridView IngredientsDataTable;
    }
}