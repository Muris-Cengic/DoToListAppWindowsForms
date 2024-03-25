using DoToListAppWindowsForms.Models;
using Microsoft.EntityFrameworkCore;
using System.Runtime.ExceptionServices;

namespace DoToListAppWindowsForms
{
    public partial class MainForm : Form
    {
        private Category selectedCategory;

        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadDataFromDatabase();
        }

        public void LoadDataFromDatabase()
        {
            using (TodolistContext db = new TodolistContext())
            {
                var categories = db.Categories.ToList();
                dgv_Categories.DataSource = categories;

                if (categories.Any())
                {
                    btn_addTask.Enabled = true;
                    selectedCategory = categories.First();

                    var firstCategoryTasks = db.Tasks.Where(t => t.CategoryId == selectedCategory.CategoryId).ToList();

                    dgv_Tasks.DataSource = firstCategoryTasks;
                    dgv_Tasks.Columns["TaskId"].Visible = false;
                    dgv_Tasks.Columns["CategoryId"].Visible = false;
                    dgv_Tasks.Columns["Category"].Visible = false;
                }
            }

            dgv_Categories.Columns["Tasks"].Visible = false;
            dgv_Categories.Columns["CategoryId"].Visible = false;
        }

        private void dgv_Categories_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btn_addTask.Enabled = true;
            selectedCategory = (Category)dgv_Categories.Rows[e.RowIndex].DataBoundItem;
            using (var db = new TodolistContext())
            {
                var tasks = db.Tasks.Where(t => t.CategoryId == selectedCategory.CategoryId).ToList();
                dgv_Tasks.DataSource = tasks;
            }
        }

        private void btn_addcategory_Click(object sender, EventArgs e)
        {
            AddCategoryForm addCategoryForm = new AddCategoryForm(this);
            addCategoryForm.ShowDialog();
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            LoadDataFromDatabase();
        }

        private void btn_addTask_Click(object sender, EventArgs e)
        {
            AddTaskForm addTaskForm = new AddTaskForm(selectedCategory, dgv_Tasks);
            addTaskForm.ShowDialog();
        }
    }
}
