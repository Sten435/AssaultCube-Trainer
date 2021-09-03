
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
            this.get_process_button = new System.Windows.Forms.Button();
            this.process_listbox = new System.Windows.Forms.ListBox();
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
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.Update);
            // 
            // get_process_button
            // 
            this.get_process_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.get_process_button.ForeColor = System.Drawing.Color.DimGray;
            this.get_process_button.Location = new System.Drawing.Point(149, 12);
            this.get_process_button.Name = "get_process_button";
            this.get_process_button.Size = new System.Drawing.Size(182, 34);
            this.get_process_button.TabIndex = 3;
            this.get_process_button.Text = "Get Processes";
            this.get_process_button.UseVisualStyleBackColor = true;
            this.get_process_button.Click += new System.EventHandler(this.get_process_button_Click);
            // 
            // process_listbox
            // 
            this.process_listbox.FormattingEnabled = true;
            this.process_listbox.Location = new System.Drawing.Point(149, 54);
            this.process_listbox.Name = "process_listbox";
            this.process_listbox.Size = new System.Drawing.Size(182, 147);
            this.process_listbox.TabIndex = 4;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(343, 211);
            this.Controls.Add(this.process_listbox);
            this.Controls.Add(this.get_process_button);
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
        private System.Windows.Forms.Button get_process_button;
        private System.Windows.Forms.ListBox process_listbox;
    }
}

