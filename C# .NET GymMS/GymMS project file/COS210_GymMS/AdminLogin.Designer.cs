namespace COS210_GymMS
{
    partial class AdminLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminLogin));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPsw = new System.Windows.Forms.TextBox();
            this.txtAdmN = new System.Windows.Forms.TextBox();
            this.chkPsw = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.chkPsw);
            this.groupBox1.Controls.Add(this.btnBack);
            this.groupBox1.Controls.Add(this.btnLogin);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtPsw);
            this.groupBox1.Controls.Add(this.txtAdmN);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(423, 434);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Welcome Back";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnBack
            // 
            this.btnBack.ForeColor = System.Drawing.Color.Black;
            this.btnBack.Location = new System.Drawing.Point(22, 377);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(57, 33);
            this.btnBack.TabIndex = 8;
            this.btnBack.Text = "<<";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.ForeColor = System.Drawing.Color.Black;
            this.btnLogin.Location = new System.Drawing.Point(139, 294);
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
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(66, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(310, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "LOGIN YOUR ADMIN ACCOUNT";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtPsw
            // 
            this.txtPsw.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtPsw.Location = new System.Drawing.Point(114, 189);
            this.txtPsw.Name = "txtPsw";
            this.txtPsw.Size = new System.Drawing.Size(206, 33);
            this.txtPsw.TabIndex = 1;
            this.txtPsw.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPsw.UseWaitCursor = true;
            // 
            // txtAdmN
            // 
            this.txtAdmN.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtAdmN.Location = new System.Drawing.Point(114, 127);
            this.txtAdmN.Name = "txtAdmN";
            this.txtAdmN.Size = new System.Drawing.Size(206, 33);
            this.txtAdmN.TabIndex = 0;
            this.txtAdmN.Text = "Admin name";
            this.txtAdmN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtAdmN.UseWaitCursor = true;
            // 
            // chkPsw
            // 
            this.chkPsw.AutoSize = true;
            this.chkPsw.Font = new System.Drawing.Font("Microsoft Tai Le", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkPsw.Location = new System.Drawing.Point(114, 228);
            this.chkPsw.Name = "chkPsw";
            this.chkPsw.Size = new System.Drawing.Size(124, 20);
            this.chkPsw.TabIndex = 10;
            this.chkPsw.Text = "Show Password";
            this.chkPsw.UseVisualStyleBackColor = true;
            this.chkPsw.CheckedChanged += new System.EventHandler(this.chkPsw_CheckedChanged);
            // 
            // AdminLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "AdminLogin";
            this.Text = "ADMIN LOGIN";
            this.Load += new System.EventHandler(this.AdminLogin_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPsw;
        private System.Windows.Forms.TextBox txtAdmN;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.CheckBox chkPsw;
    }
}