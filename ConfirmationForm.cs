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
    public partial class ConfirmationForm : Form
    {
        public bool isConfirmed = false;
        public ConfirmationForm()
        {
            InitializeComponent();
        }

        private void btn_yes_Click(object sender, EventArgs e)
        {
            isConfirmed = true;
            this.Close();
        }

        private void btn_no_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
