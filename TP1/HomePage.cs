using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP1
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void HomePage_Load(object sender, EventArgs e)
        {
            panelOut.Visible = false;
            foodPnl.Visible = false;
            panel1.Visible = false;
            phnPnl.Visible = false;
            jaketPnl.Visible = false;
            cooD.Visible = false;
            laptD.Visible = false;
            foodPnl.Visible = false;
            clotPnl.Visible = false;
            elekPnl.Visible = false;
            filterPanel.Visible = false;
            categoryBox.Items.Add("Electronic");
            categoryBox.Items.Add("Clothes");
            categoryBox.Items.Add("Food");
            priceBox.Items.Add("100000 - 200000");
            priceBox.Items.Add("200000 - 500000");
            priceBox.Items.Add("500000 - 1000000");
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            panelOut.Visible = false;
            foodPnl.Visible = false;
            panel1.Visible = false;
            phnPnl.Visible = false;
            jaketPnl.Visible = false;
            cooD.Visible = false;
            laptD.Visible = false;
            elekPnl.Visible = false;
            clotPnl.Visible = false;
            foodPnl.Visible = false;
            allPanel.Visible = true;
            allPanel.BringToFront();
        }

        private void btnCatalog_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.tokopedia.com/");
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if(categoryBox.Text == "Electronic" || priceBox.Text == "500000 - 1000000")
            {
                elekPnl.Visible = true;
                elekPnl.BringToFront();
                clotPnl.Visible = false;
                foodPnl.Visible = false;
                foodPnl.Visible = false;
            }
            else if (categoryBox.Text == "Clothes" || priceBox.Text == "200000 - 500000")
            {
                clotPnl.Visible = true;
                clotPnl.BringToFront();
                elekPnl.Visible = false;
                foodPnl.Visible = false;
                foodPnl.Visible = false;
            }
            else if (categoryBox.Text == "Food" || priceBox.Text == "100000 - 200000")
            {
                foodPnl.Visible = true;
                foodPnl.BringToFront();
                elekPnl.Visible = false;
                foodPnl.Visible = false;
                clotPnl.Visible = false;
            }
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            categoryBox.ResetText();
            priceBox.ResetText();
            categoryBox.Enabled = true;
            priceBox.Enabled = true;
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            filterPanel.Visible = false;
        }

        private void LogOut_Click(object sender, EventArgs e)
        {
            LoginForm obj = new LoginForm();
            if (obj == null)
            {
                obj.Parent = this;
            }
            obj.Show();
            this.Hide();
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            filterPanel.Visible = true;
        }

        private void laptopBtn_Click(object sender, EventArgs e)
        {
            laptD.Visible = true;
            laptD.BringToFront();
        }

        private void cookieBtn_Click(object sender, EventArgs e)
        {
            cooD.Visible = true;
            cooD.BringToFront();
        }

        private void jacketBtn_Click(object sender, EventArgs e)
        {
            jaketPnl.Visible = true;
            jaketPnl.BringToFront();
        }

        private void hpBtn_Click(object sender, EventArgs e)
        {
            phnPnl.Visible = true;
            phnPnl.BringToFront();
        }

        private void outerBtn_Click(object sender, EventArgs e)
        {
            panelOut.Visible = true;
            panelOut.BringToFront();
        }
 
        private void laptElek_Click(object sender, EventArgs e)
        {
            laptD.Visible = true;
            laptD.BringToFront();
        }

        private void hpElek_Click(object sender, EventArgs e)
        {
            phnPnl.Visible = true;
            phnPnl.BringToFront();
        }

        private void outClot_Click(object sender, EventArgs e)
        {
            //panel1.Visible = true;
            //panel1.BringToFront();
            panelOut.Visible = true;
            panelOut.BringToFront();
        }

        private void jacClot_Click(object sender, EventArgs e)
        {
            jaketPnl.Visible = true;
            jaketPnl.BringToFront();
        }

        private void cooFood_Click(object sender, EventArgs e)
        {
            cooD.Visible = true;
            cooD.BringToFront();
        }

        private void cookie_Click(object sender, EventArgs e)
        {
            cooD.Visible = true;
            cooD.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Payment Code : 1901280. Thank You!", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void back1_Click(object sender, EventArgs e)
        {
            allPanel.Visible = true;
            allPanel.BringToFront();
        }

        private void buy2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Payment Code : 1901280. Thank You!", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void back2_Click(object sender, EventArgs e)
        {
            allPanel.Visible = true;
            allPanel.BringToFront();
        }

        private void categoryBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(categoryBox.Text != "")
            {
                priceBox.Enabled = false;
            }
        }

        private void priceBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (priceBox.Text != "")
            {
                categoryBox.Enabled = false;
            }
        }

        private void back3_Click(object sender, EventArgs e)
        {
            allPanel.Visible = true;
            allPanel.BringToFront();
        }

        private void buy3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Payment Code : 1901280. Thank You!", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Payment Code : 1901280. Thank You!", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            allPanel.Visible = true;
            allPanel.BringToFront();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Payment Code : 1901280. Thank You!", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            allPanel.Visible = true;
            allPanel.BringToFront();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            allPanel.Visible = true;
            allPanel.BringToFront();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Payment Code : 1901280. Thank You!", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void button14_Click(object sender, EventArgs e)
        {

        }
    }
}
