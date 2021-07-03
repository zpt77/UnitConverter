using System;

namespace UnitConverter2
{
    class Program
    {
        static void Main(string[] args)
        {
            IConverter[] converters = new IConverter[] // ADD CONVERTER TO ARRAY
            {
                new TemperatureConverter(),
                new WeightConverter(),
                new LengthConverter(),
                new VolumeConverter()
                
            };

            Console.WriteLine("Wybierz miarę konwersji:");
            for(int i = 0; i < converters.Length; i++)
            {
                Console.WriteLine("(" + i + ")" + converters[i].Name);
            }

            int conv = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Wybierz miarę początkową:");
            for(int i = 0; i < converters[conv].Units.Count; i++)
            {
                Console.WriteLine("(" + i + ")" + converters[conv].Units[i]);
            }
           int input = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Wybierz miarę końcową:");
            for (int i = 0; i < converters[conv].Units.Count; i++)
            {
                Console.WriteLine("(" + i + ")" + converters[conv].Units[i]);
            }
            int output = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj wartość do konwersji:");
            double value = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(converters[conv].Convert(value, converters[conv].Units[input], converters[conv].Units[output]) +" " + converters[conv].Units[output]);

            /*
            Rozwinąć aplikację(stworzoną w wyniku zadania z poprzedniego zjazdu) o:

- konwersję dodatkowej jednostki w ramach istniejących konwerterów(np.metry na kilometry)
- dodatkowy konwerter(innej kategorii, inspiracje można czerpać z https://www.jednostek.pl)
- kod aplikacji powinien wykorzystywać interfejsy
- logika aplikacji powinna być umieszczona w oddzielnej bibliotece DLL
- stworzyć aplikację okienkową(WPF), która korzysta z powyższej biblioteki DLL(współdzieli logikę z aplikacją konsolową)
    Do opublikowanego zadania na platformie Teams zamieścić plik PDF, który zawiera:
    kod źródłowy projektu
    screenshot / y działającej aplikacj*/

        }
    }
}
