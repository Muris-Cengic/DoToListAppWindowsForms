namespace DoToListAppWindowsForms
{
    partial class AddCategoryForm
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
            txt_name = new TextBox();
            btn_addcategory = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(34, 28);
            label1.Name = "label1";
            label1.Size = new Size(147, 25);
            label1.TabIndex = 0;
            label1.Text = "Category Name:";
            // 
            // txt_name
            // 
            txt_name.Location = new Point(34, 56);
            txt_name.Name = "txt_name";
            txt_name.Size = new Size(188, 23);
            txt_name.TabIndex = 1;
            // 
            // btn_addcategory
            // 
            btn_addcategory.Location = new Point(249, 56);
            btn_addcategory.Name = "btn_addcategory";
            btn_addcategory.Size = new Size(75, 23);
            btn_addcategory.TabIndex = 2;
            btn_addcategory.Text = "Add";
            btn_addcategory.UseVisualStyleBackColor = true;
            btn_addcategory.Click += btn_addcategory_Click;
            // 
            // AddCategoryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(499, 115);
            Controls.Add(btn_addcategory);
            Controls.Add(txt_name);
            Controls.Add(label1);
            Name = "AddCategoryForm";
            Text = "Add Category";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txt_name;
        private Button btn_addcategory;
    }
}