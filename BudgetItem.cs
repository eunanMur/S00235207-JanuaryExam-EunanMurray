using System.Windows.Controls;
using System;


namespace S00235207_JanuaryExam_EunanMurray
{
    //setting up Enum
    public enum BudgetItemType
   {
        Income,
        Expenses
    }

    //Setting up Data types and such as well as icomparable
    public class BudgetItem : IComparable
    {
        public string Name { get; set; }
        public decimal Amount { get; set; }
        public int Date { get; set; }

        public BudgetItemType Type { get; set; }
        public bool Recurring { get; set; }


        // Constructor to initialize an item with name, amount, date, type and recurring
        public BudgetItem(string name, decimal amount, int date, BudgetItemType type, bool reccuring)
        {
            Name = name;
            Amount = amount;
            Date = date;
            Type = type;
            Recurring = reccuring;
        }

        public BudgetItem()
        {
        }

        //to force into string for display
        public override string ToString()
        {
            return $"{Date} {Name} {Amount} - ({Type})";
        }

        // Method to compare items based on their date
        public int CompareTo(object obj)
        {
            if (obj == null) return 1;

            BudgetItem otherItem = obj as BudgetItem;
            if (otherItem != null)
                return Date.CompareTo(otherItem.Date);
            else
                throw new ArgumentException("Object is not a BudgetItem");
        }

        internal static void Add(BudgetItem budgetItem)
        {
            throw new NotImplementedException();
        }
    }
}