using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory5__2
{
    public class Koord
    {
        public int angle {  get; set; }
        public float minute { get; set; }
        public char direction { get; set; }
        public double answer { get; set; }

        public void Read()
        {
            Console.WriteLine("Введите направление для широты (N,S) для долготы (E,W): ");
            string userdirection = Console.ReadLine();
            direction = Convert.ToChar(userdirection);

            string userangle;
            switch (direction)
            {
                case 'E':
                    Console.WriteLine("Введите градус 0-180");
                    userangle = Console.ReadLine();
                    angle = Convert.ToInt32(userangle);
                    break;
                case 'W':
                    Console.WriteLine("Введите градус 0-180");
                    userangle = Console.ReadLine();
                    angle = Convert.ToInt32(userangle);
                    break;
                case 'N':
                    Console.WriteLine("Введите градус 0-90");
                    userangle = Console.ReadLine();
                    angle = Convert.ToInt32(userangle);
                    break;
                case 'S':
                    Console.WriteLine("Введите градус 0-90");
                    userangle = Console.ReadLine();
                    angle = Convert.ToInt32(userangle);
                    break;
            }

            Console.Write("Введите минуту: ");
            string userminute = Console.ReadLine();
            minute = Convert.ToSingle(userminute);
        }

        public void Display()
        {
            Console.WriteLine($"Расстояние между точками {answer}");
        }

        public void Calculate(Koord lat1, Koord lon1, Koord lat2, Koord lon2)
        {
            double ToDouble(Koord coord)
            {
                double value = coord.angle + (coord.minute / 60.0);
                if (coord.direction == 'S' || coord.direction == 'W')
                {
                    return -value;
                }
                return value;
            }

            double lat1_d = ToDouble(lat1);
            double lon1_d = ToDouble(lon1);
            double lat2_d = ToDouble(lat2);
            double lon2_d = ToDouble(lon2);

            double minuslat = Math.Abs(lat2_d - lat1_d);
            double minuslon = Math.Abs(lon2_d - lon1_d);

            double avglat = (Math.Abs(lat1_d) + Math.Abs(lat2_d)) / 2;
            double avglatradian = avglat * Math.PI / 180;

            const double WorkLength = 111;

            double distancelat = minuslat * WorkLength;
            double distancelon = minuslon * WorkLength * Math.Cos(avglatradian);

            answer = Math.Sqrt(distancelat * distancelat + distancelon * distancelon);
        }
    }
}
