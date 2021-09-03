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
            /*VAM = new VAMemory("ac_client");
            localPlayer = VAM.ReadInt32((IntPtr)PlayerBase);

            HealthAddr = localPlayer + Health_Offset;
            Ar_Ammo_Addr = localPlayer + Assault_Ammo_Offset;*/
        }

        private void Update(object sender, EventArgs e)
        {
            /*HealthAddr_STRING = VAM.ReadInt32((IntPtr)HealthAddr).ToString();
            Ar_Ammo_Addr_STRING = VAM.ReadInt32((IntPtr)Ar_Ammo_Addr).ToString();

            updateHealthLabel();
            updateAmmoLabel();*/
        }

        private void checkb_ammo_CheckedChanged(object sender, EventArgs e)
        {
            /*if (checkb_ammo.Checked)
            {
                while (true)
                {
                    VAM.WriteInt32((IntPtr)Ar_Ammo_Addr, 999);
                    Thread.Sleep(1000);
                    Application.DoEvents();
                }

            }*/
            Process currentProcess = Process.GetCurrentProcess();
            checkb_health.Text = currentProcess.ToString();

        }

        private void checkb_health_CheckedChanged(object sender, EventArgs e)
        {
            /*if (checkb_health.Checked)
            {
                while (true)
                {
                    VAM.WriteInt32((IntPtr)HealthAddr, 1337);
                    Thread.Sleep(500);
                    Application.DoEvents();
                }
            }*/
        }

        private void updateHealthLabel()
        {
            checkb_health.Text = HealthAddr_STRING.ToString();
            Application.DoEvents();
        }

        private void updateAmmoLabel()
        {
            checkb_ammo.Text = Ar_Ammo_Addr_STRING.ToString();
            Application.DoEvents();
        }
    }
}
