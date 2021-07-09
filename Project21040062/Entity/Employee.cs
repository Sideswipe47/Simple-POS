using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Project21040062.Entity
{
    public class Employee
    {

        #region Variables
        // [ List ]
        public static List<Employee> list;

        // [ Attributes ]
        public uint id { get; }
        public uint roleId { get; set; }
        public DateTime createdAt { get; }
        public string name { get; set; }
        public string email { get; }
        public string password { get; set; }
        public decimal salary { get; set; }
        #endregion

        #region Constructors
        public Employee()
        {
            this.id = ApplicationData.appData.GetEmployeeId();
            this.createdAt = DateTime.Now;
            this.roleId = 2;
        }

        public Employee(string email)
        {
            this.id = ApplicationData.appData.GetEmployeeId();
            this.createdAt = DateTime.Now;
            this.roleId = 2;
            this.email = email;
        }

        [JsonConstructor]
        public Employee(uint id, DateTime createdAt, string email)
        {
            this.id = id;
            this.createdAt = createdAt;
            this.email = email;
        }
        #endregion

        #region Methods
        // Add New Employee
        public static Employee Add(uint roleId, string name, string email, string password, decimal salary)
        {
            Employee employee = new Employee(email)
            {
                roleId = roleId,
                name = name,
                password = password,
                salary = salary
            };

            list.Add(employee);
            return employee;
        }

        // Find an employee by ID
        public static Employee FindById(uint id)
        {
            return list.Find(employee => employee.id == id);
        }

        // Find an employee by email
        public static Employee FindByEmail(string email)
        {
            return list.Find(employee => (employee.email.ToLower() == email.ToLower()));
        }

        // Find an employee by email and password
        public static Employee FindByEmailAndPassword(string email, string password)
        {
            return list.Find(employee => (employee.email.ToLower() == email.ToLower()) && (employee.password == password));
        }

        // Remove Specific Role from the Employees and replace it with 2 (No Role)
        public static void RemoveRole(uint roleId)
        {
            List<Employee> tempList = list.FindAll(employee => employee.roleId == roleId);
            foreach (Employee employee in tempList)
            {
                employee.roleId = 2;
            }
        }

        // Edit Employee from the list
        public static void Edit(uint id, uint roleId, string name, string password, decimal salary)
        {
            Employee employee = FindById(id);
            employee.roleId = roleId;
            employee.name = name;
            employee.password = password;
            employee.salary = salary;
        }

        // Remove an employee from the list by ID
        public static bool RemoveById(uint id)
        {
            if (id == 1) { return false; }

            return list.Remove(FindById(id));
        }

        // Get Role object of an employee
        public Role GetRole()
        {
            return Role.FindById(this.roleId);
        }
        #endregion

    }
}
