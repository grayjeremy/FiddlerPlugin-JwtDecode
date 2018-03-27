using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FiddlerJwtDecodeUiTest
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.jwtTabContent1.HTTPBody = Encoding.ASCII.GetBytes(textBox1.Text);
            this.jwtTabContent1.HTTPHeaders = null;
        }
    }
}
