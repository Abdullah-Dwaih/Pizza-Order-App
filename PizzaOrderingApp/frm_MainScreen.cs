using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaOrderingApp
{
    public partial class frm_MainScreen : Form
    {
        public frm_MainScreen()
        {
            InitializeComponent();
        }

        private void btn_GoToOrderForm_Click(object sender, EventArgs e)
        {
            Form frm = new frm_OrderScreen();
            frm.ShowDialog();
        }
    }
}
