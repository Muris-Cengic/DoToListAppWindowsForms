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
            categoryIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            categoryNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            tasksDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            btn_delete_category = new DataGridViewButtonColumn();
            categoryBindingSource1 = new BindingSource(components);
            dgv_Tasks = new DataGridView();
            taskIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            titleDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dateCreatedDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            isCompletedDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            categoryIdDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            categoryDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            rm = new DataGridViewCheckBoxColumn();
            taskBindingSource = new BindingSource(components);
            label1 = new Label();
            label2 = new Label();
            btn_addcategory = new Button();
            btn_refresh = new Button();
            btn_addTask = new Button();
            categoryBindingSource = new BindingSource(components);
            btn_removeSelectedTasks = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_Categories).BeginInit();
            ((System.ComponentModel.ISupportInitialize)categoryBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv_Tasks).BeginInit();
            ((System.ComponentModel.ISupportInitialize)taskBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)categoryBindingSource).BeginInit();
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
            // categoryBindingSource1
            // 
            categoryBindingSource1.DataSource = typeof(Models.Category);
            // 
            // dgv_Tasks
            // 
            dgv_Tasks.AutoGenerateColumns = false;
            dgv_Tasks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_Tasks.BackgroundColor = SystemColors.ActiveBorder;
            dgv_Tasks.BorderStyle = BorderStyle.Fixed3D;
            dgv_Tasks.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgv_Tasks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Tasks.Columns.AddRange(new DataGridViewColumn[] { taskIdDataGridViewTextBoxColumn, titleDataGridViewTextBoxColumn, dateCreatedDataGridViewTextBoxColumn, isCompletedDataGridViewCheckBoxColumn, categoryIdDataGridViewTextBoxColumn1, categoryDataGridViewTextBoxColumn, rm });
            dgv_Tasks.DataSource = taskBindingSource;
            dgv_Tasks.GridColor = SystemColors.ActiveBorder;
            dgv_Tasks.Location = new Point(302, 143);
            dgv_Tasks.Name = "dgv_Tasks";
            dgv_Tasks.RowHeadersVisible = false;
            dgv_Tasks.RowTemplate.DefaultCellStyle.BackColor = SystemColors.ActiveBorder;
            dgv_Tasks.RowTemplate.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dgv_Tasks.Size = new Size(604, 490);
            dgv_Tasks.TabIndex = 1;
            // 
            // taskIdDataGridViewTextBoxColumn
            // 
            taskIdDataGridViewTextBoxColumn.DataPropertyName = "TaskId";
            taskIdDataGridViewTextBoxColumn.HeaderText = "TaskId";
            taskIdDataGridViewTextBoxColumn.Name = "taskIdDataGridViewTextBoxColumn";
            taskIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            titleDataGridViewTextBoxColumn.HeaderText = "Title";
            titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            // 
            // dateCreatedDataGridViewTextBoxColumn
            // 
            dateCreatedDataGridViewTextBoxColumn.DataPropertyName = "DateCreated";
            dateCreatedDataGridViewTextBoxColumn.HeaderText = "DateCreated";
            dateCreatedDataGridViewTextBoxColumn.Name = "dateCreatedDataGridViewTextBoxColumn";
            // 
            // isCompletedDataGridViewCheckBoxColumn
            // 
            isCompletedDataGridViewCheckBoxColumn.DataPropertyName = "IsCompleted";
            isCompletedDataGridViewCheckBoxColumn.HeaderText = "IsCompleted";
            isCompletedDataGridViewCheckBoxColumn.Name = "isCompletedDataGridViewCheckBoxColumn";
            // 
            // categoryIdDataGridViewTextBoxColumn1
            // 
            categoryIdDataGridViewTextBoxColumn1.DataPropertyName = "CategoryId";
            categoryIdDataGridViewTextBoxColumn1.HeaderText = "CategoryId";
            categoryIdDataGridViewTextBoxColumn1.Name = "categoryIdDataGridViewTextBoxColumn1";
            categoryIdDataGridViewTextBoxColumn1.Visible = false;
            // 
            // categoryDataGridViewTextBoxColumn
            // 
            categoryDataGridViewTextBoxColumn.DataPropertyName = "Category";
            categoryDataGridViewTextBoxColumn.HeaderText = "Category";
            categoryDataGridViewTextBoxColumn.Name = "categoryDataGridViewTextBoxColumn";
            categoryDataGridViewTextBoxColumn.Visible = false;
            // 
            // rm
            // 
            rm.FalseValue = "false";
            rm.HeaderText = "Remove";
            rm.IndeterminateValue = "";
            rm.Name = "rm";
            rm.TrueValue = "true";
            // 
            // taskBindingSource
            // 
            taskBindingSource.DataSource = typeof(Models.Task);
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
            // btn_removeSelectedTasks
            // 
            btn_removeSelectedTasks.Location = new Point(748, 639);
            btn_removeSelectedTasks.Name = "btn_removeSelectedTasks";
            btn_removeSelectedTasks.Size = new Size(158, 33);
            btn_removeSelectedTasks.TabIndex = 7;
            btn_removeSelectedTasks.Text = "Remove Selected Tasks";
            btn_removeSelectedTasks.UseVisualStyleBackColor = true;
            btn_removeSelectedTasks.Click += button1_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(946, 698);
            Controls.Add(btn_removeSelectedTasks);
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
            ((System.ComponentModel.ISupportInitialize)categoryBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv_Tasks).EndInit();
            ((System.ComponentModel.ISupportInitialize)taskBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)categoryBindingSource).EndInit();
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
        private Button btn_removeSelectedTasks;
        private DataGridViewTextBoxColumn taskIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dateCreatedDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn isCompletedDataGridViewCheckBoxColumn;
        private DataGridViewTextBoxColumn categoryIdDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn rm;
        private BindingSource taskBindingSource;
    }
}
