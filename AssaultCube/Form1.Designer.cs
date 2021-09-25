
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
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.button1 = new System.Windows.Forms.Button();
            this.Active_Label = new System.Windows.Forms.Label();
            this.Inactive_radio_btn = new System.Windows.Forms.PictureBox();
            this.Active_radio_btn = new System.Windows.Forms.PictureBox();
            this.checkb_ammo = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkb_noReaload = new System.Windows.Forms.CheckBox();
            this.checkb_rapidfire = new System.Windows.Forms.CheckBox();
            this.z_value = new System.Windows.Forms.Label();
            this.y_value = new System.Windows.Forms.Label();
            this.x_value = new System.Windows.Forms.Label();
            this.z_label = new System.Windows.Forms.Label();
            this.y_label = new System.Windows.Forms.Label();
            this.x_label = new System.Windows.Forms.Label();
            this.checkb_armor = new System.Windows.Forms.CheckBox();
            this.checkb_health = new System.Windows.Forms.CheckBox();
            this.Activate_button = new System.Windows.Forms.Button();
            this.Disconnect_button = new System.Windows.Forms.Button();
            this.updateCordinates = new System.Windows.Forms.Timer(this.components);
            this.Enemy_1_X = new System.Windows.Forms.Label();
            this.Enemy_1_Name = new System.Windows.Forms.Label();
            this.EnemyXPos = new System.Windows.Forms.Label();
            this.EnemyYPos = new System.Windows.Forms.Label();
            this.Enemy_1_Y = new System.Windows.Forms.Label();
            this.Enemy_1_Z = new System.Windows.Forms.Label();
            this.EnemyZPos = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Inactive_radio_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Active_radio_btn)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(260, 12);
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
            this.Active_Label.Location = new System.Drawing.Point(215, 323);
            this.Active_Label.Name = "Active_Label";
            this.Active_Label.Size = new System.Drawing.Size(75, 30);
            this.Active_Label.TabIndex = 5;
            this.Active_Label.Text = "Active";
            // 
            // Inactive_radio_btn
            // 
            this.Inactive_radio_btn.Image = global::AssaultCube.Properties.Resources.Game_inactive;
            this.Inactive_radio_btn.Location = new System.Drawing.Point(171, 324);
            this.Inactive_radio_btn.Name = "Inactive_radio_btn";
            this.Inactive_radio_btn.Size = new System.Drawing.Size(38, 31);
            this.Inactive_radio_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Inactive_radio_btn.TabIndex = 10;
            this.Inactive_radio_btn.TabStop = false;
            // 
            // Active_radio_btn
            // 
            this.Active_radio_btn.Image = global::AssaultCube.Properties.Resources.Game_active;
            this.Active_radio_btn.Location = new System.Drawing.Point(171, 324);
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
            this.checkb_ammo.Location = new System.Drawing.Point(22, 146);
            this.checkb_ammo.Name = "checkb_ammo";
            this.checkb_ammo.Size = new System.Drawing.Size(98, 34);
            this.checkb_ammo.TabIndex = 0;
            this.checkb_ammo.Text = "Ammo";
            this.checkb_ammo.UseVisualStyleBackColor = false;
            this.checkb_ammo.CheckedChanged += new System.EventHandler(this.checkb_ammo_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkb_noReaload);
            this.groupBox1.Controls.Add(this.checkb_rapidfire);
            this.groupBox1.Controls.Add(this.z_value);
            this.groupBox1.Controls.Add(this.y_value);
            this.groupBox1.Controls.Add(this.x_value);
            this.groupBox1.Controls.Add(this.z_label);
            this.groupBox1.Controls.Add(this.y_label);
            this.groupBox1.Controls.Add(this.x_label);
            this.groupBox1.Controls.Add(this.checkb_armor);
            this.groupBox1.Controls.Add(this.checkb_health);
            this.groupBox1.Controls.Add(this.checkb_ammo);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(153, 348);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cheat";
            // 
            // checkb_noReaload
            // 
            this.checkb_noReaload.AutoSize = true;
            this.checkb_noReaload.BackColor = System.Drawing.Color.Transparent;
            this.checkb_noReaload.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkb_noReaload.Location = new System.Drawing.Point(22, 67);
            this.checkb_noReaload.Name = "checkb_noReaload";
            this.checkb_noReaload.Size = new System.Drawing.Size(122, 34);
            this.checkb_noReaload.TabIndex = 10;
            this.checkb_noReaload.Text = "NoRecoil";
            this.checkb_noReaload.UseVisualStyleBackColor = false;
            this.checkb_noReaload.CheckedChanged += new System.EventHandler(this.checkb_aimbot_CheckedChanged);
            // 
            // checkb_rapidfire
            // 
            this.checkb_rapidfire.AutoSize = true;
            this.checkb_rapidfire.BackColor = System.Drawing.Color.Transparent;
            this.checkb_rapidfire.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkb_rapidfire.Location = new System.Drawing.Point(22, 31);
            this.checkb_rapidfire.Name = "checkb_rapidfire";
            this.checkb_rapidfire.Size = new System.Drawing.Size(126, 34);
            this.checkb_rapidfire.TabIndex = 9;
            this.checkb_rapidfire.Text = "RapidFire";
            this.checkb_rapidfire.UseVisualStyleBackColor = false;
            this.checkb_rapidfire.CheckedChanged += new System.EventHandler(this.checkb_esp_CheckedChanged);
            // 
            // z_value
            // 
            this.z_value.AutoSize = true;
            this.z_value.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.z_value.Location = new System.Drawing.Point(47, 307);
            this.z_value.Name = "z_value";
            this.z_value.Size = new System.Drawing.Size(23, 25);
            this.z_value.TabIndex = 8;
            this.z_value.Text = "#";
            // 
            // y_value
            // 
            this.y_value.AutoSize = true;
            this.y_value.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.y_value.Location = new System.Drawing.Point(47, 271);
            this.y_value.Name = "y_value";
            this.y_value.Size = new System.Drawing.Size(23, 25);
            this.y_value.TabIndex = 7;
            this.y_value.Text = "#";
            // 
            // x_value
            // 
            this.x_value.AutoSize = true;
            this.x_value.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.x_value.Location = new System.Drawing.Point(47, 235);
            this.x_value.Name = "x_value";
            this.x_value.Size = new System.Drawing.Size(23, 25);
            this.x_value.TabIndex = 6;
            this.x_value.Text = "#";
            // 
            // z_label
            // 
            this.z_label.AutoSize = true;
            this.z_label.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.z_label.Location = new System.Drawing.Point(17, 307);
            this.z_label.Name = "z_label";
            this.z_label.Size = new System.Drawing.Size(23, 25);
            this.z_label.TabIndex = 5;
            this.z_label.Text = "Z";
            // 
            // y_label
            // 
            this.y_label.AutoSize = true;
            this.y_label.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.y_label.Location = new System.Drawing.Point(17, 271);
            this.y_label.Name = "y_label";
            this.y_label.Size = new System.Drawing.Size(23, 25);
            this.y_label.TabIndex = 4;
            this.y_label.Text = "Y";
            // 
            // x_label
            // 
            this.x_label.AutoSize = true;
            this.x_label.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.x_label.Location = new System.Drawing.Point(17, 235);
            this.x_label.Name = "x_label";
            this.x_label.Size = new System.Drawing.Size(24, 25);
            this.x_label.TabIndex = 3;
            this.x_label.Text = "X";
            // 
            // checkb_armor
            // 
            this.checkb_armor.AutoSize = true;
            this.checkb_armor.BackColor = System.Drawing.Color.Transparent;
            this.checkb_armor.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkb_armor.Location = new System.Drawing.Point(22, 186);
            this.checkb_armor.Name = "checkb_armor";
            this.checkb_armor.Size = new System.Drawing.Size(95, 34);
            this.checkb_armor.TabIndex = 2;
            this.checkb_armor.Text = "Armor";
            this.checkb_armor.UseVisualStyleBackColor = false;
            this.checkb_armor.CheckedChanged += new System.EventHandler(this.checkb_armor_CheckedChanged);
            // 
            // checkb_health
            // 
            this.checkb_health.AutoSize = true;
            this.checkb_health.BackColor = System.Drawing.Color.Transparent;
            this.checkb_health.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkb_health.Location = new System.Drawing.Point(22, 106);
            this.checkb_health.Name = "checkb_health";
            this.checkb_health.Size = new System.Drawing.Size(98, 34);
            this.checkb_health.TabIndex = 1;
            this.checkb_health.Text = "Health";
            this.checkb_health.UseVisualStyleBackColor = false;
            this.checkb_health.CheckedChanged += new System.EventHandler(this.checkb_health_CheckedChanged);
            // 
            // Activate_button
            // 
            this.Activate_button.Location = new System.Drawing.Point(172, 279);
            this.Activate_button.Name = "Activate_button";
            this.Activate_button.Size = new System.Drawing.Size(124, 29);
            this.Activate_button.TabIndex = 13;
            this.Activate_button.Text = "Activate";
            this.Activate_button.UseVisualStyleBackColor = true;
            this.Activate_button.Click += new System.EventHandler(this.Activate_button_Click);
            // 
            // Disconnect_button
            // 
            this.Disconnect_button.Location = new System.Drawing.Point(171, 280);
            this.Disconnect_button.Name = "Disconnect_button";
            this.Disconnect_button.Size = new System.Drawing.Size(124, 29);
            this.Disconnect_button.TabIndex = 14;
            this.Disconnect_button.Text = "Disconnect";
            this.Disconnect_button.UseVisualStyleBackColor = true;
            this.Disconnect_button.Click += new System.EventHandler(this.Disconnect_button_Click);
            // 
            // updateCordinates
            // 
            this.updateCordinates.Enabled = true;
            this.updateCordinates.Interval = 500;
            this.updateCordinates.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Enemy_1_X
            // 
            this.Enemy_1_X.AutoSize = true;
            this.Enemy_1_X.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.Enemy_1_X.Location = new System.Drawing.Point(303, 106);
            this.Enemy_1_X.Name = "Enemy_1_X";
            this.Enemy_1_X.Size = new System.Drawing.Size(83, 25);
            this.Enemy_1_X.TabIndex = 11;
            this.Enemy_1_X.Text = "Enemy 1";
            // 
            // Enemy_1_Name
            // 
            this.Enemy_1_Name.AutoSize = true;
            this.Enemy_1_Name.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.Enemy_1_Name.Location = new System.Drawing.Point(215, 65);
            this.Enemy_1_Name.Name = "Enemy_1_Name";
            this.Enemy_1_Name.Size = new System.Drawing.Size(127, 25);
            this.Enemy_1_Name.TabIndex = 15;
            this.Enemy_1_Name.Text = "Enemy Name";
            // 
            // EnemyXPos
            // 
            this.EnemyXPos.AutoSize = true;
            this.EnemyXPos.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.EnemyXPos.Location = new System.Drawing.Point(215, 106);
            this.EnemyXPos.Name = "EnemyXPos";
            this.EnemyXPos.Size = new System.Drawing.Size(24, 25);
            this.EnemyXPos.TabIndex = 16;
            this.EnemyXPos.Text = "X";
            // 
            // EnemyYPos
            // 
            this.EnemyYPos.AutoSize = true;
            this.EnemyYPos.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.EnemyYPos.Location = new System.Drawing.Point(215, 143);
            this.EnemyYPos.Name = "EnemyYPos";
            this.EnemyYPos.Size = new System.Drawing.Size(23, 25);
            this.EnemyYPos.TabIndex = 18;
            this.EnemyYPos.Text = "Y";
            // 
            // Enemy_1_Y
            // 
            this.Enemy_1_Y.AutoSize = true;
            this.Enemy_1_Y.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.Enemy_1_Y.Location = new System.Drawing.Point(303, 143);
            this.Enemy_1_Y.Name = "Enemy_1_Y";
            this.Enemy_1_Y.Size = new System.Drawing.Size(83, 25);
            this.Enemy_1_Y.TabIndex = 17;
            this.Enemy_1_Y.Text = "Enemy 1";
            // 
            // Enemy_1_Z
            // 
            this.Enemy_1_Z.AutoSize = true;
            this.Enemy_1_Z.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.Enemy_1_Z.Location = new System.Drawing.Point(303, 181);
            this.Enemy_1_Z.Name = "Enemy_1_Z";
            this.Enemy_1_Z.Size = new System.Drawing.Size(83, 25);
            this.Enemy_1_Z.TabIndex = 19;
            this.Enemy_1_Z.Text = "Enemy 1";
            // 
            // EnemyZPos
            // 
            this.EnemyZPos.AutoSize = true;
            this.EnemyZPos.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.EnemyZPos.Location = new System.Drawing.Point(215, 181);
            this.EnemyZPos.Name = "EnemyZPos";
            this.EnemyZPos.Size = new System.Drawing.Size(23, 25);
            this.EnemyZPos.TabIndex = 20;
            this.EnemyZPos.Text = "Z";
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(463, 372);
            this.Controls.Add(this.EnemyZPos);
            this.Controls.Add(this.Enemy_1_Z);
            this.Controls.Add(this.EnemyYPos);
            this.Controls.Add(this.Enemy_1_Y);
            this.Controls.Add(this.EnemyXPos);
            this.Controls.Add(this.Enemy_1_Name);
            this.Controls.Add(this.Enemy_1_X);
            this.Controls.Add(this.Activate_button);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Inactive_radio_btn);
            this.Controls.Add(this.Active_radio_btn);
            this.Controls.Add(this.Active_Label);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Disconnect_button);
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
        private System.Windows.Forms.Label z_value;
        private System.Windows.Forms.Label y_value;
        private System.Windows.Forms.Label x_value;
        private System.Windows.Forms.Label z_label;
        private System.Windows.Forms.Label y_label;
        private System.Windows.Forms.Label x_label;
        private System.Windows.Forms.CheckBox checkb_rapidfire;
        private System.Windows.Forms.CheckBox checkb_noReaload;
        private System.Windows.Forms.Button Disconnect_button;
        private System.Windows.Forms.Timer updateCordinates;
        private System.Windows.Forms.Label Enemy_1_X;
        private System.Windows.Forms.Label Enemy_1_Name;
        private System.Windows.Forms.Label EnemyXPos;
        private System.Windows.Forms.Label EnemyYPos;
        private System.Windows.Forms.Label Enemy_1_Y;
        private System.Windows.Forms.Label Enemy_1_Z;
        private System.Windows.Forms.Label EnemyZPos;
    }
}

