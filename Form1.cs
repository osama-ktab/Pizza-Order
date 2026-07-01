using System.Runtime.Intrinsics.X86;

namespace Pizza_Order
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        float GetSelectedCrustPrice()
        {
            if (rdThinCrust.Checked)
            {
                return Convert.ToSingle(rdThinCrust.Tag);
            }
            else
            {
                return Convert.ToSingle(rdThinkCrust.Tag);
            }

        }

        float CalculateToppingsPrice()
        {
            float ToppingsTotal = 0;

            if (chkExtraChees.Checked)
            {
                ToppingsTotal += Convert.ToSingle(chkExtraChees.Tag);
            }

            if (chkOnion.Checked)
            {
                ToppingsTotal += Convert.ToSingle(chkOnion.Tag);
            }

            if (chkMushrooms.Checked)
            {
                ToppingsTotal += Convert.ToSingle(chkMushrooms.Tag);
            }

            if (chkOlives.Checked)
            {
                ToppingsTotal += Convert.ToSingle(chkOlives.Tag);
            }

            if (chkTomatoes.Checked)
            {
                ToppingsTotal += Convert.ToSingle(chkTomatoes.Tag);
            }

            if (chkGreenPeppers.Checked)
            {
                ToppingsTotal += Convert.ToSingle(chkGreenPeppers.Tag);
            }

            return ToppingsTotal;

        }

        float GetSelectedSizePrice()
        {
            if (rdSmall.Checked)
            {
                return Convert.ToSingle(rdSmall.Tag);
            }
            else if (rdMedum.Checked)
            {
                return Convert.ToSingle(rdMedum.Tag);

            }
            else
            {
                return Convert.ToSingle(rdLarge.Tag);
            }
        }

        float CalculateTotalPrice()
        {
            return GetSelectedSizePrice() + CalculateToppingsPrice() + GetSelectedCrustPrice();
        }

        void UpdateTotalPrice()
        {
            LaPriceInNumber.Text = "$" + CalculateTotalPrice().ToString();
        }

        void UpdateSize()
        {

            UpdateTotalPrice();
            if (rdSmall.Checked)
            {
                LaSizeChoosen.Text = rdSmall.Text;
                return;
            }

            if (rdMedum.Checked)
            {
                LaSizeChoosen.Text = rdMedum.Text;
                return;
            }

            if (rdLarge.Checked)
            {
                LaSizeChoosen.Text = rdLarge.Text;
                return;
            }




        }

        void UpdateCtust()
        {
            UpdateTotalPrice();
            if (rdThinCrust.Checked)
            {
                LaCrustChoosen.Text = rdThinCrust.Text;
                return;
            }

            if (rdThinkCrust.Checked)
            {
                LaCrustChoosen.Text = rdThinkCrust.Text;
                return;
            }

        }

        void UpdateToppings()
        {
            UpdateTotalPrice();
            string sToppings = "";

            if (chkExtraChees.Checked)
                sToppings = "Extra Cheees";

            if (chkOnion.Checked)
                sToppings += ", Onion";

            if (chkMushrooms.Checked)
                sToppings += ", Mushrooms";

            if (chkOlives.Checked)
                sToppings += ", Olives";

            if (chkTomatoes.Checked)
                sToppings += ", Tomatoes";

            if (chkGreenPeppers.Checked)
                sToppings += ", Green Peppres";

            LaToppingsChoosen.Text = sToppings;
        }

        void UpdateWhereToEat()
        {
            if (rdEatIn.Checked)
            {
                LaWhereToEatChoosen.Text = rdEatIn.Text;
            }
            else if(rdTakeOut.Checked) 
            {
                LaWhereToEatChoosen.Text = rdTakeOut.Text;
            }
        }

        void UpdateOrderSummary()
        {
            UpdateSize();
            UpdateToppings();
            UpdateCtust();
            UpdateTotalPrice();

        }

        void ResetForm()
        {
            btnOrder.Enabled = true;
            gbSize.Enabled = true;
            gbToppings.Enabled = true;
            gbWhereToEat.Enabled = true;
            gbCurst.Enabled = true;

            rdMedum.Checked = true;

            chkExtraChees.Checked = false;
            chkOnion.Checked = false;
            chkMushrooms.Checked = false;
            chkOlives.Checked = false;
            chkTomatoes.Checked = false;
            chkGreenPeppers.Checked = false;
            
            rdThinCrust.Checked = true;

            rdEatIn.Checked = true;

        }

        private void rdSmall_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
        }

        private void rdMedum_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
        }

        private void rdLarge_CheckedChanged_1(object sender, EventArgs e)
        {
            UpdateSize();
        }

        private void rdThinCrust_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCtust();
        }

        private void rdThinkCrust_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCtust();
        }

        private void rdEatIn_CheckedChanged(object sender, EventArgs e)
        {
            UpdateWhereToEat();
        }

        private void rdTakeOut_CheckedChanged(object sender, EventArgs e)
        {
            UpdateWhereToEat();
        }

        private void chkExtraChees_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chkMushrooms_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chkTomatoes_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chkOnion_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chkOlives_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chkGreenPeppers_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void LaPrice_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ResetForm();
            UpdateOrderSummary();
        }

        private void gbOrderSummary_Enter(object sender, EventArgs e)
        {

        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirm Order", "Confirm", MessageBoxButtons.OKCancel
                , MessageBoxIcon.Question) == DialogResult.OK)
            {

                MessageBox.Show("Order Placed Successfully", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnOrder.Enabled = false;
                gbSize.Enabled = false;
                gbToppings.Enabled = false;
                gbWhereToEat.Enabled = false;
                gbCurst.Enabled = false;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetForm();
        }
    }
}

