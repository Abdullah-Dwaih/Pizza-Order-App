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
    public partial class frm_OrderScreen : Form
    {
        public frm_OrderScreen()
        {
            InitializeComponent();
        }


        float CalculateToppingPrice ()
        {
            float ToppingPrice = 0;

            if (chk_Mashrom.Checked == true)
            {
                ToppingPrice +=  Convert.ToSingle(chk_Mashrom.Tag);
            }

            if (chk_ExtraChess.Checked == true)
            {
               ToppingPrice +=  Convert.ToSingle(chk_ExtraChess.Tag);
            }

            if (chk_Olives.Checked == true)
            {
                ToppingPrice +=  Convert.ToSingle(chk_Olives.Tag);
            }

            if (chk_Onion.Checked == true)
            {
                ToppingPrice +=  Convert.ToSingle(chk_Onion.Tag);
            }

            if (chk_Papper.Checked == true)
            {
                ToppingPrice +=  Convert.ToSingle(chk_Papper.Tag);
            }

            if (chk_Tomato.Checked == true)
            {
                ToppingPrice +=  Convert.ToSingle(chk_Tomato.Tag);
            }

            return ToppingPrice;

        }
        float CalculateSizePrice()

        {
            if (rad_small.Checked == true)
            
               return Convert.ToSingle(rad_small.Tag);
            
            else if (rad_Medium.Checked == true)
            
               return Convert.ToSingle(rad_Medium.Tag);
            
            else  
            
              return Convert.ToSingle(rad_Big.Tag);
            
        }
        float CalculateCrustPrice ()
        {
            if (rad_ThinCrust.Checked == true)
            {
               return  Convert.ToSingle(rad_ThinCrust.Tag);
            }
            else  
            {
                return Convert.ToSingle(rad_ThickCrust.Tag);
            }

        }

        float CalculateWhereToEatPrice()
        {
            if (rad_TakeOut.Checked == true)
            {
                return Convert.ToSingle(rad_TakeOut.Tag);
            }
            else
            {
               return Convert.ToSingle(rad_EatIn.Tag);
            }
        }
        float CalculateTotalPrice ()
        {
            return CalculateToppingPrice() + CalculateSizePrice() + CalculateCrustPrice() + CalculateWhereToEatPrice();
        }

        void UpdatePrice ()
        {
           float TotalPrice =  CalculateTotalPrice();

            lab_TotalPrice.Text = $"$ {TotalPrice}";
        }
      


        private void btn_ResetOrder_Click(object sender, EventArgs e)
        {
            chk_Tomato.Checked = false;
            chk_Papper.Checked = false;
            chk_Onion.Checked = false;
            chk_Olives.Checked = false;
            chk_Mashrom.Checked = false;
            chk_ExtraChess.Checked = false;




            gb_PizzaSize.Enabled = true;
            gb_CrustType.Enabled = true;
            gb_Toppings.Enabled = true;
            gb_WhereToEat.Enabled = true;

            rad_Medium.Checked = true;
            rad_ThinCrust.Checked = true;
            rad_TakeOut.Checked = true;

            UpdatePrice();
        }

        private void btn_ConfirmOrder_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("Are You Sure You Want To Make This Order ?", "Confirm Order", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {

                MessageBox.Show("The Order is Done :-) ", "Done", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                gb_PizzaSize.Enabled = false;
                gb_CrustType.Enabled = false;
                gb_Toppings.Enabled = false;
                gb_WhereToEat.Enabled = false;
            }
        }

        void CalculateDefaultPrice()
        {
            UpdatePrice();
        }
        private void frm_OrderScreen_Load(object sender, EventArgs e)
        {
            CalculateDefaultPrice();
        }

 

        private void rad_small_CheckedChanged(object sender, EventArgs e)
        {
            UpdatePrice();
        }

        private void rad_Medium_CheckedChanged(object sender, EventArgs e)
        {
            UpdatePrice();
        }

        private void rad_Big_CheckedChanged(object sender, EventArgs e)
        {
            UpdatePrice();
        }

        private void rad_ThinCrust_CheckedChanged(object sender, EventArgs e)
        {
            UpdatePrice();
        }

        private void rad_ThickCrust_CheckedChanged(object sender, EventArgs e)
        {
            UpdatePrice();
        }

        private void chk_ExtraChess_CheckedChanged(object sender, EventArgs e)
        {
            UpdatePrice();
        }

        private void chk_Onion_CheckedChanged(object sender, EventArgs e)
        {
            UpdatePrice();
        }

        private void chk_Tomato_CheckedChanged(object sender, EventArgs e)
        {
            UpdatePrice();
        }

        private void chk_Olives_CheckedChanged(object sender, EventArgs e)
        {
            UpdatePrice();
        }

        private void chk_Mashrom_CheckedChanged(object sender, EventArgs e)
        {
            UpdatePrice();
        }

        private void chk_Papper_CheckedChanged(object sender, EventArgs e)
        {
            UpdatePrice();
        }

        private void rad_EatIn_CheckedChanged(object sender, EventArgs e)
        {
            UpdatePrice();
        }

        private void rad_TakeOut_CheckedChanged(object sender, EventArgs e)
        {
            UpdatePrice();
        }
    }
}
