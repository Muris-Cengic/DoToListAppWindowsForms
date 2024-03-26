namespace DoToListAppWindowsForms
{
    partial class MainForm
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
            components = new System.ComponentModel.Container();
            dgv_Categories = new DataGridView();
            dgv_Tasks = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            btn_addcategory = new Button();
            btn_refresh = new Button();
            btn_addTask = new Button();
            categoryBindingSource = new BindingSource(components);
            categoryBindingSource1 = new BindingSource(components);
            categoryIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            categoryNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            tasksDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            btn_delete_category = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)dgv_Categories).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv_Tasks).BeginInit();
            ((System.ComponentModel.ISupportInitialize)categoryBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)categoryBindingSource1).BeginInit();
            SuspendLayout();
            // 
            // dgv_Categories
            // 
            dgv_Categories.AutoGenerateColumns = false;
            dgv_Categories.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_Categories.BackgroundColor = SystemColors.ActiveBorder;
            dgv_Categories.BorderStyle = BorderStyle.Fixed3D;
            dgv_Categories.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgv_Categories.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Categories.ColumnHeadersVisible = false;
            dgv_Categories.Columns.AddRange(new DataGridViewColumn[] { categoryIdDataGridViewTextBoxColumn, categoryNameDataGridViewTextBoxColumn, tasksDataGridViewTextBoxColumn, btn_delete_category });
            dgv_Categories.DataSource = categoryBindingSource1;
            dgv_Categories.GridColor = SystemColors.ActiveBorder;
            dgv_Categories.Location = new Point(32, 143);
            dgv_Categories.Name = "dgv_Categories";
            dgv_Categories.RowHeadersVisible = false;
            dgv_Categories.RowTemplate.DefaultCellStyle.BackColor = SystemColors.ActiveBorder;
            dgv_Categories.RowTemplate.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dgv_Categories.Size = new Size(196, 490);
            dgv_Categories.TabIndex = 0;
            dgv_Categories.CellClick += dgv_Categories_CellClick;
            dgv_Categories.CellContentClick += dgv_Categories_CellContentClick;
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
            btn_addcategory.Location = new Point(32, 23);
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
            // btn_addTask
            // 
            btn_addTask.Enabled = false;
            btn_addTask.Location = new Point(32, 62);
            btn_addTask.Name = "btn_addTask";
            btn_addTask.Size = new Size(118, 33);
            btn_addTask.TabIndex = 6;
            btn_addTask.Text = "Add Task";
            btn_addTask.UseVisualStyleBackColor = true;
            btn_addTask.Click += btn_addTask_Click;
            // 
            // categoryBindingSource
            // 
            categoryBindingSource.DataSource = typeof(Models.Category);
            // 
            // categoryBindingSource1
            // 
            categoryBindingSource1.DataSource = typeof(Models.Category);
            // 
            // categoryIdDataGridViewTextBoxColumn
            // 
            categoryIdDataGridViewTextBoxColumn.DataPropertyName = "CategoryId";
            categoryIdDataGridViewTextBoxColumn.HeaderText = "CategoryId";
            categoryIdDataGridViewTextBoxColumn.Name = "categoryIdDataGridViewTextBoxColumn";
            categoryIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // categoryNameDataGridViewTextBoxColumn
            // 
            categoryNameDataGridViewTextBoxColumn.DataPropertyName = "CategoryName";
            categoryNameDataGridViewTextBoxColumn.HeaderText = "CategoryName";
            categoryNameDataGridViewTextBoxColumn.Name = "categoryNameDataGridViewTextBoxColumn";
            // 
            // tasksDataGridViewTextBoxColumn
            // 
            tasksDataGridViewTextBoxColumn.DataPropertyName = "Tasks";
            tasksDataGridViewTextBoxColumn.HeaderText = "Tasks";
            tasksDataGridViewTextBoxColumn.Name = "tasksDataGridViewTextBoxColumn";
            tasksDataGridViewTextBoxColumn.Visible = false;
            // 
            // btn_delete_category
            // 
            btn_delete_category.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            btn_delete_category.HeaderText = "DELETE";
            btn_delete_category.Name = "btn_delete_category";
            btn_delete_category.Text = "X";
            btn_delete_category.UseColumnTextForButtonValue = true;
            btn_delete_category.Width = 35;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(946, 698);
            Controls.Add(btn_addTask);
            Controls.Add(btn_refresh);
            Controls.Add(btn_addcategory);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgv_Tasks);
            Controls.Add(dgv_Categories);
            Name = "MainForm";
            Text = "TO DO LIST";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_Categories).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv_Tasks).EndInit();
            ((System.ComponentModel.ISupportInitialize)categoryBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)categoryBindingSource1).EndInit();
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
        private Button btn_addTask;
        private BindingSource categoryBindingSource;
        private DataGridViewTextBoxColumn categoryIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn categoryNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tasksDataGridViewTextBoxColumn;
        private DataGridViewButtonColumn btn_delete_category;
        private BindingSource categoryBindingSource1;
    }
}
