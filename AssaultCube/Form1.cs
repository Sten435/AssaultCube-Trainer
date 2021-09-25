using System;
using System.Windows.Forms;
using System.Threading;
using Memory;
using System.Text;

namespace AssaultCube
{
    public partial class Form1 : Form
    {
        Mem m = new Mem();

        public static bool ac_client_Is_open = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (backgroundWorker.IsBusy != true)
            {
                backgroundWorker.RunWorkerAsync();
            }
        }

        public void checkb_health_()
        {
            if (ac_client_Is_open)
            {
                if (checkb_health.Checked)
                {
                    m.FreezeValue($"{PointerAddr.HealthAddr}", "int", "999999");
                    Thread.Sleep(10);
                }
                else
                {
                    m.WriteMemory($"{PointerAddr.HealthAddr}", "int", "100");
                }
            }
    }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Activate_button_Click(object sender, EventArgs e)
        {
            if (m.OpenProcess("ac_client"))
            {
                ac_client_Is_open = true;

                Inactive_radio_btn.Invoke((MethodInvoker)(() =>
                {
                    Inactive_radio_btn.Visible = false;
                }));

                Active_radio_btn.Invoke((MethodInvoker)(() =>
                {
                    Active_radio_btn.Visible = true;
                }));

                Disconnect_button.Invoke((MethodInvoker)(() =>
                {
                    Disconnect_button.Visible = true;
                }));

                Activate_button.Invoke((MethodInvoker)(() =>
                {
                    Activate_button.Visible = false;
                }));
            }
        }



        private void checkb_health_CheckedChanged(object sender, EventArgs e)
        {
            if (ac_client_Is_open)
            {
                if (checkb_health.Checked)
                {
                    m.FreezeValue($"{PointerAddr.HealthAddr}", "int", "9999");
                }
                else
                {
                    m.UnfreezeValue($"{PointerAddr.HealthAddr}");
                    m.WriteMemory($"{PointerAddr.HealthAddr}", "int", "100");
                }
            }
        }

        private void checkb_ammo_CheckedChanged(object sender, EventArgs e)
        {
            if (ac_client_Is_open)
            {
                if (checkb_ammo.Checked)
                {
                    m.FreezeValue($"{PointerAddr.ARiflePrimaryAmmoAddr}", "int", "9999");
                    m.FreezeValue($"{PointerAddr.ARifleSecondaryAmmoAddr}", "int", "9999");
                    m.FreezeValue($"{PointerAddr.PistolPrimaryAmmoAdr}", "int", "9999");
                    m.FreezeValue($"{PointerAddr.PistolSecondaryAmmoAdr}", "int", "9999");
                }
                else
                {
                    m.UnfreezeValue($"{PointerAddr.ARiflePrimaryAmmoAddr}");
                    m.UnfreezeValue($"{PointerAddr.ARifleSecondaryAmmoAddr}");
                    m.UnfreezeValue($"{PointerAddr.PistolPrimaryAmmoAdr}");
                    m.UnfreezeValue($"{PointerAddr.PistolSecondaryAmmoAdr}");

                    m.WriteMemory($"{PointerAddr.ARiflePrimaryAmmoAddr}", "int", "100");
                    m.WriteMemory($"{PointerAddr.ARifleSecondaryAmmoAddr}", "int", "100");
                    m.WriteMemory($"{PointerAddr.PistolPrimaryAmmoAdr}", "int", "100");
                    m.WriteMemory($"{PointerAddr.PistolSecondaryAmmoAdr}", "int", "100");
                }
            }
        }

        private void checkb_armor_CheckedChanged(object sender, EventArgs e)
        {
            if (ac_client_Is_open)
            {
                if (checkb_armor.Checked)
                {
                    m.FreezeValue($"{PointerAddr.KevlarArmorAddr}", "int", "9999");
                }
                else
                {
                    m.UnfreezeValue($"{PointerAddr.KevlarArmorAddr}");
                    m.WriteMemory($"{PointerAddr.KevlarArmorAddr}", "int", "100");
                }
            }
        }

        private void Disconnect_button_Click(object sender, EventArgs e)
        {
            ac_client_Is_open = false;

            if (m.OpenProcess("ac_client"))
            {
                m.CloseProcess();
                Inactive_radio_btn.Invoke((MethodInvoker)(() =>
                {
                    Inactive_radio_btn.Visible = true;
                }));

                Active_radio_btn.Invoke((MethodInvoker)(() =>
                {
                    Active_radio_btn.Visible = false;
                }));

                Disconnect_button.Invoke((MethodInvoker)(() =>
                {
                    Disconnect_button.Visible = false;
                }));

                Activate_button.Invoke((MethodInvoker)(() =>
                {
                    Activate_button.Visible = true;
                }));
            }
        }

        private void checkb_esp_CheckedChanged(object sender, EventArgs e)
        {

            if (ac_client_Is_open)
            {
                if (checkb_rapidfire.Checked)
                {
                    byte[] nopBytes = { 0x90, 0x90, 0x90, 0x90, 0x90, 0x90 };
                    m.WriteBytes($"base+0x5F5C6", nopBytes);
                }
                else
                {
                    byte[] nopBytes = { 0x89, 0x9D, 0x10, 0x02, 0x00, 0x00 };
                    m.WriteBytes($"base+0x5F5C6", nopBytes);
                }
            }
        }

        private void checkb_aimbot_CheckedChanged(object sender, EventArgs e)
        {
            if (ac_client_Is_open)
            {
                if (checkb_noReaload.Checked)
                {
                    byte[] noRecoilBytes = { 0xDD, 0xD8, 0x90 };
                    m.WriteBytes($"{PointerAddr.norecoil}", noRecoilBytes);
                }
                else
                {
                    byte[] noRecoilBytes = { 0xD9, 0x5B, 0x44 };
                    m.WriteBytes($"{PointerAddr.norecoil}", noRecoilBytes);
                }
            }
           }
            

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (ac_client_Is_open)
            {
                x_value.Text = m.ReadFloat(PointerAddr.LocalPlayerXPosAddr).ToString();
                y_value.Text = m.ReadFloat(PointerAddr.LocalPlayerYPosAddr).ToString();
                z_value.Text = m.ReadFloat(PointerAddr.LocalPlayerZPosAddr).ToString();

                Enemy_1_X.Text = m.ReadFloat(PointerAddr.EnemyXPosAddr).ToString();
                Enemy_1_Y.Text = m.ReadFloat(PointerAddr.EnemyYPosAddr).ToString();
                Enemy_1_Z.Text = m.ReadFloat(PointerAddr.EnemyZPosAddr).ToString();

                Enemy_1_Name.Text = m.ReadString(PointerAddr.Enemyname).ToString();
            }
        }
    }
}
