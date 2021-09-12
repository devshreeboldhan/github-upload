using System;
using System.Collections.Generic;
using System.Data;
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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
           
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            textBox.Text = "i am clicked " + (new Random()).Next().ToString();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            label.Content = "cancel clicked " + (new Random()).Next().ToString();
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            label.Content = "Default clicked " + (new Random()).Next().ToString();

            var testString = "abc";

            string emptyString = null;

            try
            {
                var test1 = testString.StartsWith("a");

                var test2 = emptyString.StartsWith("a");

                //current

                1) projects where subject != ProjectNotToUpgradeToken

                    //expected
                    1) projects with subject = Null
                    2) projects where subject != ProjectNotToUpgradeToken



                    projects.Where(p => p.msdyn_subject == null || !p.msdyn_subject.StartsWith(ProjectNotToUpgradeToken)).ToList();
            }
            catch (Exception ex)
            {
                var exception = ex.Message;
                throw;
            }

        }
    }
}
