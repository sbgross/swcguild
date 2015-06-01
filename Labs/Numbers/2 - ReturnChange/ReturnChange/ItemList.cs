using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReturnChange
{
    public class ItemList
    {
        private static List<Item> _items;

        static ItemList()
        {
            _items = new List<Item>()
            {
                new Item() {ItemId = 1, ItemName = "Cheerios", ItemCost = 4.12M},
                new Item() {ItemId = 2, ItemName = "Bread", ItemCost = 2.75M},
                new Item() {ItemId = 3, ItemName = "Milk", ItemCost = 3.10M},
                new Item() {ItemId = 4, ItemName = "Cheese", ItemCost = 5.50M},
                new Item() {ItemId = 5, ItemName = "Salmon", ItemCost = 17.22M}                
            };
        }

        public List<Item> GetAll()
        {
            return _items;
        }
    }
}
