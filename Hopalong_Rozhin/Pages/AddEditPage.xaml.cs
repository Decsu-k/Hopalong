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
    /// Логика взаимодействия для AddEditPage.xaml
    /// </summary>
    public partial class AddEditPage : Page
    {
        private Agent _currentAgent = new Agent();
        public AddEditPage(Agent selectedAgent)
        {
            InitializeComponent();

            if (selectedAgent != null)
                _currentAgent = selectedAgent;

            DataContext = _currentAgent;
        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder errors = new StringBuilder();

            if (string.IsNullOrWhiteSpace(_currentAgent.NameCompany))
                errors.AppendLine("Укажите название отеля");
            if (string.IsNullOrWhiteSpace(_currentAgent.Phone))
                errors.AppendLine("Укажите номер телефона");

            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString());
                return;
            }
            if (_currentAgent.ID == 0)
                tren2_RozhinEntities.GetContext().Agent.Add(_currentAgent);

            try
            {
                tren2_RozhinEntities.GetContext().SaveChanges();
                MessageBox.Show("Информация сохранена!");
                Manager.MainFrame.GoBack();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            
        }
    }
}
