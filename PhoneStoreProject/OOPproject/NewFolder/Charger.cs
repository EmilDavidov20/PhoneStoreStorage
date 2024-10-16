namespace OOPproject.NewFolder
{
    public class Charger : Item
    {

        public int Wattage { get; set; }
        public double Amperage { get; set; }
        public Charger(int wattage = 20, double amperage = 5.5)

        {
            Wattage = wattage;
            Amperage = amperage;
            switch (wattage)
            {
                case 15:
                    Price = 5.25 * 15;
                    Id = 3000 + (wattage * 5);
                    break;
                case 20:
                    Price = 5.32 * 20;
                    Id = 3000 + (wattage * 6);
                    break;
                case 30:
                    Price = 5.45 * 30;
                    Id = 3000 + (wattage * 7);
                    break;
                default:
                    break;
            }
        }


        public override string ToString()
        {
            return $"Charger Details, ID: {Id} Price: {Price} Wattage: {Wattage} Amperage: {Amperage}";
        }

    }
}
