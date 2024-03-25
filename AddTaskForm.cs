using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoToListAppWindowsForms.Models;
using Task = DoToListAppWindowsForms.Models.Task;

namespace DoToListAppWindowsForms
{
    public partial class AddTaskForm : Form
    {
        private readonly Category clickedCategory;
        private DataGridView dgv_Tasks;  
        public AddTaskForm(Category clickedCategory, DataGridView dgv_Tasks)
        {
            InitializeComponent();
            this.clickedCategory = clickedCategory;
            this.dgv_Tasks = dgv_Tasks;
        }

        private void btn_addtask_Click(object sender, EventArgs e)
        {
            var task = new Task();
            task.Title = txt_task.Text;
            task.DateCreated = DateTime.Now;
            task.IsCompleted = false;
            task.CategoryId = clickedCategory.CategoryId;

            using (var db = new TodolistContext())
            {
                db.Tasks.Add(task);
                db.SaveChanges();
                dgv_Tasks.DataSource = db.Tasks.Where(x => x.CategoryId == clickedCategory.CategoryId).ToList();
            }
            this.Close();    
        }

        private void AddTaskForm_Load(object sender, EventArgs e)
        {
            txt_category.Text = clickedCategory.CategoryName;
        }
    }
}
