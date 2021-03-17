using System;
using System.Collections;
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

namespace Lecture80_ArrayListApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ArrayList arrayList;
        public MainWindow()
        {
            InitializeComponent();
            arrayList = new ArrayList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //Add Data
            /*arrayList.Add(10);
            arrayList.Add(11);
            arrayList.Add(12);
            arrayList.Add(10);
            arrayList.Add(13);
            arrayList.Add(14);*/

            //data for sort
            arrayList.Add(13);
            arrayList.Add(15);
            arrayList.Add(14);
            arrayList.Add(12);
            arrayList.Add(16);
            arrayList.Add(11);

            //Show Data 
            foreach (int data in arrayList)
            {
                MessageBox.Show(data.ToString());
            }
            /*
            //Count
            MessageBox.Show("Count : " + arrayList.Count.ToString());

            //Remove : ลบ object ex. ลบค่า 10 ที่เจอตัวแรกเท่านั้น
            arrayList.Remove(10);
            foreach (int data in arrayList)
            {
                MessageBox.Show(data.ToString());
            }*/

            //Remove At : ลบตาม Index ที่ระบุ
            /*arrayList.RemoveAt(2);
            foreach (int data in arrayList)
            {
                MessageBox.Show(data.ToString());
            }*/

            //Sort
            arrayList.Sort();
            foreach (int data in arrayList)
            {
                MessageBox.Show(data.ToString());
            }

            //Clear All data
            arrayList.Clear();
            
        }
    }
}
