namespace RecipeInTraining
{
    partial class itemsForm
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
            this.RecipesFound = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.itemBtn = new System.Windows.Forms.Button();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.descriptionBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ItemDataTable = new System.Windows.Forms.DataGridView();
            this.SeeRecipeBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.RecipesFound)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemDataTable)).BeginInit();
            this.SuspendLayout();
            // 
            // RecipesFound
            // 
            this.RecipesFound.AllowUserToAddRows = false;
            this.RecipesFound.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.RecipesFound.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.RecipesFound.BackgroundColor = System.Drawing.Color.DarkSlateBlue;
            this.RecipesFound.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.RecipesFound.DefaultCellStyle = dataGridViewCellStyle1;
            this.RecipesFound.Location = new System.Drawing.Point(22, 52);
            this.RecipesFound.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.RecipesFound.Name = "RecipesFound";
            this.RecipesFound.RowHeadersVisible = false;
            this.RecipesFound.RowHeadersWidth = 102;
            this.RecipesFound.RowTemplate.Height = 49;
            this.RecipesFound.Size = new System.Drawing.Size(2018, 205);
            this.RecipesFound.TabIndex = 42;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 309);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 54);
            this.label1.TabIndex = 44;
            this.label1.Text = "Item Name:";
            // 
            // itemBtn
            // 
            this.itemBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemBtn.Location = new System.Drawing.Point(24, 629);
            this.itemBtn.Margin = new System.Windows.Forms.Padding(6);
            this.itemBtn.Name = "itemBtn";
            this.itemBtn.Size = new System.Drawing.Size(339, 138);
            this.itemBtn.TabIndex = 52;
            this.itemBtn.Text = "Enter Items";
            this.itemBtn.UseVisualStyleBackColor = true;
            this.itemBtn.Click += new System.EventHandler(this.itemBtn_Click);
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(304, 309);
            this.nameBox.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.nameBox.Multiline = true;
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(620, 54);
            this.nameBox.TabIndex = 53;
            // 
            // descriptionBox
            // 
            this.descriptionBox.Location = new System.Drawing.Point(24, 454);
            this.descriptionBox.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.descriptionBox.Multiline = true;
            this.descriptionBox.Name = "descriptionBox";
            this.descriptionBox.Size = new System.Drawing.Size(886, 124);
            this.descriptionBox.TabIndex = 54;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 386);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(374, 54);
            this.label2.TabIndex = 55;
            this.label2.Text = "Item Description:";
            // 
            // ItemDataTable
            // 
            this.ItemDataTable.AllowUserToAddRows = false;
            this.ItemDataTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ItemDataTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.ItemDataTable.BackgroundColor = System.Drawing.Color.DarkSlateBlue;
            this.ItemDataTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ItemDataTable.DefaultCellStyle = dataGridViewCellStyle2;
            this.ItemDataTable.Location = new System.Drawing.Point(1016, 304);
            this.ItemDataTable.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.ItemDataTable.Name = "ItemDataTable";
            this.ItemDataTable.RowHeadersVisible = false;
            this.ItemDataTable.RowHeadersWidth = 102;
            this.ItemDataTable.RowTemplate.Height = 49;
            this.ItemDataTable.Size = new System.Drawing.Size(1024, 521);
            this.ItemDataTable.TabIndex = 56;
            // 
            // SeeRecipeBtn
            // 
            this.SeeRecipeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SeeRecipeBtn.Location = new System.Drawing.Point(547, 629);
            this.SeeRecipeBtn.Name = "SeeRecipeBtn";
            this.SeeRecipeBtn.Size = new System.Drawing.Size(331, 138);
            this.SeeRecipeBtn.TabIndex = 57;
            this.SeeRecipeBtn.Text = "See Recipe";
            this.SeeRecipeBtn.UseVisualStyleBackColor = true;
            this.SeeRecipeBtn.Click += new System.EventHandler(this.SeeRecipeBtn_Click);
            // 
            // itemsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(2124, 872);
            this.Controls.Add(this.SeeRecipeBtn);
            this.Controls.Add(this.ItemDataTable);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.descriptionBox);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.itemBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RecipesFound);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "itemsForm";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Text = "ItemsForm";
            this.Load += new System.EventHandler(this.itemsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RecipesFound)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemDataTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView RecipesFound;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button itemBtn;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.TextBox descriptionBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView ItemDataTable;
        private System.Windows.Forms.Button SeeRecipeBtn;
    }
}