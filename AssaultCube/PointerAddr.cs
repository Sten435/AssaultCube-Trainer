
namespace AssaultCube
{
    internal class PointerAddr
    {
        //public static int BASE_ADDR_1 = 0x109B74;
        //public static int BASE_ADDR_2 = 0x10F4F4;
        //public static int BASE_ADDR_3 = 0x11E20C;
        private static string gameBase = "\"ac_client.exe\"";


        public static string viewMatrix = "0x501AE8";
        public static string localEntityAddr = $"{gameBase}+10F4F4";
        public static string norecoil = $"{gameBase}+0x45BAAD";

        public static string HealthAddr = $"{localEntityAddr},F8";
        public static string IsShooting = $"{localEntityAddr},224"; // 0 is not  | 1 is shooting

        public static string ARiflePrimaryAmmoAddr = $"{localEntityAddr},150";
        public static string ARifleSecondaryAmmoAddr = $"{localEntityAddr},128";

        public static string KevlarArmorAddr = $"{localEntityAddr},FC";

        public static string PistolPrimaryAmmoAdr = $"{localEntityAddr},13C";
        public static string PistolSecondaryAmmoAdr = $"{localEntityAddr},114";

        public static string LocalPlayerXPosAddr = $"{localEntityAddr},34";
        public static string LocalPlayerZPosAddr = $"{localEntityAddr},3C";
        public static string LocalPlayerYPosAddr = $"{localEntityAddr},38";
        
        public static string LocalPlayerXMouse = $"{localEntityAddr},40";
        public static string LocalPlayerYMouse = $"{localEntityAddr},44";




        private static int[] wichEnemy = { 4, 8, 12, 16, 20 };

        public static string EnemyEntityAddr = $"{gameBase}+10F4F8";

        public static string Enemyname = $"{EnemyEntityAddr},{wichEnemy[0]},225";

        public static string EnemyXPosAddr = $"{EnemyEntityAddr},{wichEnemy[0]},34";
        public static string EnemyZPosAddr = $"{EnemyEntityAddr},{wichEnemy[0]},3C";
        public static string EnemyYPosAddr = $"{EnemyEntityAddr},{wichEnemy[0]},38";
    }
}
