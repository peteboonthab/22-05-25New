using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Original1
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void Back5_Click(object sender, EventArgs e)
        {
            Form3 f3 = (Form3)Application.OpenForms["Form3"];
            this.Owner = f3;
            this.Owner.Show();
            this.Hide();
        }
        private void BtnGo6_Click(object sender, EventArgs e)
        {
            Form3 f3 = (Form3)Application.OpenForms["Form3"];
            this.Owner = f3;
            this.Owner.Show();
            this.Hide();
        }
    }
}

