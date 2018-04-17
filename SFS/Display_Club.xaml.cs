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
using System.Windows.Shapes;

namespace SFS
{
    /// <summary>
    /// Interaction logic for Display_Club.xaml
    /// </summary>
    public partial class Display_Club : Window
    {
        public Display_Club()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            if (textBox.Text == "")
            {
                MessageBox.Show("Please fill the required information");
            }
            else
            {
                List<string> cname = new List<string>();
                List<string> sdate = new List<string>();

                for (int i = 0; i < Containers.Club_list.Count; i++)
                {
                    if (textBox.Text == Containers.Club_list[i].getClubName())
                    {
                        cname.Add(Containers.Club_list[i].getClubName());
                        sdate.Add(Containers.Club_list[i].getStartingDate());

                    }
                }
                listBox.ItemsSource = cname;
                listBox_Copy.ItemsSource = sdate;


            }
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {

            List<Team> tlist = new List<Team>();
            List<Championships> chlist = new List<Championships>();
            List<Sponsers> slist = new List<Sponsers>();
            List<string> cname = new List<string>();
            List<string> sdate = new List<string>();
            for (int i = 0; i < Containers.Club_list.Count; i++)
            {
                
                    cname.Add(Containers.Club_list[i].getClubName());
                    sdate.Add(Containers.Club_list[i].getStartingDate());

                
            }
            listBox.ItemsSource = cname;
            listBox_Copy.ItemsSource = sdate;


        }

    }
}
