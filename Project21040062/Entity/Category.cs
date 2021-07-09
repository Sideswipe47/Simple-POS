using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Project21040062.Entity
{
    public class Category
    {

        #region Variables
        // [ List ]
        public static List<Category> list;

        // [ Attributes ]
        public uint id { get; }
        public string name { get; set; }
        #endregion

        #region Constructors
        public Category()
        {
            this.id = (uint)(list == null || list.Count == 0 ? 1 : list[^1].id + 1);
        }

        [JsonConstructor]
        public Category(uint id)
        {
            this.id = id;
        }

        // [ Methods ]

        // Add New Category
        public static Category Add(string name)
        {
            Category category = new Category()
            {
                name = name
            };

            list.Add(category);
            return category;
        }

        // Find Category by ID
        public static Category FindById(uint id)
        {
            return list.Find(obj => obj.id == id);
        }

        // Remove a Category from the list by ID
        public static bool RemoveById(uint id)
        {
            if (id == 1) { return false; }

            Item.RemoveCategory(id);
            return list.Remove(FindById(id));
        }
        #endregion

    }
}
