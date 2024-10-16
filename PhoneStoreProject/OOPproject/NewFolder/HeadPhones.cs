namespace OOPproject.NewFolder
{
    public class HeadPhones : ElectricItem
    {
        public string Type { get; set; }
        public bool HasMicrophone { get; set; }
        public HeadPhones(string color = "White", string type = "IOS", bool hasMicrophone = true) : base(0, 1000, "", "")
        {
            Type = type;
            HasMicrophone = hasMicrophone;
            Color = color;
            switch (type)
            {
                case "IOS":
                    SetPrice(159.99);
                    SetId(2067);
                    break;
                case "Android":
                    SetPrice(139.99);
                    SetId(2678);
                    break;
                default:
                    break;
            }
        }

        public override string ToString()
        {
            return $"HeadPhones Details, ID: {Id} Price: {Price} For: {Type} Color: {Color} Microphone: {HasMicrophone}";
        }
    }
}
