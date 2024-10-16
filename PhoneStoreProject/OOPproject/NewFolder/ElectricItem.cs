
namespace OOPproject.NewFolder
{
    public class ElectricItem : Item
    {
        public string Name { get; set; }
        public string Color { get; set; }

        protected ElectricItem(double newPrice, int newId, string newName, string newColor)
            : base(newPrice, newId)
        {
            Price = newPrice;
            Id = newId;
            Color = newColor;
            Name = newName;
        }

    }
}


