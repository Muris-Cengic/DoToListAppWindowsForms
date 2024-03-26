namespace DoToListAppWindowsForms
{
    partial class ConfirmationForm
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
            btn_no = new Button();
            btn_yes = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(32, 24);
            label1.Name = "label1";
            label1.Size = new Size(263, 17);
            label1.TabIndex = 0;
            label1.Text = "Are you sure you want to delete the task(s)?";
            // 
            // btn_no
            // 
            btn_no.Location = new Point(65, 55);
            btn_no.Name = "btn_no";
            btn_no.Size = new Size(75, 23);
            btn_no.TabIndex = 1;
            btn_no.Text = "No";
            btn_no.UseVisualStyleBackColor = true;
            btn_no.Click += btn_no_Click;
            // 
            // btn_yes
            // 
            btn_yes.Location = new Point(168, 55);
            btn_yes.Name = "btn_yes";
            btn_yes.Size = new Size(75, 23);
            btn_yes.TabIndex = 2;
            btn_yes.Text = "Yes";
            btn_yes.UseVisualStyleBackColor = true;
            btn_yes.Click += btn_yes_Click;
            // 
            // ConfirmationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(329, 92);
            Controls.Add(btn_yes);
            Controls.Add(btn_no);
            Controls.Add(label1);
            Name = "ConfirmationForm";
            Text = "ConfirmationForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btn_no;
        private Button btn_yes;
    }
}