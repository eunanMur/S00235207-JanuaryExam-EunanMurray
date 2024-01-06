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
        }


        private void LoadBudgetData()
        {

            // Creating teams for France, Italy, and Spain and adding players to them
            BudgetItem.Add(new BudgetItem() { Name = "Grant", Amount = 300, Date = 5, recurr = BudgetItemType.Income});
        }

    }
}
