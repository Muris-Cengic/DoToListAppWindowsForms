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
                    //dgv_Tasks.Columns["TaskId"].Visible = false;
                    //dgv_Tasks.Columns["CategoryId"].Visible = false;
                    //dgv_Tasks.Columns["Category"].Visible = false;
                }
                else
                {
                    dgv_Tasks.DataSource = null;
                }
            }
            //dgv_Categories.Columns["Tasks"].Visible = false;
            //dgv_Categories.Columns["CategoryId"].Visible = false;
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

        private void dgv_Categories_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var clickedColumn = dgv_Categories.Columns[e.ColumnIndex];

            if (clickedColumn.Name == "btn_delete_category")
            {
                var clickedRow = dgv_Categories.Rows[e.RowIndex];

                Category category = clickedRow.DataBoundItem as Category;

                using (var db = new TodolistContext())
                {
                    var tasks = db.Tasks.Where(task => task.CategoryId == category.CategoryId).ToList();
                    db.Tasks.RemoveRange(tasks);
                    db.Categories.Remove(category);
                    db.SaveChanges();
                }
            }
            LoadDataFromDatabase();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var selectedTasks = new List<Models.Task>();
            foreach (DataGridViewRow row in dgv_Tasks.Rows)
            {
                var cellValue = row.Cells["rm"].Value?.ToString() ?? "false";
                var remove = bool.Parse(cellValue);
                if (remove)
                {
                    selectedTasks.Add(row.DataBoundItem as Models.Task);
                }
            }

        }
    }
}
