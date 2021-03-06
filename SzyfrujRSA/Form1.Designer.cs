﻿namespace SzyfrujRSA
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNPublic = new System.Windows.Forms.TextBox();
            this.txtE = new System.Windows.Forms.TextBox();
            this.butOpenPublicKey = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNPrivate = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.butOpenPrivateKey = new System.Windows.Forms.Button();
            this.txtD = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.butSaveEncryption = new System.Windows.Forms.Button();
            this.txtEncrypted = new System.Windows.Forms.TextBox();
            this.textFileContent = new System.Windows.Forms.TextBox();
            this.butEncyptText = new System.Windows.Forms.Button();
            this.butReadFile = new System.Windows.Forms.Button();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.textEncyptedFile = new System.Windows.Forms.TextBox();
            this.butDecryptText = new System.Windows.Forms.Button();
            this.butOpenEnc = new System.Windows.Forms.Button();
            this.txtDecrypted = new System.Windows.Forms.TextBox();
            this.butSaveDecryption = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtNPublic);
            this.groupBox1.Controls.Add(this.txtE);
            this.groupBox1.Controls.Add(this.butOpenPublicKey);
            this.groupBox1.Location = new System.Drawing.Point(13, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(775, 59);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Public Key";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(583, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "n";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(313, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "e";
            // 
            // txtNPublic
            // 
            this.txtNPublic.HideSelection = false;
            this.txtNPublic.Location = new System.Drawing.Point(610, 21);
            this.txtNPublic.Name = "txtNPublic";
            this.txtNPublic.Size = new System.Drawing.Size(149, 20);
            this.txtNPublic.TabIndex = 2;
            // 
            // txtE
            // 
            this.txtE.Location = new System.Drawing.Point(340, 21);
            this.txtE.Name = "txtE";
            this.txtE.Size = new System.Drawing.Size(149, 20);
            this.txtE.TabIndex = 1;
            // 
            // butOpenPublicKey
            // 
            this.butOpenPublicKey.Location = new System.Drawing.Point(7, 20);
            this.butOpenPublicKey.Name = "butOpenPublicKey";
            this.butOpenPublicKey.Size = new System.Drawing.Size(240, 23);
            this.butOpenPublicKey.TabIndex = 0;
            this.butOpenPublicKey.Text = "Open (public.key)";
            this.butOpenPublicKey.UseVisualStyleBackColor = true;
            this.butOpenPublicKey.Click += new System.EventHandler(this.butOpenPublicKey_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtNPrivate);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.butOpenPrivateKey);
            this.groupBox2.Controls.Add(this.txtD);
            this.groupBox2.Location = new System.Drawing.Point(12, 74);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(775, 59);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Private Key";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(583, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "n";
            // 
            // txtNPrivate
            // 
            this.txtNPrivate.Location = new System.Drawing.Point(610, 20);
            this.txtNPrivate.Name = "txtNPrivate";
            this.txtNPrivate.Size = new System.Drawing.Size(149, 20);
            this.txtNPrivate.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(313, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "d";
            // 
            // butOpenPrivateKey
            // 
            this.butOpenPrivateKey.Location = new System.Drawing.Point(7, 19);
            this.butOpenPrivateKey.Name = "butOpenPrivateKey";
            this.butOpenPrivateKey.Size = new System.Drawing.Size(240, 23);
            this.butOpenPrivateKey.TabIndex = 5;
            this.butOpenPrivateKey.Text = "Open (private.key)";
            this.butOpenPrivateKey.UseVisualStyleBackColor = true;
            this.butOpenPrivateKey.Click += new System.EventHandler(this.butOpenPrivateKey_Click);
            // 
            // txtD
            // 
            this.txtD.Location = new System.Drawing.Point(340, 20);
            this.txtD.Name = "txtD";
            this.txtD.Size = new System.Drawing.Size(149, 20);
            this.txtD.TabIndex = 6;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.butSaveEncryption);
            this.groupBox3.Controls.Add(this.txtEncrypted);
            this.groupBox3.Controls.Add(this.textFileContent);
            this.groupBox3.Controls.Add(this.butEncyptText);
            this.groupBox3.Controls.Add(this.butReadFile);
            this.groupBox3.Location = new System.Drawing.Point(13, 139);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(774, 109);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Encrypting";
            // 
            // butSaveEncryption
            // 
            this.butSaveEncryption.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.butSaveEncryption.Location = new System.Drawing.Point(529, 76);
            this.butSaveEncryption.Name = "butSaveEncryption";
            this.butSaveEncryption.Size = new System.Drawing.Size(240, 23);
            this.butSaveEncryption.TabIndex = 4;
            this.butSaveEncryption.Text = "Save encyption (text.enc)";
            this.butSaveEncryption.UseVisualStyleBackColor = false;
            this.butSaveEncryption.Click += new System.EventHandler(this.butSaveEncryption_Click);
            // 
            // txtEncrypted
            // 
            this.txtEncrypted.Location = new System.Drawing.Point(254, 50);
            this.txtEncrypted.Name = "txtEncrypted";
            this.txtEncrypted.Size = new System.Drawing.Size(515, 20);
            this.txtEncrypted.TabIndex = 2;
            // 
            // textFileContent
            // 
            this.textFileContent.Location = new System.Drawing.Point(254, 21);
            this.textFileContent.Name = "textFileContent";
            this.textFileContent.Size = new System.Drawing.Size(515, 20);
            this.textFileContent.TabIndex = 1;
            this.textFileContent.Text = " ";
            // 
            // butEncyptText
            // 
            this.butEncyptText.Location = new System.Drawing.Point(7, 49);
            this.butEncyptText.Name = "butEncyptText";
            this.butEncyptText.Size = new System.Drawing.Size(240, 23);
            this.butEncyptText.TabIndex = 3;
            this.butEncyptText.Text = "Encrypt text";
            this.butEncyptText.UseVisualStyleBackColor = true;
            this.butEncyptText.Click += new System.EventHandler(this.butEncyptText_Click);
            // 
            // butReadFile
            // 
            this.butReadFile.Location = new System.Drawing.Point(7, 20);
            this.butReadFile.Name = "butReadFile";
            this.butReadFile.Size = new System.Drawing.Size(240, 23);
            this.butReadFile.TabIndex = 0;
            this.butReadFile.Text = "Read (text.txt)";
            this.butReadFile.UseVisualStyleBackColor = true;
            this.butReadFile.Click += new System.EventHandler(this.butReadFile_Click);
            // 
            // txtLog
            // 
            this.txtLog.BackColor = System.Drawing.Color.Black;
            this.txtLog.ForeColor = System.Drawing.Color.Yellow;
            this.txtLog.Location = new System.Drawing.Point(12, 364);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLog.Size = new System.Drawing.Size(776, 137);
            this.txtLog.TabIndex = 3;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.butSaveDecryption);
            this.groupBox4.Controls.Add(this.textEncyptedFile);
            this.groupBox4.Controls.Add(this.butDecryptText);
            this.groupBox4.Controls.Add(this.butOpenEnc);
            this.groupBox4.Controls.Add(this.txtDecrypted);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.471698F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(12, 254);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(775, 104);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Decrypting";
            // 
            // textEncyptedFile
            // 
            this.textEncyptedFile.Location = new System.Drawing.Point(255, 20);
            this.textEncyptedFile.Name = "textEncyptedFile";
            this.textEncyptedFile.Size = new System.Drawing.Size(515, 20);
            this.textEncyptedFile.TabIndex = 3;
            // 
            // butDecryptText
            // 
            this.butDecryptText.Location = new System.Drawing.Point(8, 48);
            this.butDecryptText.Name = "butDecryptText";
            this.butDecryptText.Size = new System.Drawing.Size(240, 23);
            this.butDecryptText.TabIndex = 2;
            this.butDecryptText.Text = "Decrypt text";
            this.butDecryptText.UseVisualStyleBackColor = true;
            this.butDecryptText.Click += new System.EventHandler(this.button1_Click);
            // 
            // butOpenEnc
            // 
            this.butOpenEnc.Location = new System.Drawing.Point(8, 19);
            this.butOpenEnc.Name = "butOpenEnc";
            this.butOpenEnc.Size = new System.Drawing.Size(240, 23);
            this.butOpenEnc.TabIndex = 1;
            this.butOpenEnc.Text = "Open (text.enc)";
            this.butOpenEnc.UseVisualStyleBackColor = true;
            this.butOpenEnc.Click += new System.EventHandler(this.butOpenEnc_Click);
            // 
            // txtDecrypted
            // 
            this.txtDecrypted.Location = new System.Drawing.Point(255, 49);
            this.txtDecrypted.Name = "txtDecrypted";
            this.txtDecrypted.Size = new System.Drawing.Size(515, 20);
            this.txtDecrypted.TabIndex = 0;
            // 
            // butSaveDecryption
            // 
            this.butSaveDecryption.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.butSaveDecryption.Location = new System.Drawing.Point(530, 75);
            this.butSaveDecryption.Name = "butSaveDecryption";
            this.butSaveDecryption.Size = new System.Drawing.Size(240, 23);
            this.butSaveDecryption.TabIndex = 4;
            this.butSaveDecryption.Text = "Save decryption (text.dec)";
            this.butSaveDecryption.UseVisualStyleBackColor = false;
            this.butSaveDecryption.Click += new System.EventHandler(this.butSaveDecryption_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 507);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "SzyfrujRSA";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }        

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button butOpenPublicKey;
        private System.Windows.Forms.TextBox txtNPublic;
        private System.Windows.Forms.TextBox txtE;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNPrivate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button butOpenPrivateKey;
        private System.Windows.Forms.TextBox txtD;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textFileContent;
        private System.Windows.Forms.Button butReadFile;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.TextBox txtEncrypted;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtDecrypted;
        private System.Windows.Forms.Button butSaveEncryption;
        private System.Windows.Forms.Button butEncyptText;
        private System.Windows.Forms.TextBox textEncyptedFile;
        private System.Windows.Forms.Button butDecryptText;
        private System.Windows.Forms.Button butOpenEnc;
        private System.Windows.Forms.Button butSaveDecryption;
    }
}

