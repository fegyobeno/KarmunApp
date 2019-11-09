using System;
using System.Windows.Forms;

namespace KarMun_ShitApp
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            button1.Visible = false;
            grbTotal.Visible = false;
            lblFrance.Text = Form1.nuclear[0];
            lblPRC.Text = Form1.nuclear[1];
            lblRussia.Text = Form1.nuclear[2];
            lblUK.Text = Form1.nuclear[3];
            lblUSA.Text = Form1.nuclear[4];
            lblItaly.Text = Form1.nuclear[5];
            lblNether.Text = Form1.nuclear[6];
            lblSwitz.Text = Form1.nuclear[7];
            lblSweden.Text = Form1.nuclear[8];
            lblCanada.Text = Form1.nuclear[9];
            lblUAE.Text = Form1.nuclear[10];
            lblIran.Text = Form1.nuclear[11];
            lblKorea.Text = Form1.nuclear[12];
            lblGermany.Text = Form1.nuclear[13];
            lblJapan.Text = Form1.nuclear[14];
        }

        private void txtFranceMoney_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click(sender, e);
            }
        }
        private void txtPRCMoney_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click(sender, e);
            }
        }
        private void txtRussiaMoney_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click(sender, e);
            }
        }
        private void txtUKMoney_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click(sender, e);
            }
        }
        private void txtUSAMoney_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click(sender, e);
            }
        }
        private void txtItalyMoney_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click(sender, e);
            }
        }
        private void txtNetherMoney_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click(sender, e);
            }
        }
        private void txtSwitzMoney_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click(sender, e);
            }
        }
        private void txtSwedenMoney_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click(sender, e);
            }
        }
        private void txtCanadaMoney_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click(sender, e);
            }
        }
        private void txtUAEMoney_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click(sender, e);
            }
        }
        private void txtIranMoney_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click(sender, e);
            }
        }
        private void txtKoreaMoney_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click(sender, e);
            }
        }
        private void txtGermanyMoney_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click(sender, e);
            }
        }
        private void txtJapanMoney_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click(sender, e);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtFranceMoney.Text != "")
            {
                Form1.nuclear[0] = txtFranceMoney.Text;
                lblFrance.Text = Form1.nuclear[0];                
            }
            if (txtPRCMoney.Text != "")
            {
                Form1.nuclear[1] = txtPRCMoney.Text;
                lblPRC.Text = Form1.nuclear[1];
            }
            if (txtRussiaMoney.Text != "")
            {
                Form1.nuclear[2] = txtRussiaMoney.Text;
                lblRussia.Text = Form1.nuclear[2];
            }
            if (txtUKMoney.Text != "")
            {
                Form1.nuclear[3] = txtUKMoney.Text;
                lblUK.Text = Form1.nuclear[3];
            }
            if (txtUSAMoney.Text != "")
            {
                Form1.nuclear[4] = txtUSAMoney.Text;
                lblUSA.Text = Form1.nuclear[4];
            }
            if (txtItalyMoney.Text != "")
            {
                Form1.nuclear[5] = txtItalyMoney.Text;
                lblItaly.Text = Form1.nuclear[5];
            }
            if (txtNetherMoney.Text != "")
            {
                Form1.nuclear[6] = txtNetherMoney.Text;
                lblNether.Text = Form1.nuclear[6];
            }
            if (txtSwitzMoney.Text != "")
            {
                Form1.nuclear[7] = txtSwitzMoney.Text;
                lblSwitz.Text = Form1.nuclear[7];
            }
            if (txtSwedenMoney.Text != "")
            {
                Form1.nuclear[8] = txtSwedenMoney.Text;
                lblSweden.Text = Form1.nuclear[8];
            }
            if (txtCanadaMoney.Text != "")
            {
                Form1.nuclear[9] = txtCanadaMoney.Text;
                lblCanada.Text = Form1.nuclear[9];
            }
            if (txtUAEMoney.Text != "")
            {
                Form1.nuclear[10] = txtUAEMoney.Text;
                lblUAE.Text = Form1.nuclear[10];
            }
            if (txtIranMoney.Text != "")
            {
                Form1.nuclear[11] = txtIranMoney.Text;
                lblIran.Text = Form1.nuclear[11];
            }
            if (txtKoreaMoney.Text != "")
            {
                Form1.nuclear[12] = txtKoreaMoney.Text;
                lblKorea.Text = Form1.nuclear[12];
            }
            if (txtGermanyMoney.Text != "")
            {
                Form1.nuclear[13] = txtGermanyMoney.Text;
                lblGermany.Text = Form1.nuclear[13];
            }
            if (txtJapanMoney.Text != "")
            {
                Form1.nuclear[14] = txtJapanMoney.Text;
                lblJapan.Text = Form1.nuclear[14];
            }
            






        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if(txtAdmin.Text == "12345678")
            {
                grbTotal.Visible = true;
                txtAdmin.Clear();
            }
        }
    }
}
