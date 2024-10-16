using System;

namespace OOPproject.NewFolder
{
    [Serializable]
    public class Item
    {
        public double Price { get; set; }
        public int Id { get; set; }

        protected Item() : this(0, 0)
        {
        }
        protected Item(double newPrice, int newId)
        {
            Price = newPrice;
            Id = newId;
        }
        public double GetPrice()
        {
            return Price;
        }
        public void SetPrice(double newPrice)
        {
            Price = newPrice;
        }
        public int GetId()
        {
            return Id;
        }
        public void SetId(int newId)
        {
            if (newId >= 0)
                Id = newId;
        }
    }
}


