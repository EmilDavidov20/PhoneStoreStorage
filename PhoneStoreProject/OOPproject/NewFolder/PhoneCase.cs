namespace OOPproject.NewFolder
{
    public class PhoneCase : Item
    {
        public string Color { get; set; }
        public string PhoneBrand { get; set; }
        public PhoneCase(string color = "White", string phoneBrand = "IOS")
        {
            Color = color;
            PhoneBrand = phoneBrand;
            switch (phoneBrand)
            {
                case "IOS":
                    Price = 127.55;
                    Id = 4069;
                    break;
                case "Android":
                    Price = 115.25;
                    Id = 4891;
                    break;
                default:
                    break;
            }
        }
        public override string ToString()
        {
            return $"Case Details, ID: {Id} Price: {Price} Color: {Color} For: {PhoneBrand}";
        }
    }
}
