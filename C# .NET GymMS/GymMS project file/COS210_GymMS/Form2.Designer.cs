namespace COS210_GymMS
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkPsw = new System.Windows.Forms.CheckBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblRegister = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPsw = new System.Windows.Forms.TextBox();
            this.txtMUsn = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.chkPsw);
            this.groupBox1.Controls.Add(this.btnBack);
            this.groupBox1.Controls.Add(this.lblRegister);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnLogin);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtPsw);
            this.groupBox1.Controls.Add(this.txtMUsn);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(427, 435);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Welcome Back";
            // 
            // chkPsw
            // 
            this.chkPsw.AutoSize = true;
            this.chkPsw.Font = new System.Drawing.Font("Microsoft Tai Le", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkPsw.Location = new System.Drawing.Point(106, 225);
            this.chkPsw.Name = "chkPsw";
            this.chkPsw.Size = new System.Drawing.Size(124, 20);
            this.chkPsw.TabIndex = 8;
            this.chkPsw.Text = "Show Password";
            this.chkPsw.UseVisualStyleBackColor = true;
            this.chkPsw.CheckedChanged += new System.EventHandler(this.chkPsw_CheckedChanged);
            // 
            // btnBack
            // 
            this.btnBack.ForeColor = System.Drawing.Color.Black;
            this.btnBack.Location = new System.Drawing.Point(20, 370);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(57, 33);
            this.btnBack.TabIndex = 7;
            this.btnBack.Text = "<<";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblRegister
            // 
            this.lblRegister.AutoSize = true;
            this.lblRegister.Font = new System.Drawing.Font("Microsoft Tai Le", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegister.Location = new System.Drawing.Point(229, 380);
            this.lblRegister.Name = "lblRegister";
            this.lblRegister.Size = new System.Drawing.Size(138, 16);
            this.lblRegister.TabIndex = 6;
            this.lblRegister.TabStop = true;
            this.lblRegister.Text = "Register membership";
            this.lblRegister.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblRegister_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(148, 380);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "New here? ";
            // 
            // btnLogin
            // 
            this.btnLogin.ForeColor = System.Drawing.Color.Black;
            this.btnLogin.Location = new System.Drawing.Point(127, 282);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(168, 41);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "LOGIN";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "LOGIN YOUR USER ACCOUNT";
            // 
            // txtPsw
            // 
            this.txtPsw.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtPsw.Location = new System.Drawing.Point(106, 185);
            this.txtPsw.Name = "txtPsw";
            this.txtPsw.Size = new System.Drawing.Size(206, 33);
            this.txtPsw.TabIndex = 1;
            this.txtPsw.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPsw.UseWaitCursor = true;
            // 
            // txtMUsn
            // 
            this.txtMUsn.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtMUsn.Location = new System.Drawing.Point(106, 123);
            this.txtMUsn.Name = "txtMUsn";
            this.txtMUsn.Size = new System.Drawing.Size(206, 33);
            this.txtMUsn.TabIndex = 0;
            this.txtMUsn.Text = "Username";
            this.txtMUsn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtMUsn.UseWaitCursor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form2";
            this.Text = "USER LOGIN";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPsw;
        private System.Windows.Forms.TextBox txtMUsn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.LinkLabel lblRegister;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.CheckBox chkPsw;
    }
}