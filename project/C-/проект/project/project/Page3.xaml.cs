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

namespace project
{
    /// <summary>
    /// Логика взаимодействия для Page3.xaml
    /// </summary>
    ///

    public partial class Page3 : Page
    {
        public Page3()
        {
            InitializeComponent();
        }

        List<Order> orderArr = new List<Order>();
        int counter = 1;

        private void Button_Click(object sender, RoutedEventArgs e)
        {
                int p = 1;
                if (input1.Text == "1") { p = 10; }
                else if (input1.Text == "2") { p = 20; }
                else if (input1.Text == "3") { p = 30; }
                else if (input1.Text == "4") { p = 40; }
                else if (input1.Text == "5") { p = 50; }

                Order added = new Order();
                added.type = Convert.ToInt32(input1.Text);
                added.quantity = Convert.ToInt32(input2.Text);
                added.counter = counter;

                orderArr.Add(added);

                output.Text = "";
                foreach (Order s in orderArr)
                {
                    output.Text += s.counter +" ,тип= "+ s.type + " ,к-сть= " + s.quantity + " ,ціна= " +
                        s.quantity*p + "\n";
                }
                counter++;
        }
    }
}
