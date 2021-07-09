using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Project21040062.Entity
{
    public class Item
    {

        #region Variables
        // [ List ]
        public static List<Item> list;

        // [ Attributes ]
        public uint id { get; }
        public uint categoryId { get; set; }
        public string name { get; set; }
        public decimal price { get; set; }
        public uint stock { get; set; }
        #endregion

        #region Constructors
        public Item()
        {
            this.id = (uint)(list == null || list.Count == 0 ? 1 : list[^1].id + 1);
            categoryId = 1;
        }

        [JsonConstructor]
        public Item(uint id)
        {
            this.id = id;
        }
        #endregion

        #region Methods
        // Add new Item
        public static Item Add(uint categoryId, string name, decimal price, uint stock)
        {
            Item item = new Item()
            {
                categoryId = categoryId,
                name = name,
                price = price,
                stock = stock
            };

            list.Add(item);
            return item;
        }

        // Find an Item by ID
        public static Item FindById(uint id)
        {
            return list.Find(item => item.id == id);
        }

        // Remove an Item from the list by ID
        public static bool RemoveById(uint id)
        {
            return list.Remove(FindById(id));
        }

        // Edit item from the list
        public static void Edit(uint id, uint categoryId, string name, decimal price, uint stock)
        {
            Item item = FindById(id);
            item.categoryId = categoryId;
            item.name = name;
            item.price = price;
            item.stock = stock;
        }

        // Get Category object of an Item
        public Category GetCategory()
        {
            return Category.FindById(this.categoryId);
        }

        // Remove Specific Category from the Items to 1 (No Category)
        public static void RemoveCategory(uint categoryId)
        {
            List<Item> tempList = list.FindAll(item => item.categoryId == categoryId);
            foreach (Item item in tempList)
            {
                item.categoryId = 1;
            }
        }
        #endregion

    }
}
