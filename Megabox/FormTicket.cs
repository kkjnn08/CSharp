using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Megabox
{
    public partial class FormTicket : Form
    {
        public FormTicket()
        {
            InitializeComponent();
        }

        private void listBox1_MouseClick(object sender, MouseEventArgs e)
        {
            txtMovie.Text = listBox1.Text;
        }

        private void listBox2_Click(object sender, EventArgs e)
        {
            txtCinema.Text = listBox2.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("예매가 완료되었습니다.");
        }
    }
}
