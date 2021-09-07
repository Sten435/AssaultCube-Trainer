namespace AssaultCube
{
    internal class PointerAddr
    {
        //public static int BASE_ADDR_1 = 0x109B74;
        //public static int BASE_ADDR_2 = 0x10F4F4;
        //public static int BASE_ADDR_3 = 0x11E20C;

        public const string localEntityAddr = "base+10F4F4";
        public static string HealthAddr = $"{localEntityAddr},F8";
        public static string ARiflePrimaryAmmoAddr = $"{localEntityAddr},150";
        public static string ARifleSecondaryAmmoAddr = $"{localEntityAddr},128";
        public static string KevlarArmorAddr = $"{localEntityAddr},FC";
        public static string PistolPrimaryAmmoAdr = $"{localEntityAddr},13Cas";
        public static string PistolSecondaryAmmoAdr = $"{localEntityAddr},114";
        public static string LocalPlayerXPosAddr = $"{localEntityAddr},34";
        public static string LocalPlayerYPosAddr = $"{localEntityAddr},3C";
        public static string LocalPlayerZPosAddr = $"{localEntityAddr},38";
        public static string LocalPlayerXMouse = $"{localEntityAddr},40";
        public static string LocalPlayerZMouse = $"{localEntityAddr},44";
    }
}
