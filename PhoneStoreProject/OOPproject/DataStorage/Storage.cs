using System;
using System.Collections.Generic;
using System.IO;
using OOPproject.NewFolder;

namespace OOPproject.DataStoarge
{
    public static class Storage
    {
        public static List<Item> Stock { get; set; }
        public static List<Item> Cart { get; set; }
        static Storage()
        {
            Stock = LoadData();
            Cart = new List<Item>();
            
        }
        public static void SaveData()
        {
            if (File.Exists("list.txt"))
                File.Delete("list.txt");
            foreach (Item item in Stock)
                File.AppendAllText("list.txt", item.ToString() + "\r\n");
        }
        public static List<Item> LoadData()
        {
            Stock = new List<Item>();
            if (File.Exists("list.txt"))
            {
                string[] lines = File.ReadAllLines("list.txt");
                foreach (string line in lines)
                {
                    string[] sublines = line.Split(' ');
                    if (line.Contains("Iphone"))
                        Stock.Add(new NewFolder.Phone((sublines[0]), int.Parse(sublines[13]), (sublines[9]), double.Parse(sublines[7]), Boolean.Parse(sublines[11]), int.Parse(sublines[15])));
                    else if (line.Contains("Galaxy"))
                        Stock.Add(new NewFolder.Phone((sublines[0]), int.Parse(sublines[13]), (sublines[9]), double.Parse(sublines[7]), Boolean.Parse(sublines[11]), int.Parse(sublines[15])));
                    else if (line.Contains("Case"))
                        Stock.Add(new NewFolder.PhoneCase((sublines[7]), (sublines[9])));
                    else if (line.Contains("HeadPhones"))
                        Stock.Add(new NewFolder.HeadPhones((sublines[9]), (sublines[7]), Boolean.Parse(sublines[11])));
                    else if (line.Contains("Charger"))
                        Stock.Add(new NewFolder.Charger(int.Parse(sublines[7]), double.Parse(sublines[9])));
                }
            }
            return Stock;
        }
    }
}