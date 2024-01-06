using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace S00235207_JanuaryExam_EunanMurray
{
    /*Name: ObjectOrientedProgramming JanExam 
    Author: Eunan Murray 
    Date Created: 06/01/2024 
    Purpose: */

    public partial class MainWindow : Window
    {
        private List<BudgetItem> allBudgetItems = new List<BudgetItem>();
        public MainWindow()
        {
            InitializeComponent();
            LoadBudgetData();
            DisplayData();
        }


        private void LoadBudgetData()
        {

            // Creating teams for France, Italy, and Spain and adding players to them
            allBudgetItems.Add(new BudgetItem() {Name = "Grant", Amount = 300, Date = 5, Type = BudgetItemType.Income, Recurring = true});
            allBudgetItems.Add(new BudgetItem() { Name = "Bonus", Amount = 300, Date = 15, Type = BudgetItemType.Income, Recurring = false });
            allBudgetItems.Add(new BudgetItem() { Name = "Wages", Amount = 100, Date = 25, Type = BudgetItemType.Income, Recurring = true });
            allBudgetItems.Add(new BudgetItem() { Name = "Rent", Amount = 400, Date = 1, Type = BudgetItemType.Expenses, Recurring = true });
            allBudgetItems.Add(new BudgetItem() { Name = "Flight", Amount = 100, Date = 5, Type = BudgetItemType.Expenses, Recurring = false });
            allBudgetItems.Add(new BudgetItem() { Name = "Netflix", Amount = 10, Date = 15, Type = BudgetItemType.Expenses, Recurring = true });
            allBudgetItems.Add(new BudgetItem() { Name = "Spotify", Amount = 8, Date = 20, Type = BudgetItemType.Expenses, Recurring = true });

        }

        private void DisplayData()
        {
            lstIncome.Items.Clear();
            foreach (var item in allBudgetItems)
            {
                if (item.Type == BudgetItemType.Income)
                {
                    lstIncome.Items.Add(item);
                }

                else
                {
                    lstExpenses.Items.Add(item);
                }
            }
        }

        private void txtAmount_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
