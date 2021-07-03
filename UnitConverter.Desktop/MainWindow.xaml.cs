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
using System.Windows.Threading;
using UnitConverter2;
using UnitConverter.logic.Model;
using System.Data.SqlClient;
using Microsoft.EntityFrameworkCore.SqlServer;
using System.Configuration;
using System.Data;
using System.Threading;
using System.ComponentModel;

namespace UnitConverter.Desktop
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            IConverter[]converter = converters();
            List<string> measures = new List<string>();
            for(int i = 0; i < converter.Length; i++)
            {
                measures.Add(converter[i].Name);
            }
            measureComboBox.ItemsSource = measures;
            measureComboBox.SelectedItem = converter[0].Name;
            
            for (int i = 0; i < converter.Length; i++)
            {
                if (measureComboBox.SelectedItem.ToString() == converter[i].Name)
                {
                    inputUnitComboBox.ItemsSource = converter[i].Units;
                    outputUnitComboBox.ItemsSource = converter[i].Units;
                }
            }

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


        

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            IConverter[] converter = converters();
            string inputText = inputTextBox.Text;



            for (int i = 0; i < converter.Length; i++)
            {
                if (converter[i].Name == measureComboBox.SelectedItem.ToString())
                {
                    switch (converter[i].Flag)
                    {
                        case 'd':
                            double input = double.Parse(inputText);
                            outputTextBlock.Text = converter[i].Convert(input, inputUnitComboBox.SelectedItem.ToString(), outputUnitComboBox.SelectedItem.ToString()).ToString();
                            break;
                        case 's':
                            outputTextBlock.Text = converter[i].Convert(inputText, inputUnitComboBox.SelectedItem.ToString(), outputUnitComboBox.SelectedItem.ToString()).ToString();
                            break;
                    }
                }
            }

            using (var context = new JippDBContext())
            {
                var stat = new Statistics
                {
                    Measure = measureComboBox.SelectedItem.ToString(),
                    InputUnit = inputUnitComboBox.SelectedItem.ToString(),
                    OutputUnit = outputUnitComboBox.SelectedItem.ToString(),
                    Value = inputText,
                    Output = outputTextBlock.Text,
                    ConversionDate = DateTime.Now
                };
                context.Statistics.Add(stat);
                context.SaveChanges();
            }

            
        }

   

        private void measureComboBox_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
            IConverter[] converter = converters();
            for (int i = 0; i < converter.Length; i++)
            {
                if (measureComboBox.SelectedItem.ToString() == converter[i].Name)
                {
                    inputUnitComboBox.ItemsSource = converter[i].Units;
                    outputUnitComboBox.ItemsSource = converter[i].Units;
                }
            }
        }

       private void Button_Click_2(object sender, RoutedEventArgs e)
       { 
            BackgroundWorker worker = new BackgroundWorker();
            worker.WorkerReportsProgress = true;
            worker.DoWork += worker_DoWork;
            worker.ProgressChanged += worker_ProgressChanged;

            worker.RunWorkerAsync();
        }


        void worker_DoWork(object sender, DoWorkEventArgs e)
        {
            
            for (int i = 0; i < 100; i++)
            {
                
                (sender as BackgroundWorker).ReportProgress(i);
                
                Thread.Sleep(50);
            }
        }

        void worker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            
            pbStatus.Value = e.ProgressPercentage;
            
            LoadingLabel.Content = "Proszę czekać" + dotsForLoading(pbStatus.Value);
            if (pbStatus.Value == pbStatus.Maximum-1)
            {
                LoadingLabel.Content = "Gotowe";
                StatWindow statWindow = new StatWindow();
                statWindow.Show();
            }
        }

        String dotsForLoading(double progress)
        {
            String dots="";
            switch (progress % 5)
            {
                case 1:
                    dots = ".";
                    break;
                case 2:
                    dots = "..";
                    break;
                case 3:
                    dots = "...";
                    break;
                case 4:
                    dots = "....";
                    break;
                case 0:
                    dots = ".....";
                    break;
            }
            return dots;
        }

        private void ProgressBar_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {

        }
    }
}
