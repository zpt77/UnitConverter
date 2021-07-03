using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using UnitConverter2;
using UnitConverter.logic.Model;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Core.Objects;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using UnitConverter.logic;
using System.Threading;


namespace UnitConverter.Desktop
{
    /// <summary>
    /// Logika interakcji dla klasy StatWindow.xaml
    /// </summary>
    public partial class StatWindow : Window
    {
        
        public StatWindow()
        {
            InitializeComponent();
            
            FillDataGrid();
            
            IConverter[] converter = converters();
            List<string> measures = new List<string>();
            for (int i = 0; i < converter.Length; i++)
            {
                measures.Add(converter[i].Name);
            }
            FilterComboBox.ItemsSource = measures;

        }

        private void FillDataGrid()
        {
            
            string ConString = "Data Source=localhost;Initial Catalog=JippDB;Integrated Security=True";
                string CmdString = string.Empty;
                using (SqlConnection con = new SqlConnection(ConString))
                {
                //Thread.Sleep(200);
                CmdString = "SELECT * FROM [JippDB].[dbo].[Statistics]";
                    SqlCommand cmd = new SqlCommand(CmdString, con);
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();

                  

                    sda.Fill(dt);
               
                Table.ItemsSource = dt.DefaultView;
                    cmd.Dispose();
                    con.Close();
                }


            
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
           

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string ConString = "Data Source=localhost;Initial Catalog=JippDB;Integrated Security=True";
            string CmdString = string.Empty;
            using (SqlConnection con = new SqlConnection(ConString))
            {
                CmdString = "SELECT * FROM [JippDB].[dbo].[Statistics] " +
                    "WHERE Measure = '" + FilterComboBox.SelectedItem + "'";
                SqlCommand cmd = new SqlCommand(CmdString, con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                Table.ItemsSource = dt.DefaultView;
                cmd.Dispose();
                con.Close();
            }
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        public IConverter[] converters()
        {
            IConverter[] converters = new IConverter[]
            {
                new TemperatureConverter(),
                new WeightConverter(),
                new UnitConverter2.LengthConverter(),
                new VolumeConverter(),
                new TimeConverter()


            };
            return converters;
        }
    }
}
