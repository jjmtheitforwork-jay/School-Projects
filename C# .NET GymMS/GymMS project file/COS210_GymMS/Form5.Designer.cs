namespace COS210_GymMS
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.dgvTrainingCourse = new System.Windows.Forms.DataGridView();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnEnroll = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrainingCourse)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTrainingCourse
            // 
            this.dgvTrainingCourse.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTrainingCourse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTrainingCourse.Location = new System.Drawing.Point(12, 12);
            this.dgvTrainingCourse.Name = "dgvTrainingCourse";
            this.dgvTrainingCourse.RowHeadersWidth = 51;
            this.dgvTrainingCourse.RowTemplate.Height = 24;
            this.dgvTrainingCourse.Size = new System.Drawing.Size(918, 329);
            this.dgvTrainingCourse.TabIndex = 0;
            // 
            // btnHome
            // 
            this.btnHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.Location = new System.Drawing.Point(59, 371);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(186, 47);
            this.btnHome.TabIndex = 4;
            this.btnHome.Text = "BACK";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnEnroll
            // 
            this.btnEnroll.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnroll.Location = new System.Drawing.Point(711, 371);
            this.btnEnroll.Name = "btnEnroll";
            this.btnEnroll.Size = new System.Drawing.Size(186, 47);
            this.btnEnroll.TabIndex = 6;
            this.btnEnroll.Text = "NEXT";
            this.btnEnroll.UseVisualStyleBackColor = true;
            this.btnEnroll.Click += new System.EventHandler(this.btnEnroll_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(942, 450);
            this.Controls.Add(this.btnEnroll);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.dgvTrainingCourse);
            this.Name = "Form5";
            this.Text = "Training Course List";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrainingCourse)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTrainingCourse;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnEnroll;
    }
}