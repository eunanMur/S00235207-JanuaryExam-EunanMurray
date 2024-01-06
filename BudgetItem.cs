using System.Windows.Controls;
using System;



namespace S00235207_JanuaryExam_EunanMurray
{
        public enum BudgetItemType
        {
            Income,
            Expense
        }


    // Q4: Player class which includes properties and a calculated Age
    internal class BudgetItem
    {
        public string Name { get; set; }
        public decimal Amount { get; set; }
        public int Date { get; set; }
        public BudgetItemType recurr { get; set; }
        public bool Recurring { get; set; }

        // Q4: Constructor for Player class
        public BudgetItem(string name, decimal amount, BudgetItemType recur, int date)
        {
            Name = name;
            Amount = amount;
            recurr = recur;
            Date = date;
        }

        // Q7: Override ToString to display player information in the ListBox
        // Format: "FirstName LastName (Age) POSITION"
        public override string ToString()
        {
            return $"{Date} {Name} {Amount} {recurr.ToString()}";
        }
    }
}
