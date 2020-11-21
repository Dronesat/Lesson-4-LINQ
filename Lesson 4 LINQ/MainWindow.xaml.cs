using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace Lesson_4_LINQ
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<int> lstRandom1 = new List<int>();
        List<int> lstRandom2 = new List<int>();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnGenerate2(object sender, RoutedEventArgs e)
        {
            //Generate random number generator
            Random r = new Random();

            //Populate the two lists with 10 random numbers
            for (int i = 0; i < 10; i++)
            {
                lstRandom1.Add(r.Next(0, 11));
                lstRandom2.Add(r.Next(0, 11));
            }

            // Sort the two lists
            lstRandom1.Sort();
            lstRandom2.Sort();

            //Update the display
            foreach (int temp in lstRandom1)
                lstNum1.Items.Add(temp);
            foreach (int temp in lstRandom2)
                lstNum2.Items.Add(temp);

        }

        private void btnUnique_Click(object sender, RoutedEventArgs e)
        {
            //Create two new unique lists
            List<int> lstTemp1 = lstRandom1.Except(lstRandom2).ToList();
            List<int> lstTemp2 = lstRandom2.Except(lstRandom1).ToList();

            //Update display
            foreach (int temp in lstTemp1)
                lstUnique1.Items.Add(temp);
            foreach (int temp in lstTemp2)
                lstUnique2.Items.Add(temp);
        }

        private void btnIntersect_Click(object sender, RoutedEventArgs e)
        {
            //Create a new list of intersecting values
            List<int> lstTemp1 = lstRandom1.Intersect(lstRandom2).ToList();

            //Update Display
            foreach (int temp in lstTemp1)
                lstIntersect.Items.Add(temp);
        }

        private void btnUnion_Click(object sender, RoutedEventArgs e)
        {
            //Create new union list
            List<int> lstTemp1 = lstRandom1.Union(lstRandom2).ToList();

            //Update display
            foreach (int temp in lstTemp1)
                lstUnion.Items.Add(temp);
        }
    }
}
