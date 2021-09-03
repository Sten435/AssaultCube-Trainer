
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
            this.components = new System.ComponentModel.Container();
            this.checkb_ammo = new System.Windows.Forms.CheckBox();
            this.checkb_health = new System.Windows.Forms.CheckBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // checkb_ammo
            // 
            this.checkb_ammo.AutoSize = true;
            this.checkb_ammo.Location = new System.Drawing.Point(24, 65);
            this.checkb_ammo.Name = "checkb_ammo";
            this.checkb_ammo.Size = new System.Drawing.Size(104, 29);
            this.checkb_ammo.TabIndex = 0;
            this.checkb_ammo.Text = "Ammo";
            this.checkb_ammo.UseVisualStyleBackColor = true;
            this.checkb_ammo.CheckedChanged += new System.EventHandler(this.checkb_ammo_CheckedChanged);
            // 
            // checkb_health
            // 
            this.checkb_health.AutoSize = true;
            this.checkb_health.Location = new System.Drawing.Point(24, 115);
            this.checkb_health.Name = "checkb_health";
            this.checkb_health.Size = new System.Drawing.Size(106, 29);
            this.checkb_health.TabIndex = 2;
            this.checkb_health.Text = "Health";
            this.checkb_health.UseVisualStyleBackColor = true;
            this.checkb_health.CheckedChanged += new System.EventHandler(this.checkb_health_CheckedChanged);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.Update);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(343, 211);
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
        private System.Windows.Forms.Timer timer1;
    }
}

