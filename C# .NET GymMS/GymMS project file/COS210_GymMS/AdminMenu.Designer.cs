namespace COS210_GymMS
{
    partial class AdminMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminMenu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.trainingCoursesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trainersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.membersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enrollmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hOMEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Right;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.trainingCoursesToolStripMenuItem,
            this.trainersToolStripMenuItem,
            this.membersToolStripMenuItem,
            this.enrollmentToolStripMenuItem,
            this.hOMEToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(510, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(194, 419);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // trainingCoursesToolStripMenuItem
            // 
            this.trainingCoursesToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.trainingCoursesToolStripMenuItem.Name = "trainingCoursesToolStripMenuItem";
            this.trainingCoursesToolStripMenuItem.Size = new System.Drawing.Size(181, 29);
            this.trainingCoursesToolStripMenuItem.Text = "TRAINING COURSES";
            this.trainingCoursesToolStripMenuItem.Click += new System.EventHandler(this.trainingCoursesToolStripMenuItem_Click);
            // 
            // trainersToolStripMenuItem
            // 
            this.trainersToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.trainersToolStripMenuItem.Name = "trainersToolStripMenuItem";
            this.trainersToolStripMenuItem.Size = new System.Drawing.Size(181, 29);
            this.trainersToolStripMenuItem.Text = "TRAINERS";
            this.trainersToolStripMenuItem.Click += new System.EventHandler(this.trainersToolStripMenuItem_Click);
            // 
            // membersToolStripMenuItem
            // 
            this.membersToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.membersToolStripMenuItem.Name = "membersToolStripMenuItem";
            this.membersToolStripMenuItem.Size = new System.Drawing.Size(181, 29);
            this.membersToolStripMenuItem.Text = "MEMBERS";
            this.membersToolStripMenuItem.Click += new System.EventHandler(this.membersToolStripMenuItem_Click);
            // 
            // enrollmentToolStripMenuItem
            // 
            this.enrollmentToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.enrollmentToolStripMenuItem.Name = "enrollmentToolStripMenuItem";
            this.enrollmentToolStripMenuItem.Size = new System.Drawing.Size(181, 29);
            this.enrollmentToolStripMenuItem.Text = "ENROLLMENT";
            this.enrollmentToolStripMenuItem.Click += new System.EventHandler(this.enrollmentToolStripMenuItem_Click);
            // 
            // hOMEToolStripMenuItem
            // 
            this.hOMEToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.hOMEToolStripMenuItem.Name = "hOMEToolStripMenuItem";
            this.hOMEToolStripMenuItem.Size = new System.Drawing.Size(181, 29);
            this.hOMEToolStripMenuItem.Text = "HOME";
            this.hOMEToolStripMenuItem.Click += new System.EventHandler(this.hOMEToolStripMenuItem_Click);
            // 
            // AdminMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(704, 419);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AdminMenu";
            this.Text = "ADMIN MAIN MENU";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem trainingCoursesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trainersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem membersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enrollmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hOMEToolStripMenuItem;
    }
}