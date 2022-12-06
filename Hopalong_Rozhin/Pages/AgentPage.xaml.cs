using Hopalong_Rozhin.AppDataFile;
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

namespace Hopalong_Rozhin.Pages
{
    /// <summary>
    /// Логика взаимодействия для AgentPage.xaml
    /// </summary>
    public partial class AgentPage : Page
    {
        public AgentPage()
        {
            InitializeComponent();

            var allType = tren2_RozhinEntities.GetContext().Agent.ToList();
            allType.Insert(0, new Agent
            {
                NameCompany = "Все агенты"
            });
            ComboType.ItemsSource = allType;

            ComboType.SelectedIndex = 0;

            UpdateAgent();
        }

        private void UpdateAgent()
        {
            var currentAgent = tren2_RozhinEntities.GetContext().Agent.ToList();

            //if (ComboType.SelectedIndex > 0)
            //    currentAgent = currentAgent.Where(p => p.TypeAgent.Contains(ComboType.SelectedItem as Agent)).ToList();

            currentAgent = currentAgent.Where(p => p.NameCompany.ToLower().Contains(TBoxSearch.Text.ToLower())).ToList();

            //if (CheckActual.IsChecked.Value)
            //    currentTours = currentToues.Where(p => IsActual).ToList();

            LViewAgent.ItemsSource = currentAgent.OrderBy(p => p.NameCompany).ToList();

        }

        private void TBoxSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            UpdateAgent();
        }

        private void ComboType_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            UpdateAgent();
        }
    }
}
