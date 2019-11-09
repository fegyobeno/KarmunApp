using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace KarMun_ShitApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[] countries = { "France", "PRC", "Russia", "UK", "USA", "Italy", "Netherlands", "Switzerland", "Sweden", "Canada", "UAE", "Iran", "Korea", "Germany", "Japan" };
        double[] gdps = { 2.583, 12.24, 1.578, 2.622, 19.39, 1.935, 0.8262, 0.6789, 0.538, 1.653, 0.3826, 0.4395, 1.531, 3.677, 4.872 };
        string[] nuclear = { "1234", "1234", "1234", "1234", "1234", "1234", "1234", "1234", "1234", "1234", "1234", "1234", "1234", "1234", "1234" };

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            cbbManual.Visible = true;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            for (int i = 1;i<100;i++)
            {
                progressBar1.Value = i;
                Thread.Sleep(2);
            }
            progressBar1.Value = 0;
            int ind = 0; 
            ind = cbbCountries.SelectedIndex;
            lblCountry.Text = countries[ind];
            lblGDP.Text = gdps[ind].ToString();
            int years = 3;
            years = int.Parse(txtYears.Text);
            double costs = 0; 
            costs = double.Parse(txtCosts.Text);
            double earnings = 0; 
            earnings = double.Parse(txtEarnings.Text);
            double money = (gdps[ind] * years) - costs + earnings;
            lblMoney.Text = money.ToString();
            lblEaster.Visible = false;
            
            
            int index = 0;
            index = cbbWeather.SelectedIndex;
            if (cbbWeather.SelectedText != null)
            {
                if (index == 0)
                {
                    money = money - ((money * (10)) / 10);
                }
                if (index == 1)
                {
                    money = money -((money * (1)) / 10);
                }
                if (index == 2)
                {
                    Random rnd = new Random();
                    int random1 = rnd.Next(-25, 25);
                    money = (money * (random1)) / 10;
                }
                if (index == 3)
                {
                    money = money - ((money * (-1)) / 10);
                }
                if (index == 4)
                {
                    money = money - ((money * (-10)) / 10);
                }
            }
            if (ind == 0)
            {
                lblFrance.Text = lblMoney.Text;
            }
            if (ind == 1)
            {
                lblPRC.Text = lblMoney.Text;
            }
            if (ind == 2)
            {
                lblRussia.Text = lblMoney.Text;
            }
            if (ind == 3)
            {
                lblUK.Text = lblMoney.Text;
            }
            if (ind == 4)
            {
                lblUSA.Text = lblMoney.Text;
            }
            if (ind == 5)
            {
                lblItaly.Text = lblMoney.Text;
            }
            if (ind == 6)
            {
                lblNether.Text = lblMoney.Text;
            }
            if (ind == 7)
            {
                lblSwitz.Text = lblMoney.Text;
            }
            if (ind == 8)
            {
                lblSweden.Text = lblMoney.Text;
            }
            if (ind == 9)
            {
                lblCanada.Text = lblMoney.Text;
            }
            if (ind == 10)
            {
                lblUAE.Text = lblMoney.Text;
            }
            if (ind == 11)
            {
                lblIran.Text = lblMoney.Text;
            }
            if (ind == 12)
            {
                lblKorea.Text = lblMoney.Text;
            }
            if (ind == 13)
            {
                lblGermany.Text = lblMoney.Text;
            }
            if (ind == 14)
            {
                lblJapan.Text = lblMoney.Text;
            }

           
            



        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblFrance.Text = (gdps[0] * 3).ToString();
            lblPRC.Text = (gdps[1] * 3).ToString();
            lblRussia.Text = (gdps[2] * 3).ToString();
            lblUK.Text = (gdps[3] * 3).ToString();
            lblUSA.Text = (gdps[4] * 3).ToString();
            lblItaly.Text = (gdps[5] * 3).ToString();
            lblNether.Text = (gdps[6] * 3).ToString();
            lblSwitz.Text = (gdps[7] * 3).ToString();
            lblSweden.Text = (gdps[8] * 3).ToString();
            lblCanada.Text= (gdps[9] * 3).ToString();
            lblUAE.Text = (gdps[10] * 3).ToString();
            lblIran.Text = (gdps[11] * 3).ToString();
            lblKorea.Text = (gdps[12] * 3).ToString();
            lblGermany.Text = (gdps[13] * 3).ToString();
            lblJapan.Text = (gdps[14] * 3).ToString();

            cbbManual.Visible = false;
            btnOK.Visible = false;
            txtCanadaMoney.Visible = false;
            txtFranceMoney.Visible = false;
            txtGermanyMoney.Visible = false;
            txtIranMoney.Visible = false;
            txtItalyMoney.Visible = false;
            txtJapanMoney.Visible = false;
            txtKoreaMoney.Visible = false;
            txtNetherMoney.Visible = false;
            txtPRCMoney.Visible = false;
            txtRussiaMoney.Visible = false;
            txtSwedenMoney.Visible = false;
            txtSwitzMoney.Visible = false;
            txtUAEMoney.Visible = false;
            txtUKMoney.Visible = false;
            txtUSAMoney.Visible = false;
            lblEaster.Visible = false;

            cbbnuclear.Visible = false;
            lblNucCode.Visible = false;
            txtNuclearCode.Visible = false;
            btnNuclearSet.Visible = false;
            lblNucAdmin.Visible = false;
            btnNuclear.Visible = false;
            txtNuclearAdmin.Visible = false;
        }

        private void cbbManual_SelectedIndexChanged(object sender, EventArgs e)
        {
            int manual = cbbManual.SelectedIndex;
            lblEaster.Visible = false;
            btnOK.Visible = true;
            if (manual == 0)
            {
                txtFranceMoney.Visible = true;                                
            }
            if (manual == 1)
            {
                 txtPRCMoney.Visible= true;
            }
            if (manual == 2)
            {
                 txtRussiaMoney.Visible = true;
            }
            if (manual == 3)
            {
                 txtUKMoney.Visible= true;
            }
            if (manual == 4)
            {
                 txtUSAMoney.Visible = true;
            }
            if (manual == 5)
            {
                 txtItalyMoney.Visible = true;
            }
            if (manual == 6)
            {
                 txtNetherMoney.Visible = true;
            }
            if (manual == 7)
            {
                 txtSwitzMoney.Visible = true;
            }
            if (manual == 8)
            {
                 txtSwedenMoney.Visible = true;
            }
            if (manual == 9)
            {
                 txtCanadaMoney.Visible= true;
            }
            if (manual == 10)
            {
                 txtUAEMoney.Visible = true;
            }
            if (manual == 11)
            {
                 txtIranMoney.Visible = true;
            }
            if (manual == 12)
            {
                 txtKoreaMoney.Visible = true;
            }
            if (manual == 13)
            {
                txtGermanyMoney.Visible = true;
            }
            if (manual == 14)
            {
                 txtJapanMoney.Visible = true;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            int manu = cbbManual.SelectedIndex;
            if (manu == 0)
            {
                lblFrance.Text = txtFranceMoney.Text;
            }
            if (manu == 1)
            {
                lblPRC.Text = txtPRCMoney.Text;
            }
            if (manu == 2)
            {
                lblRussia.Text = txtRussiaMoney.Text;
                string d = txtRussiaMoney.Text; 
                if (d == 69420.ToString())
                {
                    lblEaster.Visible = true;
                }
            }
            if (manu == 3)
            {
                lblUK.Text = txtUKMoney.Text;
            }
            if (manu == 4)
            {
                lblUSA.Text = txtUSAMoney.Text;
            }
            if (manu == 5)
            {
                lblItaly.Text = txtItalyMoney.Text;
            }
            if (manu == 6)
            {
                lblNether.Text = txtNetherMoney.Text;
            }
            if (manu == 7)
            {
                lblSwitz.Text = txtSwitzMoney.Text;
            }
            if (manu == 8)
            {
                lblSweden.Text = txtSwedenMoney.Text;
            }
            if (manu == 9)
            {
                lblCanada.Text = txtCanadaMoney.Text;
            }
            if (manu == 10)
            {
                lblUAE.Text = txtUAEMoney.Text;
            }
            if(manu == 11)
            {
                lblIran.Text = txtIranMoney.Text;
            }
            if (manu == 12)
            {
                lblKorea.Text = txtKoreaMoney.Text;
            }
            if (manu == 13)
            {
                lblGermany.Text = txtGermanyMoney.Text;
            }
            if (manu == 14)
            {
                lblJapan.Text = txtJapanMoney.Text;
            }
            cbbManual.Visible = false;
            btnOK.Visible = false;
            txtCanadaMoney.Visible = false;
            txtFranceMoney.Visible = false;
            txtGermanyMoney.Visible = false;
            txtIranMoney.Visible = false;
            txtItalyMoney.Visible = false;
            txtJapanMoney.Visible = false;
            txtKoreaMoney.Visible = false;
            txtNetherMoney.Visible = false;
            txtPRCMoney.Visible = false;
            txtRussiaMoney.Visible = false;
            txtSwedenMoney.Visible = false;
            txtSwitzMoney.Visible = false;
            txtUAEMoney.Visible = false;
            txtUKMoney.Visible = false;
            txtUSAMoney.Visible = false;
        }

        private void cbbCountries_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            lblNucAdmin.Visible = true;
            btnNuclear.Visible = true;
            txtNuclearAdmin.Visible = true;

        }

        private void btnNuclear_Click(object sender, EventArgs e)
        {
            //for (int i = 0;i<countries.Length;i++)
            //{
            //    cbbnuclear.Items.Add(countries[i]);
            //}
            if (txtNuclearAdmin.Text == "12341234")
            {
                lblWrongCode.Visible = false;
                cbbnuclear.Visible = true;
                lblNucCode.Visible = true;
                txtNuclearCode.Visible = true;
                btnNuclearSet.Visible = true;
            }
            else
            {
                lblWrongCode.Text = "NONO";
                lblWrongCode.ForeColor = Color.Red;
            }

        }

        private void btnValidate_Click(object sender, EventArgs e)
        {
            int f = cbbnuclear.SelectedIndex;
            nuclear[f] = txtNuclearCode.Text;
            cbbnuclear.Visible = false;
            lblNucCode.Visible = false;
            txtNuclearCode.Visible = false;
            btnNuclearSet.Visible = false;
            txtNuclearAdmin.Clear();
        }

        private void btnNucValidate_Click(object sender, EventArgs e)
        {
            if(txtNuclearInput.Text == nuclear[cbbNuclearInput.SelectedIndex])
            {
                lblValidOrNot.Visible = true;
                lblValidOrNot.Text = "VALID";
                lblValidOrNot.ForeColor = Color.Red;
                lblValidOrNot.BackColor = Color.Black;
                txtNuclearInput.Clear();
                Thread.Sleep(100);
                lblValidOrNot.Visible = false;
                
            }
            else
            {
                lblValidOrNot.Visible = true;
                lblValidOrNot.Text = "INVALID";
                txtNuclearInput.Clear();
                cbbNuclearInput.ResetText();
                lblValidOrNot.Visible = false;
            }
        }
    }
}
