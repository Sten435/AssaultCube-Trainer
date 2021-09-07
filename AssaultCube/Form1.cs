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

        private void backgroundWorker_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {

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
            }
            else
            {
                Inactive_radio_btn.Invoke((MethodInvoker)(() =>
                {
                    Inactive_radio_btn.Visible = true;
                }));

                return;
            }
        }

        private void checkb_health_CheckedChanged(object sender, EventArgs e)
        {
            if (ac_client_Is_open)
            {
                if (checkb_ammo.Checked)
                {
                    m.FreezeValue($"{PointerAddr.ARiflePrimaryAmmoAddr}", "int", "999999");
                    m.FreezeValue($"{PointerAddr.ARifleSecondaryAmmoAddr}", "int", "999999");
                    m.FreezeValue($"{PointerAddr.PistolPrimaryAmmoAdr}", "int", "999999");
                    m.FreezeValue($"{PointerAddr.PistolSecondaryAmmoAdr}", "int", "999999");
                    Thread.Sleep(10);
                }
                else
                {
                    m.WriteMemory($"{PointerAddr.ARiflePrimaryAmmoAddr}", "int", "100");
                    m.FreezeValue($"{PointerAddr.ARifleSecondaryAmmoAddr}", "int", "100");
                    m.FreezeValue($"{PointerAddr.PistolPrimaryAmmoAdr}", "int", "100");
                    m.FreezeValue($"{PointerAddr.PistolSecondaryAmmoAdr}", "int", "100");
                }
            }
        }

        private void checkb_ammo_CheckedChanged(object sender, EventArgs e)
        {
            if (ac_client_Is_open)
            {
                if (checkb_ammo.Checked)
                {
                    m.FreezeValue($"{PointerAddr.HealthAddr}", "int", "999999");
                }
                else
                {
                    m.WriteMemory($"{PointerAddr.HealthAddr}", "int", "100");
                }
            }
        }
    }
}
