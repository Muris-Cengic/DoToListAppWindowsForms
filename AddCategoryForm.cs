using DoToListAppWindowsForms.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoToListAppWindowsForms
{
    public partial class AddCategoryForm : Form
    {
        //private readonly DataGridView dgv_Categories;
        private MainForm mainForm;

        public AddCategoryForm(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            //this.dgv_Categories = dgv_Categories;
        }

        private void btn_addcategory_Click(object sender, EventArgs e)
        {
            Category category = new Category();
            category.CategoryName = txt_name.Text;
            using (var db = new TodolistContext())
            {
                db.Categories.Add(category);
                db.SaveChanges();
                //this.dgv_Categories.DataSource = db.Categories.ToList();
            }
            mainForm.LoadDataFromDatabase();
            Close();
        }
    }
}
