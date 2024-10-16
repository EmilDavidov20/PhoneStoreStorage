
namespace OOPproject.NewFolder
{
    public class Phone : ElectricItem
    {
        public int Ssd { get; set; }
        public double Inch { get; set; }
        public bool SupportsWirelessCharging { get; set; }
        public int CameraResolution { get; set; }
        public Phone(string name = "Iphone", int ssd = 64, string color = "White", double inch = 2.4, bool supportsWirelessCharging = true, int cameraResolution = 1240)
            : base(ssd, cameraResolution, name, color)
        {
            Ssd = ssd;
            Inch = inch;
            SupportsWirelessCharging = supportsWirelessCharging;
            CameraResolution = cameraResolution;
            switch (ssd)
            {
                case 64:
                    SetPrice(64 * 50.35);
                    SetId(1000 + (int)(inch * 5));
                    break;
                case 128:
                    SetPrice(128 * 30.35);
                    SetId(1000 + (int)(inch * 6));
                    break;
                case 256:
                    SetPrice(256 * 19.45);
                    SetId(1000 + (int)(inch * 7));
                    break;
                case 512:
                    SetPrice(512 * 11.55);
                    SetId(1000 + (int)(inch * 8));
                    break;
                case 1024:
                    SetPrice(1024 * 5.75);
                    SetId(1000 + (int)(inch * 8));
                    break;
                default:
                    break;
            }
        }
        public override string ToString()
        {
            return $"{Name} Details, ID: {Id} Price: {Price} Inch: {Inch} Color: {Color} Wireless: {SupportsWirelessCharging} SSD: {Ssd} Resolution: {CameraResolution}";
        }
    }
}


