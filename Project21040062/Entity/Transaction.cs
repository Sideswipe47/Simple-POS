using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Project21040062.Entity
{

    // [ Main Class ]
    public class Transaction
    {

        #region Variables
        // [ List ]
        public static List<Transaction> list;

        // [ Attributes ]
        public uint id { get; }
        public uint employeeId { get; set; }
        public DateTime time { get; }
        public string note { get; }
        public List<TransactionItem> items { get; }
        #endregion

        #region Constructors
        public Transaction(string note, List<TransactionItem> items)
        {
            this.id = (uint)(list == null || list.Count == 0 ? 1 : list[^1].id + 1);
            this.employeeId = Program.user.id;
            this.time = DateTime.Now;
            this.note = note;
            this.items = new List<TransactionItem>(items);
        }

        [JsonConstructor]
        public Transaction(uint id, uint employeeId, DateTime time, string note, List<TransactionItem> items)
        {
            this.id = id;
            this.employeeId = employeeId;
            this.time = time;
            this.note = note;
            this.items = items;
        }
        #endregion

        #region Methods
        // Add new Transaction
        public static Transaction Add(string note, List<TransactionItem> items)
        {
            Transaction transaction = new Transaction(note, items);
            list.Add(transaction);
            return transaction;
        }

        // Find Transaction by Id
        public static Transaction FindById(uint id)
        {
            return list.Find(transaction => transaction.id == id);
        }

        // Get Employee object of a Transaction
        public Employee GetEmployee()
        {
            return Employee.FindById(employeeId);
        }

        // Get Total Price from all the items
        public decimal GetTotal()
        {
            decimal total = 0;
            foreach (TransactionItem item in items)
            {
                total += item.SubTotal();
            }
            return total;
        }
        #endregion

    }

    // Class for items that are included in the Transaction
    public class TransactionItem
    {

        #region Variables
        // [ Attributes ]
        public string itemName { get; }
        public uint quantity { get; set; }
        public decimal price { get; }
        #endregion

        #region Constructors
        public TransactionItem() { }

        [JsonConstructor]
        public TransactionItem(string itemName, uint quantity, decimal price)
        {
            this.itemName = itemName;
            this.quantity = quantity;
            this.price = price;
        }
        #endregion

        #region Methods
        // Get Subtotal of the Item on the Order
        public decimal SubTotal() { return price * quantity; }
        #endregion

    }

}
