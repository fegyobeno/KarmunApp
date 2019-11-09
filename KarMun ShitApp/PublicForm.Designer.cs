namespace KarMun_ShitApp
{
    partial class PublicForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.gbbWar = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.btnWarSubmit = new System.Windows.Forms.Button();
            this.gbbMoney = new System.Windows.Forms.GroupBox();
            this.lblCountry = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblAvaiMoney = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblCurrGdp = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gbbWar.SuspendLayout();
            this.gbbMoney.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(33, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Country:";
            // 
            // gbbWar
            // 
            this.gbbWar.BackColor = System.Drawing.Color.Red;
            this.gbbWar.Controls.Add(this.btnWarSubmit);
            this.gbbWar.Controls.Add(this.comboBox3);
            this.gbbWar.Controls.Add(this.comboBox2);
            this.gbbWar.Controls.Add(this.label5);
            this.gbbWar.Controls.Add(this.label4);
            this.gbbWar.Controls.Add(this.label3);
            this.gbbWar.Controls.Add(this.comboBox1);
            this.gbbWar.Location = new System.Drawing.Point(57, 233);
            this.gbbWar.Name = "gbbWar";
            this.gbbWar.Size = new System.Drawing.Size(272, 185);
            this.gbbWar.TabIndex = 2;
            this.gbbWar.TabStop = false;
            this.gbbWar.Text = "WAR";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(145, 19);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(6, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Select country:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(6, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Select type:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(6, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "Select commitment:";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "normal attack",
            "cyber attack",
            "nuclear attack"});
            this.comboBox2.Location = new System.Drawing.Point(145, 55);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 4;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "very committed (100%)",
            "committed (80%)",
            "quite committed (60%)",
            "barely committed (50%)"});
            this.comboBox3.Location = new System.Drawing.Point(145, 94);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 21);
            this.comboBox3.TabIndex = 5;
            // 
            // btnWarSubmit
            // 
            this.btnWarSubmit.Location = new System.Drawing.Point(145, 134);
            this.btnWarSubmit.Name = "btnWarSubmit";
            this.btnWarSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnWarSubmit.TabIndex = 6;
            this.btnWarSubmit.Text = "SUBMIT";
            this.btnWarSubmit.UseVisualStyleBackColor = true;
            // 
            // gbbMoney
            // 
            this.gbbMoney.BackColor = System.Drawing.Color.CornflowerBlue;
            this.gbbMoney.Controls.Add(this.lblCurrGdp);
            this.gbbMoney.Controls.Add(this.label8);
            this.gbbMoney.Controls.Add(this.lblAvaiMoney);
            this.gbbMoney.Controls.Add(this.label6);
            this.gbbMoney.Controls.Add(this.lblCountry);
            this.gbbMoney.Controls.Add(this.label1);
            this.gbbMoney.Location = new System.Drawing.Point(57, 50);
            this.gbbMoney.Name = "gbbMoney";
            this.gbbMoney.Size = new System.Drawing.Size(272, 142);
            this.gbbMoney.TabIndex = 3;
            this.gbbMoney.TabStop = false;
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblCountry.Location = new System.Drawing.Point(170, 31);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(58, 16);
            this.lblCountry.TabIndex = 1;
            this.lblCountry.Text = "country";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(33, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 16);
            this.label6.TabIndex = 2;
            this.label6.Text = "Available money:";
            // 
            // lblAvaiMoney
            // 
            this.lblAvaiMoney.AutoSize = true;
            this.lblAvaiMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblAvaiMoney.Location = new System.Drawing.Point(170, 67);
            this.lblAvaiMoney.Name = "lblAvaiMoney";
            this.lblAvaiMoney.Size = new System.Drawing.Size(54, 16);
            this.lblAvaiMoney.TabIndex = 3;
            this.lblAvaiMoney.Text = "money";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(33, 106);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 16);
            this.label8.TabIndex = 4;
            this.label8.Text = "Curent GDP:";
            // 
            // lblCurrGdp
            // 
            this.lblCurrGdp.AutoSize = true;
            this.lblCurrGdp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblCurrGdp.Location = new System.Drawing.Point(170, 106);
            this.lblCurrGdp.Name = "lblCurrGdp";
            this.lblCurrGdp.Size = new System.Drawing.Size(35, 16);
            this.lblCurrGdp.TabIndex = 5;
            this.lblCurrGdp.Text = "gdp";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.groupBox1.Location = new System.Drawing.Point(415, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(325, 368);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "International relationships:";
            // 
            // PublicForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(800, 488);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbbMoney);
            this.Controls.Add(this.gbbWar);
            this.Name = "PublicForm";
            this.gbbWar.ResumeLayout(false);
            this.gbbWar.PerformLayout();
            this.gbbMoney.ResumeLayout(false);
            this.gbbMoney.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbbWar;
        private System.Windows.Forms.Button btnWarSubmit;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox gbbMoney;
        private System.Windows.Forms.Label lblCurrGdp;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblAvaiMoney;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}