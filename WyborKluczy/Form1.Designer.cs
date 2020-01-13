namespace WyborKluczy
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.txtP = new System.Windows.Forms.TextBox();
            this.txtQ = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMax = new System.Windows.Forms.TextBox();
            this.btnGenerateP = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnGenerateQ = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtN = new System.Windows.Forms.TextBox();
            this.btnCalculateN = new System.Windows.Forms.Button();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.txtTot = new System.Windows.Forms.TextBox();
            this.btnCalculatePhiN = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtE = new System.Windows.Forms.TextBox();
            this.btnGenerateE = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtD = new System.Windows.Forms.TextBox();
            this.btnCalculateD = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtPublicKey = new System.Windows.Forms.TextBox();
            this.txtPrivateKey = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtP
            // 
            this.txtP.Location = new System.Drawing.Point(75, 48);
            this.txtP.Name = "txtP";
            this.txtP.Size = new System.Drawing.Size(149, 20);
            this.txtP.TabIndex = 0;
            // 
            // txtQ
            // 
            this.txtQ.Location = new System.Drawing.Point(485, 48);
            this.txtQ.Name = "txtQ";
            this.txtQ.Size = new System.Drawing.Size(149, 20);
            this.txtQ.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "10^9";
            // 
            // txtMax
            // 
            this.txtMax.Location = new System.Drawing.Point(75, 10);
            this.txtMax.Name = "txtMax";
            this.txtMax.Size = new System.Drawing.Size(149, 20);
            this.txtMax.TabIndex = 4;
            this.txtMax.Text = "1000000000";
            // 
            // btnGenerateP
            // 
            this.btnGenerateP.Location = new System.Drawing.Point(241, 47);
            this.btnGenerateP.Name = "btnGenerateP";
            this.btnGenerateP.Size = new System.Drawing.Size(132, 23);
            this.btnGenerateP.TabIndex = 5;
            this.btnGenerateP.Text = "Generate p";
            this.btnGenerateP.UseVisualStyleBackColor = true;
            this.btnGenerateP.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Prime p";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(420, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Prime q";
            // 
            // btnGenerateQ
            // 
            this.btnGenerateQ.Location = new System.Drawing.Point(656, 47);
            this.btnGenerateQ.Name = "btnGenerateQ";
            this.btnGenerateQ.Size = new System.Drawing.Size(132, 23);
            this.btnGenerateQ.TabIndex = 8;
            this.btnGenerateQ.Text = "Generate q";
            this.btnGenerateQ.UseVisualStyleBackColor = true;
            this.btnGenerateQ.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "n";
            // 
            // txtN
            // 
            this.txtN.Location = new System.Drawing.Point(75, 86);
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(149, 20);
            this.txtN.TabIndex = 10;
            // 
            // btnCalculateN
            // 
            this.btnCalculateN.Location = new System.Drawing.Point(241, 85);
            this.btnCalculateN.Name = "btnCalculateN";
            this.btnCalculateN.Size = new System.Drawing.Size(132, 23);
            this.btnCalculateN.TabIndex = 11;
            this.btnCalculateN.Text = "Calculate n";
            this.btnCalculateN.UseVisualStyleBackColor = true;
            this.btnCalculateN.Click += new System.EventHandler(this.btnCalculateN_Click);
            // 
            // txtLog
            // 
            this.txtLog.BackColor = System.Drawing.Color.Black;
            this.txtLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLog.ForeColor = System.Drawing.Color.Yellow;
            this.txtLog.Location = new System.Drawing.Point(12, 255);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLog.Size = new System.Drawing.Size(776, 191);
            this.txtLog.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(420, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "Phi(n)";
            // 
            // txtTot
            // 
            this.txtTot.Location = new System.Drawing.Point(485, 86);
            this.txtTot.Name = "txtTot";
            this.txtTot.Size = new System.Drawing.Size(149, 20);
            this.txtTot.TabIndex = 14;
            // 
            // btnCalculatePhiN
            // 
            this.btnCalculatePhiN.Location = new System.Drawing.Point(656, 85);
            this.btnCalculatePhiN.Name = "btnCalculatePhiN";
            this.btnCalculatePhiN.Size = new System.Drawing.Size(132, 23);
            this.btnCalculatePhiN.TabIndex = 15;
            this.btnCalculatePhiN.Text = "Calculate Phi(n)";
            this.btnCalculatePhiN.UseVisualStyleBackColor = true;
            this.btnCalculatePhiN.Click += new System.EventHandler(this.btnCalculatePhiN_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 127);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 15);
            this.label6.TabIndex = 16;
            this.label6.Text = "e";
            // 
            // txtE
            // 
            this.txtE.Location = new System.Drawing.Point(75, 124);
            this.txtE.Name = "txtE";
            this.txtE.Size = new System.Drawing.Size(149, 20);
            this.txtE.TabIndex = 17;
            // 
            // btnGenerateE
            // 
            this.btnGenerateE.Location = new System.Drawing.Point(241, 123);
            this.btnGenerateE.Name = "btnGenerateE";
            this.btnGenerateE.Size = new System.Drawing.Size(132, 23);
            this.btnGenerateE.TabIndex = 18;
            this.btnGenerateE.Text = "Generate e (Ran)";
            this.btnGenerateE.UseVisualStyleBackColor = true;
            this.btnGenerateE.Click += new System.EventHandler(this.btnGenerateE_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(420, 127);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(14, 15);
            this.label7.TabIndex = 19;
            this.label7.Text = "d";
            // 
            // txtD
            // 
            this.txtD.Location = new System.Drawing.Point(485, 124);
            this.txtD.Name = "txtD";
            this.txtD.Size = new System.Drawing.Size(149, 20);
            this.txtD.TabIndex = 20;
            // 
            // btnCalculateD
            // 
            this.btnCalculateD.Location = new System.Drawing.Point(656, 123);
            this.btnCalculateD.Name = "btnCalculateD";
            this.btnCalculateD.Size = new System.Drawing.Size(131, 23);
            this.btnCalculateD.TabIndex = 21;
            this.btnCalculateD.Text = "Calculate d";
            this.btnCalculateD.UseVisualStyleBackColor = true;
            this.btnCalculateD.Click += new System.EventHandler(this.btnCalculateD_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 15);
            this.label8.TabIndex = 22;
            this.label8.Text = "Public Key {e,n}";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(419, 28);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 15);
            this.label9.TabIndex = 23;
            this.label9.Text = "Private Key {d,n}";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.txtPrivateKey);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtPublicKey);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Location = new System.Drawing.Point(12, 168);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 81);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Generated Keys";
            // 
            // txtPublicKey
            // 
            this.txtPublicKey.Enabled = false;
            this.txtPublicKey.ForeColor = System.Drawing.SystemColors.Info;
            this.txtPublicKey.Location = new System.Drawing.Point(106, 25);
            this.txtPublicKey.Name = "txtPublicKey";
            this.txtPublicKey.Size = new System.Drawing.Size(240, 20);
            this.txtPublicKey.TabIndex = 24;
            // 
            // txtPrivateKey
            // 
            this.txtPrivateKey.Enabled = false;
            this.txtPrivateKey.ForeColor = System.Drawing.SystemColors.Info;
            this.txtPrivateKey.Location = new System.Drawing.Point(520, 25);
            this.txtPrivateKey.Name = "txtPrivateKey";
            this.txtPrivateKey.Size = new System.Drawing.Size(240, 20);
            this.txtPrivateKey.TabIndex = 25;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(106, 52);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(240, 23);
            this.button1.TabIndex = 26;
            this.button1.Text = "Save (public.key)";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(520, 51);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(240, 23);
            this.button2.TabIndex = 27;
            this.button2.Text = "Save (private.key)";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCalculateD);
            this.Controls.Add(this.txtD);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnGenerateE);
            this.Controls.Add(this.txtE);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnCalculatePhiN);
            this.Controls.Add(this.txtTot);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.btnCalculateN);
            this.Controls.Add(this.txtN);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnGenerateQ);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnGenerateP);
            this.Controls.Add(this.txtMax);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtQ);
            this.Controls.Add(this.txtP);
            this.Name = "Form1";
            this.Text = "WyborKluczy";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtP;
        private System.Windows.Forms.TextBox txtQ;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMax;
        private System.Windows.Forms.Button btnGenerateP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnGenerateQ;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtN;
        private System.Windows.Forms.Button btnCalculateN;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTot;
        private System.Windows.Forms.Button btnCalculatePhiN;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtE;
        private System.Windows.Forms.Button btnGenerateE;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtD;
        private System.Windows.Forms.Button btnCalculateD;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtPrivateKey;
        private System.Windows.Forms.TextBox txtPublicKey;
    }
}

