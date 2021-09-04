
namespace AssaultCube
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
            this.checkb_ammo = new System.Windows.Forms.CheckBox();
            this.checkb_health = new System.Windows.Forms.CheckBox();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // checkb_ammo
            // 
            this.checkb_ammo.AutoSize = true;
            this.checkb_ammo.Location = new System.Drawing.Point(12, 12);
            this.checkb_ammo.Name = "checkb_ammo";
            this.checkb_ammo.Size = new System.Drawing.Size(55, 17);
            this.checkb_ammo.TabIndex = 0;
            this.checkb_ammo.Text = "Ammo";
            this.checkb_ammo.UseVisualStyleBackColor = true;
            this.checkb_ammo.CheckedChanged += new System.EventHandler(this.checkb_ammo_CheckedChanged);
            // 
            // checkb_health
            // 
            this.checkb_health.AutoSize = true;
            this.checkb_health.Location = new System.Drawing.Point(12, 37);
            this.checkb_health.Name = "checkb_health";
            this.checkb_health.Size = new System.Drawing.Size(57, 17);
            this.checkb_health.TabIndex = 2;
            this.checkb_health.Text = "Health";
            this.checkb_health.UseVisualStyleBackColor = true;
            this.checkb_health.CheckedChanged += new System.EventHandler(this.checkb_health_CheckedChanged);
            // 
            // backgroundWorker
            // 
            this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_DoWork);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(312, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(24, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(343, 211);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkb_health);
            this.Controls.Add(this.checkb_ammo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(100, 50);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkb_ammo;
        private System.Windows.Forms.CheckBox checkb_health;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
        private System.Windows.Forms.Button button1;
    }
}

