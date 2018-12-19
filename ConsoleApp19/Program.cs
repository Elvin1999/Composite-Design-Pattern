using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleApp19
{
    abstract class AbstractItem
    {
        public abstract void Add(AbstractItem item);
        public abstract void Remove(AbstractItem item);
        public abstract void Show();
    }
    class ItemBox : AbstractItem
    {
        List<AbstractItem> items = new List<AbstractItem>();
        public override void Add(AbstractItem item)
        {
            items.Add(item);
        }

        public override void Remove(AbstractItem item)
        {
            items.Remove(item);
        }

        public override void Show()
        {
            foreach (var item in items)
            {
                item.Show();
            }
        }
    }
    class Item : AbstractItem
    {
        public Item(int price, string name)
        {
            Price = price;
            Name = name;
        }
        public int Price { get; set; }
        public string Name { get; set; }
        public override void Add(AbstractItem item)
        {
            throw new NotImplementedException();
        }

        public override void Remove(AbstractItem item)
        {
            throw new NotImplementedException();
        }
        public override void Show()
        {
            Console.WriteLine("================");
            Console.WriteLine($"Name {Name}");
            Console.WriteLine($"Price {Price}");
            Console.WriteLine("================");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Item toy = new Item(50, "Car");
            Item car = new Item(20, "BMW");
            Item car1 = new Item(20, "Mercedes");
            Item car2 = new Item(20, "Audi");
            Item obj = new Item(10, "Object");
            try
            {
                ItemBox itemBox = new ItemBox();
                itemBox.Add(toy); itemBox.Add(car); itemBox.Add(obj); itemBox.Add(car1);
                ItemBox newItemBox = new ItemBox();
                newItemBox.Add(itemBox); newItemBox.Add(car2);
                newItemBox.Show();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


        }
    }
}
