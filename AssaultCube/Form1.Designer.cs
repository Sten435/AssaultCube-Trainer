
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
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.button1 = new System.Windows.Forms.Button();
            this.Active_Label = new System.Windows.Forms.Label();
            this.Inactive_radio_btn = new System.Windows.Forms.PictureBox();
            this.Active_radio_btn = new System.Windows.Forms.PictureBox();
            this.checkb_ammo = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkb_health = new System.Windows.Forms.CheckBox();
            this.Activate_button = new System.Windows.Forms.Button();
            this.checkb_armor = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.Inactive_radio_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Active_radio_btn)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // backgroundWorker
            // 
            this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_DoWork);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.button1.Location = new System.Drawing.Point(721, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(35, 33);
            this.button1.TabIndex = 3;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Active_Label
            // 
            this.Active_Label.AutoSize = true;
            this.Active_Label.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Active_Label.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Active_Label.Location = new System.Drawing.Point(663, 457);
            this.Active_Label.Name = "Active_Label";
            this.Active_Label.Size = new System.Drawing.Size(75, 30);
            this.Active_Label.TabIndex = 5;
            this.Active_Label.Text = "Active";
            // 
            // Inactive_radio_btn
            // 
            this.Inactive_radio_btn.Image = global::AssaultCube.Properties.Resources.Game_inactive;
            this.Inactive_radio_btn.Location = new System.Drawing.Point(619, 458);
            this.Inactive_radio_btn.Name = "Inactive_radio_btn";
            this.Inactive_radio_btn.Size = new System.Drawing.Size(38, 31);
            this.Inactive_radio_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Inactive_radio_btn.TabIndex = 10;
            this.Inactive_radio_btn.TabStop = false;
            // 
            // Active_radio_btn
            // 
            this.Active_radio_btn.Image = global::AssaultCube.Properties.Resources.Game_active;
            this.Active_radio_btn.Location = new System.Drawing.Point(619, 457);
            this.Active_radio_btn.Name = "Active_radio_btn";
            this.Active_radio_btn.Size = new System.Drawing.Size(38, 31);
            this.Active_radio_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Active_radio_btn.TabIndex = 9;
            this.Active_radio_btn.TabStop = false;
            // 
            // checkb_ammo
            // 
            this.checkb_ammo.AutoSize = true;
            this.checkb_ammo.BackColor = System.Drawing.Color.Transparent;
            this.checkb_ammo.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkb_ammo.Location = new System.Drawing.Point(22, 90);
            this.checkb_ammo.Name = "checkb_ammo";
            this.checkb_ammo.Size = new System.Drawing.Size(98, 34);
            this.checkb_ammo.TabIndex = 0;
            this.checkb_ammo.Text = "Ammo";
            this.checkb_ammo.UseVisualStyleBackColor = false;
            this.checkb_ammo.CheckedChanged += new System.EventHandler(this.checkb_ammo_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkb_armor);
            this.groupBox1.Controls.Add(this.checkb_health);
            this.groupBox1.Controls.Add(this.checkb_ammo);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(139, 486);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Unlimited";
            // 
            // checkb_health
            // 
            this.checkb_health.AutoSize = true;
            this.checkb_health.BackColor = System.Drawing.Color.Transparent;
            this.checkb_health.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkb_health.Location = new System.Drawing.Point(22, 50);
            this.checkb_health.Name = "checkb_health";
            this.checkb_health.Size = new System.Drawing.Size(98, 34);
            this.checkb_health.TabIndex = 1;
            this.checkb_health.Text = "Health";
            this.checkb_health.UseVisualStyleBackColor = false;
            this.checkb_health.CheckedChanged += new System.EventHandler(this.checkb_health_CheckedChanged);
            // 
            // Activate_button
            // 
            this.Activate_button.Location = new System.Drawing.Point(668, 414);
            this.Activate_button.Name = "Activate_button";
            this.Activate_button.Size = new System.Drawing.Size(75, 23);
            this.Activate_button.TabIndex = 13;
            this.Activate_button.Text = "Activate";
            this.Activate_button.UseVisualStyleBackColor = true;
            this.Activate_button.Click += new System.EventHandler(this.Activate_button_Click);
            // 
            // checkb_armor
            // 
            this.checkb_armor.AutoSize = true;
            this.checkb_armor.BackColor = System.Drawing.Color.Transparent;
            this.checkb_armor.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkb_armor.Location = new System.Drawing.Point(22, 130);
            this.checkb_armor.Name = "checkb_armor";
            this.checkb_armor.Size = new System.Drawing.Size(95, 34);
            this.checkb_armor.TabIndex = 2;
            this.checkb_armor.Text = "Armor";
            this.checkb_armor.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(768, 510);
            this.Controls.Add(this.Activate_button);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Inactive_radio_btn);
            this.Controls.Add(this.Active_radio_btn);
            this.Controls.Add(this.Active_Label);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(100, 50);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Inactive_radio_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Active_radio_btn)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label Active_Label;
        private System.Windows.Forms.PictureBox Active_radio_btn;
        private System.Windows.Forms.PictureBox Inactive_radio_btn;
        private System.Windows.Forms.CheckBox checkb_ammo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkb_health;
        private System.Windows.Forms.Button Activate_button;
        private System.Windows.Forms.CheckBox checkb_armor;
    }
}

