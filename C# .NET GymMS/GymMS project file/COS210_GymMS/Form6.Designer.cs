namespace COS210_GymMS
{
    partial class Form6
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form6));
            this.btnEnroll = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.dgvTrainers = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrainers)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEnroll
            // 
            this.btnEnroll.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnroll.Location = new System.Drawing.Point(739, 371);
            this.btnEnroll.Name = "btnEnroll";
            this.btnEnroll.Size = new System.Drawing.Size(168, 47);
            this.btnEnroll.TabIndex = 11;
            this.btnEnroll.Text = "TO ENROLL";
            this.btnEnroll.UseVisualStyleBackColor = true;
            this.btnEnroll.Click += new System.EventHandler(this.btnEnroll_Click);
            // 
            // btnHome
            // 
            this.btnHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.Location = new System.Drawing.Point(39, 371);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(162, 47);
            this.btnHome.TabIndex = 9;
            this.btnHome.Text = "BACK";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // dgvTrainers
            // 
            this.dgvTrainers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTrainers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTrainers.Location = new System.Drawing.Point(12, 12);
            this.dgvTrainers.Name = "dgvTrainers";
            this.dgvTrainers.RowHeadersWidth = 51;
            this.dgvTrainers.RowTemplate.Height = 24;
            this.dgvTrainers.Size = new System.Drawing.Size(918, 327);
            this.dgvTrainers.TabIndex = 8;
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(942, 450);
            this.Controls.Add(this.btnEnroll);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.dgvTrainers);
            this.Name = "Form6";
            this.Text = "Trainer List";
            this.Load += new System.EventHandler(this.Form6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrainers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnEnroll;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.DataGridView dgvTrainers;
    }
}