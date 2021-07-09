using System.Collections.Generic;
using System.Reflection;
using static System.Windows.Forms.CheckedListBox;
using System.Text.Json.Serialization;

namespace Project21040062.Entity
{
    public class Role
    {

        #region Variables
        // [ List ]
        public static List<Role> list;

        // [ Attributes ]
        public uint id { get;}
        public string name { get; set; }

        // [ Rules / Permissions ]
        public bool manageOrder { get; set; }
        public bool manageRoles { get; set; }
        public bool manageEmployees { get; set; }
        public bool viewCategories { get; set; }
        public bool manageCategories { get; set; }
        public bool viewItems { get; set; }
        public bool manageItems { get; set; }
        public bool viewTransactions { get; set; }
        #endregion

        #region Constructors
        public Role()
        {
            this.id = (uint)(list == null || list.Count == 0 ? 1 : list[^1].id + 1);
        }

        [JsonConstructor]
        public Role(uint id) {
            this.id = id;
        }
        #endregion

        #region Methods
        // Add new Role
        public static Role Add(string name, CheckedIndexCollection items)
        {
            Role role = new Role()
            {
                name = name
            };

            // Set Boolean from the class
            int count = 0;
            int index = 0;
            foreach (PropertyInfo prop in role.GetType().GetProperties())
            {
                if (prop.PropertyType == typeof(bool))
                {
                    bool isChecked = (index < items.Count && count++ == items[index]);
                    if (isChecked)
                    {
                        prop.SetValue(role, true);
                        ++index;
                    }
                    else
                    {
                        prop.SetValue(role, false);
                    }
                }
            }

            list.Add(role);
            return role;
        }

        // Find Role by ID
        public static Role FindById(uint id)
        {
            return list.Find(obj => obj.id == id);
        }

        // Remove a Role from the list by ID
        public static bool RemoveById(uint id)
        {
            if (id == 1) { return false; }

            Employee.RemoveRole(id);
            return list.Remove(FindById(id));
        }
        #endregion

    }
}
