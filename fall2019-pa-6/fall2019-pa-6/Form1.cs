using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fall2019_pa_6
{
    public partial class formCWID : Form
    {
        public formCWID()
        {
            InitializeComponent();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            formMain myForm = new formMain(textCWID.Text);
            if(myForm.ShowDialog() == DialogResult.OK)
            {
                
            }
            else
            {
                this.Close();
            }
        }
    }
}
