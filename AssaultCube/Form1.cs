using System;
using System.Windows.Forms;
using System.Threading;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Linq;
using Memory;
using System.Text;
using System.Drawing;

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

            Thread thread = new Thread(new ThreadStart(WorkThreadFunction));
            thread.Start();
        }

        public void WorkThreadFunction()
        {
        while (true)
        {
            if (ac_client_Is_open)
            {
                if (checkb_ammo.Checked)
                {
                    byte[] bytes = Encoding.ASCII.GetBytes("90");
                    m.WriteBytes("ac_client.exe+637E9", bytes);
                    Thread.Sleep(100);
                }
                else
                {
                    m.WriteMemory("ac_client.exe+637E9", "bytes", "FF 0E 57 8B 7C 24 14");
                }

                if (checkb_health.Checked)
                {
                    m.FreezeValue($"{PointerAddr.HealthAddr}", "int", "999999");
                    Thread.Sleep(10);
                }
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
    }
}
