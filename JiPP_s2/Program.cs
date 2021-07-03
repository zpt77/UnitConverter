using System;

namespace JiPP_s2
{
    class Program
    {

        static String Conv(String conv_option, double conv_value, String conv_unit)
        {
            String out_unit="";
            switch (conv_unit)
            {
                case "1":
                    conv_value = (conv_value * 1.8) + 32;
                    out_unit = "F";
                    break;
                case "2":
                    conv_value = (conv_value - 32) / 1.8;
                    out_unit = "C";
                    break;
                case "3":
                    conv_value = conv_value *0.621;
                    out_unit = "mil";
                    break;
                case "4":
                    conv_value = conv_value * 1.6;
                    out_unit = "km";
                    break;
                case "5":
                    conv_value = conv_value * 2.2046;
                    out_unit = "lb";
                    break;
                case "6":
                    conv_value = conv_value / 2.2046;
                    out_unit = "kg";
                    break;
            }
            String result = conv_value + " " + out_unit;

            return result;
        }
        static void Main(string[] args)
        {

            Console.WriteLine("Wybierz rodzaj konwersji podając odpowiedni numer opcji:\n1.Temperatura\n2.Długość\n3.Masa");
            String conv_option = Console.ReadLine();
            
            Console.WriteLine("Wybierz jednostkę wyjściową konwersji:");

            if(conv_option == "1")
            {
                Console.WriteLine("1.Stopnie Celsjusza\n2.Stopnie Farenheita");
            } else if(conv_option == "2")
            {
                Console.WriteLine("3.Kilometry\n4.Mile");
            } else if(conv_option == "3")
            {
                Console.WriteLine("5.Kilogramy\n6.Funty");
            }
            String conv_unit = Console.ReadLine();
            Console.WriteLine("Podaj wartość, którą chcesz poddać konwersji:");
            double val = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(Conv(conv_option, val, conv_unit));


        }
    }
}
