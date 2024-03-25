using DoToListAppWindowsForms.Models;
using Microsoft.EntityFrameworkCore;

namespace DoToListAppWindowsForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadDataFromDatabase();
        }

        private void LoadDataFromDatabase()
        {
            using (TodolistContext db = new TodolistContext())
            {
                var categories = db.Categories.ToList();
                dgv_Categories.DataSource = categories;

                if (categories.Any())
                {
                    var firstCategoryTasks = db.Tasks.Where(t => t.CategoryId == categories.First().CategoryId).ToList();
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
            Category clikedCategory = (Category)dgv_Categories.Rows[e.RowIndex].DataBoundItem;

            using (var db = new TodolistContext())
            {
                var tasks = db.Tasks.Where(t => t.CategoryId == clikedCategory.CategoryId).ToList();
                dgv_Tasks.DataSource = tasks;
            }
        }

        private void btn_addcategory_Click(object sender, EventArgs e)
        {
            AddCategoryForm addCategoryForm = new AddCategoryForm(dgv_Categories);
            addCategoryForm.ShowDialog();
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            LoadDataFromDatabase();
        }
    }
}
