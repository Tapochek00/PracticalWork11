using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace PracticalWork11
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn_Fill_Click(object sender, RoutedEventArgs e)
        {
            str.Text = "ave a#b a2b a$b a4b a5b a-b acb";
        }

        private void btn_Find_Click(object sender, RoutedEventArgs e)
        {
            result.Items.Clear();
            string s = str.Text;
            Regex regex = new Regex("a[^0-9a-zA-Z]b");
            MatchCollection matches = regex.Matches(s);
            if (matches.Count > 0)
            {
                for (int i = 0; i < matches.Count; i++)
                    result.Items.Add(matches[i].Value);
            }
            else MessageBox.Show("Совпадений не найдено");
        }
    }
}
