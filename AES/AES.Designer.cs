namespace AES
{
    partial class AES
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AES));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.enOutTxt = new System.Windows.Forms.TextBox();
            this.eIVtxt = new System.Windows.Forms.TextBox();
            this.eKeyTxt = new System.Windows.Forms.TextBox();
            this.ePlainInTxt = new System.Windows.Forms.TextBox();
            this.encBtn = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.decOutTxt = new System.Windows.Forms.TextBox();
            this.dIVtxt = new System.Windows.Forms.TextBox();
            this.dKeyTxt = new System.Windows.Forms.TextBox();
            this.dHexInTxt = new System.Windows.Forms.TextBox();
            this.decBtn = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(2, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(549, 270);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.enOutTxt);
            this.tabPage1.Controls.Add(this.eIVtxt);
            this.tabPage1.Controls.Add(this.eKeyTxt);
            this.tabPage1.Controls.Add(this.ePlainInTxt);
            this.tabPage1.Controls.Add(this.encBtn);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(541, 244);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Encrypt";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Encrypted Hex String";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Initialization Vector";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Key";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Input Text";
            // 
            // enOutTxt
            // 
            this.enOutTxt.Location = new System.Drawing.Point(6, 188);
            this.enOutTxt.Multiline = true;
            this.enOutTxt.Name = "enOutTxt";
            this.enOutTxt.Size = new System.Drawing.Size(527, 50);
            this.enOutTxt.TabIndex = 9;
            // 
            // eIVtxt
            // 
            this.eIVtxt.Location = new System.Drawing.Point(6, 113);
            this.eIVtxt.Name = "eIVtxt";
            this.eIVtxt.Size = new System.Drawing.Size(527, 20);
            this.eIVtxt.TabIndex = 8;
            this.eIVtxt.Text = "minerals&royalty";
            // 
            // eKeyTxt
            // 
            this.eKeyTxt.Location = new System.Drawing.Point(6, 65);
            this.eKeyTxt.Name = "eKeyTxt";
            this.eKeyTxt.Size = new System.Drawing.Size(527, 20);
            this.eKeyTxt.TabIndex = 7;
            this.eKeyTxt.Text = "transparentcomplaintprocedure301";
            // 
            // ePlainInTxt
            // 
            this.ePlainInTxt.Location = new System.Drawing.Point(6, 19);
            this.ePlainInTxt.Name = "ePlainInTxt";
            this.ePlainInTxt.Size = new System.Drawing.Size(527, 20);
            this.ePlainInTxt.TabIndex = 6;
            // 
            // encBtn
            // 
            this.encBtn.Location = new System.Drawing.Point(227, 143);
            this.encBtn.Name = "encBtn";
            this.encBtn.Size = new System.Drawing.Size(75, 23);
            this.encBtn.TabIndex = 5;
            this.encBtn.Text = "Encrypt";
            this.encBtn.UseVisualStyleBackColor = true;
            this.encBtn.Click += new System.EventHandler(this.encBtn_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.decOutTxt);
            this.tabPage2.Controls.Add(this.dIVtxt);
            this.tabPage2.Controls.Add(this.dKeyTxt);
            this.tabPage2.Controls.Add(this.dHexInTxt);
            this.tabPage2.Controls.Add(this.decBtn);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(541, 244);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Decrypt";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Decrypted Hex String";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Initialization Vector";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 76);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(25, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Key";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(125, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Encrypter Hex Input Text";
            // 
            // decOutTxt
            // 
            this.decOutTxt.Location = new System.Drawing.Point(6, 218);
            this.decOutTxt.Name = "decOutTxt";
            this.decOutTxt.Size = new System.Drawing.Size(527, 20);
            this.decOutTxt.TabIndex = 18;
            // 
            // dIVtxt
            // 
            this.dIVtxt.Location = new System.Drawing.Point(6, 140);
            this.dIVtxt.Name = "dIVtxt";
            this.dIVtxt.Size = new System.Drawing.Size(527, 20);
            this.dIVtxt.TabIndex = 17;
            this.dIVtxt.Text = "minerals&royalty";
            // 
            // dKeyTxt
            // 
            this.dKeyTxt.Location = new System.Drawing.Point(6, 92);
            this.dKeyTxt.Name = "dKeyTxt";
            this.dKeyTxt.Size = new System.Drawing.Size(527, 20);
            this.dKeyTxt.TabIndex = 16;
            this.dKeyTxt.Text = "transparentcomplaintprocedure301";
            // 
            // dHexInTxt
            // 
            this.dHexInTxt.Location = new System.Drawing.Point(6, 19);
            this.dHexInTxt.Multiline = true;
            this.dHexInTxt.Name = "dHexInTxt";
            this.dHexInTxt.Size = new System.Drawing.Size(527, 50);
            this.dHexInTxt.TabIndex = 15;
            // 
            // decBtn
            // 
            this.decBtn.Location = new System.Drawing.Point(227, 172);
            this.decBtn.Name = "decBtn";
            this.decBtn.Size = new System.Drawing.Size(75, 23);
            this.decBtn.TabIndex = 14;
            this.decBtn.Text = "Decrypt";
            this.decBtn.UseVisualStyleBackColor = true;
            this.decBtn.Click += new System.EventHandler(this.decBtn_Click);
            // 
            // AES
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 275);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AES";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AES";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox enOutTxt;
        private System.Windows.Forms.TextBox eIVtxt;
        private System.Windows.Forms.TextBox eKeyTxt;
        private System.Windows.Forms.TextBox ePlainInTxt;
        private System.Windows.Forms.Button encBtn;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox decOutTxt;
        private System.Windows.Forms.TextBox dIVtxt;
        private System.Windows.Forms.TextBox dKeyTxt;
        private System.Windows.Forms.TextBox dHexInTxt;
        private System.Windows.Forms.Button decBtn;

    }
}

