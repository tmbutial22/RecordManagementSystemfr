using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecordManagementSystemfr
{
    public partial class loginform : Form
    {
        public loginform()
        {
            InitializeComponent();
        }

        private void hide_Click(object sender, EventArgs e)
        {
            if (password.PasswordChar == '\0')
            {
                unhide.BringToFront();
                password.PasswordChar = '*';
            }
        }

        private void unhide_Click(object sender, EventArgs e)
        {
            if (password.PasswordChar == '*')
            {
                hide.BringToFront();
                password.PasswordChar = '\0';
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dashboard dashboard = new dashboard();
            dashboard.Show();
        }
    }
}
