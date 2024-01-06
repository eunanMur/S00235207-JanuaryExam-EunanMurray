using System.Windows.Controls;
using System;


namespace S00235207_JanuaryExam_EunanMurray
{
    public enum BudgetItemType
   {
        Income,
        Expenses
    }


    public class BudgetItem : IComparable
    {
        public string Name { get; set; }
        public decimal Amount { get; set; }
        public int Date { get; set; }

        public BudgetItemType Type { get; set; }
        public bool Recurring { get; set; }


        // Constructor to initialize a member with a first name, surname, and date of birth
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

        // Q7: Override ToString to display player information in the ListBox
        // Format: "FirstName LastName (Age) POSITION"
        public override string ToString()
        {
            return $"{Date} {Name} {Amount} - ({Type})";
        }

        // Method to compare members based on their surname
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