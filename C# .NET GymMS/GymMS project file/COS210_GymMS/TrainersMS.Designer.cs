namespace COS210_GymMS
{
    partial class TrainersMS
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
            this.cboGender = new System.Windows.Forms.ComboBox();
            this.txtRole = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lblAdminMenu = new System.Windows.Forms.LinkLabel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtExp = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPh = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvTrainers = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrainers)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.cboGender);
            this.groupBox1.Controls.Add(this.txtRole);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.lblAdminMenu);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.btnInsert);
            this.groupBox1.Controls.Add(this.txtAddress);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtExp);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtPh);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtTName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtTID);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(714, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(471, 475);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "TRAINERS INFO : ";
            // 
            // cboGender
            // 
            this.cboGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboGender.FormattingEnabled = true;
            this.cboGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cboGender.Location = new System.Drawing.Point(44, 187);
            this.cboGender.Name = "cboGender";
            this.cboGender.Size = new System.Drawing.Size(163, 28);
            this.cboGender.TabIndex = 19;
            // 
            // txtRole
            // 
            this.txtRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRole.Location = new System.Drawing.Point(45, 250);
            this.txtRole.Name = "txtRole";
            this.txtRole.Size = new System.Drawing.Size(163, 27);
            this.txtRole.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(42, 229);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 18);
            this.label7.TabIndex = 17;
            this.label7.Text = "Role:";
            // 
            // lblAdminMenu
            // 
            this.lblAdminMenu.AutoSize = true;
            this.lblAdminMenu.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblAdminMenu.Location = new System.Drawing.Point(273, 441);
            this.lblAdminMenu.Name = "lblAdminMenu";
            this.lblAdminMenu.Size = new System.Drawing.Size(174, 22);
            this.lblAdminMenu.TabIndex = 16;
            this.lblAdminMenu.TabStop = true;
            this.lblAdminMenu.Text = "Back to Admin Menu";
            this.lblAdminMenu.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblAdminMenu_LinkClicked);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Gainsboro;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(191, 381);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(115, 38);
            this.btnDelete.TabIndex = 15;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Gainsboro;
            this.btnClear.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(332, 349);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(115, 38);
            this.btnClear.TabIndex = 14;
            this.btnClear.Text = "CLEAR";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Gainsboro;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(191, 317);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(115, 38);
            this.btnUpdate.TabIndex = 13;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.BackColor = System.Drawing.Color.Gainsboro;
            this.btnInsert.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsert.Location = new System.Drawing.Point(45, 317);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(115, 38);
            this.btnInsert.TabIndex = 12;
            this.btnInsert.Text = "INSERT";
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(284, 187);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(163, 27);
            this.txtAddress.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(281, 166);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 18);
            this.label6.TabIndex = 10;
            this.label6.Text = "Address:";
            // 
            // txtExp
            // 
            this.txtExp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExp.Location = new System.Drawing.Point(284, 67);
            this.txtExp.Name = "txtExp";
            this.txtExp.Size = new System.Drawing.Size(163, 27);
            this.txtExp.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(281, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 18);
            this.label5.TabIndex = 8;
            this.label5.Text = "Experience:";
            // 
            // txtPh
            // 
            this.txtPh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPh.Location = new System.Drawing.Point(284, 126);
            this.txtPh.Name = "txtPh";
            this.txtPh.Size = new System.Drawing.Size(163, 27);
            this.txtPh.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(281, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "Phone:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(42, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Gender:";
            // 
            // txtTName
            // 
            this.txtTName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTName.Location = new System.Drawing.Point(44, 126);
            this.txtTName.Name = "txtTName";
            this.txtTName.Size = new System.Drawing.Size(163, 27);
            this.txtTName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Trainer Name:";
            // 
            // txtTID
            // 
            this.txtTID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTID.Location = new System.Drawing.Point(45, 67);
            this.txtTID.Name = "txtTID";
            this.txtTID.Size = new System.Drawing.Size(163, 27);
            this.txtTID.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Trainer ID:";
            // 
            // dgvTrainers
            // 
            this.dgvTrainers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTrainers.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dgvTrainers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTrainers.Location = new System.Drawing.Point(12, 12);
            this.dgvTrainers.Name = "dgvTrainers";
            this.dgvTrainers.RowHeadersWidth = 51;
            this.dgvTrainers.RowTemplate.Height = 24;
            this.dgvTrainers.Size = new System.Drawing.Size(684, 475);
            this.dgvTrainers.TabIndex = 2;
            this.dgvTrainers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTrainers_CellContentClick);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Gainsboro;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(44, 381);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(115, 38);
            this.btnSearch.TabIndex = 20;
            this.btnSearch.Text = "SEARCH";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // TrainersMS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(1206, 500);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvTrainers);
            this.Name = "TrainersMS";
            this.Text = "TRAINERS";
            this.Load += new System.EventHandler(this.TrainersMS_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrainers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.LinkLabel lblAdminMenu;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtExp;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPh;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvTrainers;
        private System.Windows.Forms.TextBox txtRole;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboGender;
        private System.Windows.Forms.Button btnSearch;
    }
}