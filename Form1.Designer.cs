namespace DoToListAppWindowsForms
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgv_Categories = new DataGridView();
            dgv_Tasks = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            btn_addcategory = new Button();
            btn_refresh = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_Categories).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv_Tasks).BeginInit();
            SuspendLayout();
            // 
            // dgv_Categories
            // 
            dgv_Categories.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_Categories.BackgroundColor = SystemColors.ActiveBorder;
            dgv_Categories.BorderStyle = BorderStyle.Fixed3D;
            dgv_Categories.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgv_Categories.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Categories.ColumnHeadersVisible = false;
            dgv_Categories.GridColor = SystemColors.ActiveBorder;
            dgv_Categories.Location = new Point(32, 143);
            dgv_Categories.Name = "dgv_Categories";
            dgv_Categories.RowHeadersVisible = false;
            dgv_Categories.RowTemplate.DefaultCellStyle.BackColor = SystemColors.ActiveBorder;
            dgv_Categories.RowTemplate.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dgv_Categories.Size = new Size(196, 490);
            dgv_Categories.TabIndex = 0;
            dgv_Categories.CellClick += dgv_Categories_CellClick;
            // 
            // dgv_Tasks
            // 
            dgv_Tasks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_Tasks.BackgroundColor = SystemColors.ActiveBorder;
            dgv_Tasks.BorderStyle = BorderStyle.Fixed3D;
            dgv_Tasks.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgv_Tasks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Tasks.ColumnHeadersVisible = false;
            dgv_Tasks.GridColor = SystemColors.ActiveBorder;
            dgv_Tasks.Location = new Point(302, 143);
            dgv_Tasks.Name = "dgv_Tasks";
            dgv_Tasks.RowHeadersVisible = false;
            dgv_Tasks.RowTemplate.DefaultCellStyle.BackColor = SystemColors.ActiveBorder;
            dgv_Tasks.RowTemplate.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dgv_Tasks.Size = new Size(604, 490);
            dgv_Tasks.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label1.Location = new Point(32, 105);
            label1.Name = "label1";
            label1.Size = new Size(130, 30);
            label1.TabIndex = 2;
            label1.Text = "Categories:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label2.Location = new Point(302, 105);
            label2.Name = "label2";
            label2.Size = new Size(176, 30);
            label2.TabIndex = 3;
            label2.Text = "Category Tasks:";
            // 
            // btn_addcategory
            // 
            btn_addcategory.Location = new Point(32, 56);
            btn_addcategory.Name = "btn_addcategory";
            btn_addcategory.Size = new Size(116, 33);
            btn_addcategory.TabIndex = 4;
            btn_addcategory.Text = "Add Category";
            btn_addcategory.UseVisualStyleBackColor = true;
            btn_addcategory.Click += btn_addcategory_Click;
            // 
            // btn_refresh
            // 
            btn_refresh.Location = new Point(32, 639);
            btn_refresh.Name = "btn_refresh";
            btn_refresh.Size = new Size(105, 33);
            btn_refresh.TabIndex = 5;
            btn_refresh.Text = "Refresh";
            btn_refresh.UseVisualStyleBackColor = true;
            btn_refresh.Click += btn_refresh_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(946, 698);
            Controls.Add(btn_refresh);
            Controls.Add(btn_addcategory);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgv_Tasks);
            Controls.Add(dgv_Categories);
            Name = "Form1";
            Text = "TO DO LIST";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_Categories).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv_Tasks).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgv_Categories;
        private DataGridView dgv_Tasks;
        private Label label1;
        private Label label2;
        private Button btn_addcategory;
        private Button btn_refresh;
    }
}
