namespace RecipeInTraining
{
    partial class stepsForm
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
            this.sqlConnection3 = new System.Data.SqlClient.SqlConnection();
            this.label1 = new System.Windows.Forms.Label();
            this.RecipesFound = new System.Windows.Forms.DataGridView();
            this.enterBtn = new System.Windows.Forms.Button();
            this.stepBox = new System.Windows.Forms.TextBox();
            this.ingredienetsBtn = new System.Windows.Forms.Button();
            this.StepsDataTable = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.RecipesFound)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StepsDataTable)).BeginInit();
            this.SuspendLayout();
            // 
            // sqlConnection3
            // 
            this.sqlConnection3.ConnectionString = "Data Source=ARIESPC;Initial Catalog=RecipeDatabase;Integrated Security=True";
            this.sqlConnection3.FireInfoMessageEventOnUserErrors = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(30, 233);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 76);
            this.label1.TabIndex = 1;
            this.label1.Text = "Step:";
            // 
            // RecipesFound
            // 
            this.RecipesFound.AllowUserToAddRows = false;
            this.RecipesFound.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.RecipesFound.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.RecipesFound.BackgroundColor = System.Drawing.Color.DarkSlateGray;
            this.RecipesFound.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.RecipesFound.DefaultCellStyle = dataGridViewCellStyle1;
            this.RecipesFound.Location = new System.Drawing.Point(50, 19);
            this.RecipesFound.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.RecipesFound.Name = "RecipesFound";
            this.RecipesFound.RowHeadersVisible = false;
            this.RecipesFound.RowHeadersWidth = 102;
            this.RecipesFound.RowTemplate.Height = 49;
            this.RecipesFound.Size = new System.Drawing.Size(1927, 153);
            this.RecipesFound.TabIndex = 40;
            this.RecipesFound.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.RecipesFound_CellContentClick);
            // 
            // enterBtn
            // 
            this.enterBtn.Location = new System.Drawing.Point(38, 366);
            this.enterBtn.Margin = new System.Windows.Forms.Padding(6);
            this.enterBtn.Name = "enterBtn";
            this.enterBtn.Size = new System.Drawing.Size(390, 122);
            this.enterBtn.TabIndex = 41;
            this.enterBtn.Text = "Enter Step";
            this.enterBtn.UseVisualStyleBackColor = true;
            this.enterBtn.Click += new System.EventHandler(this.enterBtn_Click);
            // 
            // stepBox
            // 
            this.stepBox.Location = new System.Drawing.Point(229, 236);
            this.stepBox.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.stepBox.Multiline = true;
            this.stepBox.Name = "stepBox";
            this.stepBox.Size = new System.Drawing.Size(849, 73);
            this.stepBox.TabIndex = 42;
            // 
            // ingredienetsBtn
            // 
            this.ingredienetsBtn.Location = new System.Drawing.Point(612, 366);
            this.ingredienetsBtn.Margin = new System.Windows.Forms.Padding(6);
            this.ingredienetsBtn.Name = "ingredienetsBtn";
            this.ingredienetsBtn.Size = new System.Drawing.Size(466, 122);
            this.ingredienetsBtn.TabIndex = 44;
            this.ingredienetsBtn.Text = "Go to Ingredients";
            this.ingredienetsBtn.UseVisualStyleBackColor = true;
            this.ingredienetsBtn.Click += new System.EventHandler(this.ingredientsBtn_Click);
            // 
            // StepsDataTable
            // 
            this.StepsDataTable.AllowUserToAddRows = false;
            this.StepsDataTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.StepsDataTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.StepsDataTable.BackgroundColor = System.Drawing.Color.DarkSlateGray;
            this.StepsDataTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.StepsDataTable.DefaultCellStyle = dataGridViewCellStyle2;
            this.StepsDataTable.Location = new System.Drawing.Point(1123, 231);
            this.StepsDataTable.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.StepsDataTable.Name = "StepsDataTable";
            this.StepsDataTable.RowHeadersVisible = false;
            this.StepsDataTable.RowHeadersWidth = 102;
            this.StepsDataTable.RowTemplate.Height = 49;
            this.StepsDataTable.Size = new System.Drawing.Size(854, 669);
            this.StepsDataTable.TabIndex = 45;
            this.StepsDataTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.StepsDataTable_CellContentClick);
            // 
            // stepsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(2036, 1014);
            this.Controls.Add(this.StepsDataTable);
            this.Controls.Add(this.ingredienetsBtn);
            this.Controls.Add(this.stepBox);
            this.Controls.Add(this.enterBtn);
            this.Controls.Add(this.RecipesFound);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "stepsForm";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Text = "steps Form";
            this.Load += new System.EventHandler(this.stepsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RecipesFound)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StepsDataTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Data.SqlClient.SqlConnection sqlConnection3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView RecipesFound;
        private System.Windows.Forms.Button enterBtn;
        private System.Windows.Forms.TextBox stepBox;
        private System.Windows.Forms.Button ingredienetsBtn;
        private System.Windows.Forms.DataGridView StepsDataTable;
    }
}