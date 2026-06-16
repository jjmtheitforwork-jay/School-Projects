namespace COS210_GymMS
{
    partial class Form8
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form8));
            this.btnTCourse = new System.Windows.Forms.Button();
            this.btnTrainers = new System.Windows.Forms.Button();
            this.btnEnroll = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTCourse
            // 
            this.btnTCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTCourse.Location = new System.Drawing.Point(65, 75);
            this.btnTCourse.Name = "btnTCourse";
            this.btnTCourse.Size = new System.Drawing.Size(291, 106);
            this.btnTCourse.TabIndex = 0;
            this.btnTCourse.Text = "TRAINING COURSES";
            this.btnTCourse.UseVisualStyleBackColor = true;
            this.btnTCourse.Click += new System.EventHandler(this.btnTCourse_Click);
            // 
            // btnTrainers
            // 
            this.btnTrainers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrainers.Location = new System.Drawing.Point(445, 75);
            this.btnTrainers.Name = "btnTrainers";
            this.btnTrainers.Size = new System.Drawing.Size(291, 106);
            this.btnTrainers.TabIndex = 1;
            this.btnTrainers.Text = "TRAINERS";
            this.btnTrainers.UseVisualStyleBackColor = true;
            this.btnTrainers.Click += new System.EventHandler(this.btnTrainers_Click);
            // 
            // btnEnroll
            // 
            this.btnEnroll.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnroll.Location = new System.Drawing.Point(66, 262);
            this.btnEnroll.Name = "btnEnroll";
            this.btnEnroll.Size = new System.Drawing.Size(291, 106);
            this.btnEnroll.TabIndex = 2;
            this.btnEnroll.Text = "ENROLL";
            this.btnEnroll.UseVisualStyleBackColor = true;
            this.btnEnroll.Click += new System.EventHandler(this.btnEnroll_Click);
            // 
            // btnHome
            // 
            this.btnHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.Location = new System.Drawing.Point(445, 262);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(291, 106);
            this.btnHome.TabIndex = 3;
            this.btnHome.Text = "HOME";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.btnEnroll);
            this.Controls.Add(this.btnTrainers);
            this.Controls.Add(this.btnTCourse);
            this.Name = "Form8";
            this.Text = "MAIN MENU";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTCourse;
        private System.Windows.Forms.Button btnTrainers;
        private System.Windows.Forms.Button btnEnroll;
        private System.Windows.Forms.Button btnHome;
    }
}