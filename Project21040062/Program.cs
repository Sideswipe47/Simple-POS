using Project21040062.Entity;
using Project21040062.Function;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace Project21040062
{

    static class Program
    {

        #region Variables
        public static Employee user; // The current User for the app
        #endregion

        #region Constructors
        [STAThread]
        static void Main()
        {

            // Load Data and Initialize important lists if empty
            LoadAllData();
            InitRoles();
            InitCategory();

            /* Testing Purposes
            if (Employee.list.Count != 0) { user = Employee.list[0]; }
            GenerateDummyData<Employee>(Employee.list, 50);
            GenerateDummyData<Role>(Role.list, 50);
            GenerateDummyData<Item>(Item.list, 25);
            */

            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormMain());

            // Save All Data on Exit
            SaveAllData();

        }
        #endregion

        #region Methods
        // Load All Data for the application
        static void LoadAllData()
        {
            ApplicationData.appData = Data.LoadData<ApplicationData>();
            Employee.list = Data.LoadList<Employee>();
            Category.list = Data.LoadList<Category>();
            Item.list = Data.LoadList<Item>();
            Role.list = Data.LoadList<Role>();
            Transaction.list = Data.LoadList<Transaction>();
        }

        // Initialze Admin and Empty Role
        static void InitRoles()
        {
            if (Role.FindById(1) == null) {
                Role admin = new Role() { name = "Admin" };
                foreach (PropertyInfo prop in admin.GetType().GetProperties())
                {
                    if (prop.PropertyType == typeof(bool)) { prop.SetValue(admin, true); }
                }
                Role.list.Add(admin);
            }

            if (Role.FindById(2) == null)
            {
                Role noRole = new Role() { name = "No Role" };
                foreach (PropertyInfo prop in noRole.GetType().GetProperties())
                {
                    if (prop.PropertyType == typeof(bool)) { prop.SetValue(noRole, false); }
                }
                Role.list.Add(noRole);
            }
        }

        // Initialize No Category
        static void InitCategory()
        {
            if (Category.FindById(1) != null) { return; }

            Category noCategory = new Category() { name = "No Category" };
            Category.list.Add(noCategory);
        }

        // Save All Data related to the application
        static void SaveAllData()
        {
            Data.SaveData<ApplicationData>(ApplicationData.appData);
            Data.SaveList<Employee>(Employee.list);
            Data.SaveList<Category>(Category.list);
            Data.SaveList<Item>(Item.list);
            Data.SaveList<Role>(Role.list);
            Data.SaveList<Transaction>(Transaction.list);
        }

        // Method for inserting dummy data to a list
        static void GenerateDummyData<T>(List<T> list, int size)
        {

            Random rand = new Random();
            string characters = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";

            for (int i = 0; i < size; ++i)
            {
                T obj = (T)Activator.CreateInstance(typeof(T));
                foreach (PropertyInfo prop in obj.GetType().GetProperties())
                {
                    if (prop.PropertyType == typeof(bool)) { prop.SetValue(obj, rand.Next(2) == 1); }
                    else if (prop.PropertyType == typeof(string)) { prop.SetValue(obj, new string(Enumerable.Repeat(characters, rand.Next(3, 11)).Select(s => s[rand.Next(s.Length)]).ToArray())); }
                    else if (prop.PropertyType == typeof(decimal)) { prop.SetValue(obj, Convert.ToDecimal(rand.Next(10000))); }
                }
                list.Add(obj);
            }
        }
        #endregion

    }
}
