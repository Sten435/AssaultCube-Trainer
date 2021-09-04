using System;
using System.Windows.Forms;
using System.Threading;
using System.Threading.Tasks;
using System.Diagnostics;

namespace AssaultCube
{
    public partial class Form1 : Form
    {
        public static VAMemory VAM;

        public static int localPlayer;

        public static bool ac_client_Is_open = false;

        //public static int PlayerBase = 0x50F4F4;
        public static int PlayerBase = 0x50F4F4;

        public static int Assault_Ammo_Offset = 0x150;
        public static int Pistol_Ammo_Offset = 0x13C;
        public static int Grenade_Offset = 0x158;

        public static int Health_Offset = 0xF8;
        public static int Armor_Offset = 0xFC;

        public static int Player_X_Offset = 0x34;
        public static int Player_Z_Offset = 0x38;
        public static int Player_Height_Offset = 0x3C;

        public static int Mouse_X_Offset = 0x40;
        public static int Mouse_Y_Offset = 0x44;

        // --- --- --- --- --- --- --- --- ---

        public static int HealthAddr;
        public static int Ar_Ammo_Addr;

        public static string HealthAddr_STRING;
        public static string Ar_Ammo_Addr_STRING;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (backgroundWorker.IsBusy != true)
            {
                // Start the asynchronous operation.
                backgroundWorker.RunWorkerAsync();
            }

            /*if (ac_client_Is_open)
            {
                VAM = new VAMemory("ac_client");
                localPlayer = VAM.ReadInt32((IntPtr)PlayerBase);

                HealthAddr = localPlayer + Health_Offset;
                Ar_Ammo_Addr = localPlayer + Assault_Ammo_Offset;
            }*/
        }

        private void checkb_ammo_CheckedChanged(object sender, EventArgs e)
        {
/*            while (checkb_ammo.Checked)
            {
                VAM.WriteInt32((IntPtr)Ar_Ammo_Addr, 9999);
                Thread.Sleep(1);
                Application.DoEvents();
            }*/
        }

        private void checkb_health_CheckedChanged(object sender, EventArgs e)
        {
/*            while (checkb_health.Checked)
            {
                VAM.WriteInt32((IntPtr)HealthAddr, 9999);
                Thread.Sleep(1);
                Application.DoEvents();
            }*/
        }

       /* private void get_process_button_Click(object sender, EventArgs e)
        {*/
/*            Process[] currentProcess = Process.GetProcesses();
            foreach (Process process in currentProcess)
            {
                if(process.ProcessName == "ac_client")
                {
                    process_listbox.Items.Add("Correct");
                    VAM = new VAMemory("ac_client");

                    localPlayer = VAM.ReadInt32((IntPtr)PlayerBase);

                    HealthAddr = localPlayer + Health_Offset;
                    Ar_Ammo_Addr = localPlayer + Assault_Ammo_Offset;

                    ac_client_Is_open = true;

                    checkb_ammo.Enabled = true;
                    checkb_health.Enabled = true;
                    process_listbox.Enabled = true;
                }
            }*/
       /* }*/

        private void backgroundWorker_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {

            Process[] currentProcess = Process.GetProcesses();
            foreach (Process process in currentProcess)
            {
                if (process.ProcessName == "ac_client")
                {
                    VAM = new VAMemory("ac_client");

                    localPlayer = VAM.ReadInt32((IntPtr)PlayerBase);

                    HealthAddr = localPlayer + Health_Offset;
                    Ar_Ammo_Addr = localPlayer + Assault_Ammo_Offset;

                    ac_client_Is_open = true;

                }
            }

            while (true)
            {
                if (ac_client_Is_open)
                {
                    if (checkb_ammo.Checked)
                    {
                        VAM.WriteInt32((IntPtr)Ar_Ammo_Addr, 9999);
                        Thread.Sleep(100);
                    }

                    if (checkb_health.Checked)
                    {
                        VAM.WriteInt32((IntPtr)HealthAddr, 9999);
                        Thread.Sleep(100);
                    }
                }
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
