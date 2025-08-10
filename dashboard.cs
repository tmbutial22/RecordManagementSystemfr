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
    public partial class dashboard : Form
    {
        private bool isCollapsed;
        public dashboard()
        {
            InitializeComponent();
        }

        private void btnScheds_Click(object sender, EventArgs e)
        {

        }

        private void panelscheds_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                panelsched.Height += 10;
                if (panelsched.Size == panelsched.MaximumSize)
                {
                    timer1.Stop();
                    isCollapsed = false;
                }
            }
            else
            {
                panelsched.Height -= 10;
                if (panelsched.Size == panelsched.MinimumSize)
                {
                    timer1.Stop();
                    isCollapsed = true;
                }

            }
        }

        private void btnscheds_Click_1(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
