namespace DoToListAppWindowsForms
{
    partial class AddTaskForm
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
            label1 = new Label();
            txt_category = new TextBox();
            txt_task = new TextBox();
            label2 = new Label();
            btn_addtask = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 14.25F);
            label1.Location = new Point(33, 30);
            label1.Name = "label1";
            label1.Size = new Size(90, 24);
            label1.TabIndex = 0;
            label1.Text = "Category:";
            // 
            // txt_category
            // 
            txt_category.Enabled = false;
            txt_category.Location = new Point(33, 57);
            txt_category.Name = "txt_category";
            txt_category.Size = new Size(128, 23);
            txt_category.TabIndex = 1;
            // 
            // txt_task
            // 
            txt_task.Location = new Point(252, 57);
            txt_task.Name = "txt_task";
            txt_task.Size = new Size(138, 23);
            txt_task.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 14.25F);
            label2.Location = new Point(252, 30);
            label2.Name = "label2";
            label2.Size = new Size(111, 24);
            label2.TabIndex = 3;
            label2.Text = "Task Name:";
            // 
            // btn_addtask
            // 
            btn_addtask.Location = new Point(173, 100);
            btn_addtask.Name = "btn_addtask";
            btn_addtask.Size = new Size(75, 28);
            btn_addtask.TabIndex = 5;
            btn_addtask.Text = "Add";
            btn_addtask.UseVisualStyleBackColor = true;
            btn_addtask.Click += btn_addtask_Click;
            // 
            // AddTaskForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(423, 143);
            Controls.Add(btn_addtask);
            Controls.Add(label2);
            Controls.Add(txt_task);
            Controls.Add(txt_category);
            Controls.Add(label1);
            Name = "AddTaskForm";
            Text = "AddTaskForm";
            Load += AddTaskForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txt_category;
        private TextBox txt_task;
        private Label label2;
        private Button btn_addtask;
    }
}