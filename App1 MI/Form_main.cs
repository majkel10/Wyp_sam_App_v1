using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App1_MI
{
    public partial class Form_main : MaterialSkin.Controls.MaterialForm
    {
        public Form_main()
        {
            InitializeComponent();
        }

        private void button_samochody_Click(object sender, EventArgs e)
        {
            Form_samochody openForm = new Form_samochody();
            openForm.Show();
            Visible = false;
        }

        private void Form_main_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
