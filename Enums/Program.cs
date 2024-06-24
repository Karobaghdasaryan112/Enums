using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Enums
{
    internal class Program
    {


        [Flags]
        enum Weather
        {
            Sunny = 1,
            Cloudy = 2,
            Rainy = 4
        }






        public enum Vehicle
        {
            car,
            Bus,
            Bicycle
        }






        [Flags]
        public enum UserRole
        {
            None = 0,
            Admin = 1 << 0,
            Moderator = 1 << 1,
            User = 1 << 2,
            Editor = 1 << 3,
            Viewer = 1 << 4,
            Manager = 1 << 5,
            
        }
        public static int ReturnDb(int Number)
        {
            string str = Convert.ToString(Number,2);
            return int.Parse(str);
        }



        public enum Languages
        {
            English = 1,
            Spanish = 2,
            French = 3,
            Armenian = 4
        }
        public static string TranslateWord(string word,Languages lang)
        {
            switch (lang)
            {
                case Languages.English:
                    return word;
                case Languages.Spanish:
                    return TranslateTo(word,Languages.Spanish);
                case Languages.French:
                    return TranslateTo(word, Languages.French);
                case Languages.Armenian:
                    return TranslateTo(word, Languages.Armenian);
                default:
                    return "unknown Language";
            }
        }
        public static string TranslateTo(string word, Languages lang)
        {
            if (word == "hello")
            {
                switch (lang)
                {
                    case Languages.Armenian:
                        return "բարև";
                    case Languages.English:
                        return word;
                    case Languages.French:
                        return "bonjour";
                    case Languages.Spanish:
                        return "hola";
                    default:
                        return "unknown Language";
                }
            }
            else
            {
                return $"i cant to Translate from English into {lang} this word";
            }
        }






        public struct VehicleInfo
        {
            public Vehicle Vehicle { get; set; }
            public int MaxSpeed { get; set; }
            public int MinSpeed { get; set; }

            public VehicleInfo(Vehicle VH, int maxspeed, int minspeed)
            {
                Vehicle = VH;
                MaxSpeed = maxspeed;
                MinSpeed = minspeed;

            }
            public void PrintInfo()
            {
                Console.WriteLine($"vehicle is {Vehicle} and its MaxSpeed is {MaxSpeed} and MinSpeed {MinSpeed}");
            }
        }






        enum WeekDays
        {
            Monday, 
            Tuesday, 
            Wednesday, 
            Thursday,
            Friday,
            Saturday,
            Sunday
        }







        public enum TrafficLight
        {
            None = 0,
            Red = 1 <<0,
            Yellow = 1 << 1,
            Green = 1 << 2
        }





        [Flags]
        public  enum uploads
        {
            None = 0,
            txt = 1<< 0,
            jpg = 1 << 1,
            pdf = 1 << 2,
            png = 1 << 3,
        }





        [Flags]
        public enum Files
        {
            None = 0,
            Read = 1 <<0,
            Write = 1 << 1,
            Execute = 1 << 2,
        }






        [Flags]
        public enum Styles
        {
            None = 0,
            Bold = 1 << 0,          
            Italic = 1 << 1,       
            Underline = 1 << 2,     
            StrikeThrough = 1 << 3  
        }
        public static bool isSet(Styles styles,Styles mystyle)
        {
            return (styles & mystyle) == styles;
        }
        public static void Main(string[] args)
        {



            /*
            Console.WriteLine("write number of Weather (1 - Sunny, 2 - Cloudy, 4 - Rainy)");
            int number_weather = int.Parse(Console.ReadLine());
            if (Enum.IsDefined(typeof(Enum), number_weather))
            {
                Weather weather = (Weather)number_weather;
                Console.Write(weather.ToString());
            }
            else
            {
                Console.WriteLine("Error");
            }
            Console.ReadLine();
            */





            /*
            var vehicleInfo_car = new VehicleInfo(Vehicle.car, 220, 0);
            var vehicleInfo_Bus = new VehicleInfo(Vehicle.Bus, 180, 0);
            var vehicleInfo_bicycle = new VehicleInfo(Vehicle.Bicycle, 200, 0);
            vehicleInfo_car.PrintInfo();
            vehicleInfo_Bus.PrintInfo();
            vehicleInfo_bicycle.PrintInfo();
            Console.ReadLine();
            */




            /*
            Console.WriteLine("please write hello");
            string word = Console.ReadLine();
            Console.WriteLine("choose one of these:(Spanish -2,French-3,Armenian-4)");
            int number = int.Parse(Console.ReadLine());
            string result = TranslateWord(word,(Languages)number);
            Console.WriteLine(result);
            Console.ReadLine();
            */




            /*
            DateTime dateTime = DateTime.Now;
            DayOfWeek dayofweek = dateTime.DayOfWeek;
            WeekDays WeekDays = new WeekDays();
            bool isWeekday = true;
            WeekDays currentday = (WeekDays)Enum.Parse(typeof(WeekDays), dayofweek.ToString());
            switch (WeekDays)
            {
                case WeekDays.Saturday:
                    isWeekday = false; break;
                case WeekDays.Sunday:
                    isWeekday = false ; break;
            }
            Console.WriteLine(isWeekday);
            Console.ReadLine();
            */





            /*
             int number = int.Parse(Console.ReadLine());
             int RetNum = ReturnDb(number);
             string RetToStr = RetNum.ToString();
             int count = 6 - RetToStr.Length;
             string NumberBin = "";
             for(int i = 0; i < 6; i++)
             {
                 if(i < count)
                 {
                     NumberBin += "0";
                 }
                 else
                 {
                     NumberBin += RetToStr;
                     break;
                 }
             }
             RetNum = Convert.ToInt32(NumberBin,2);
             Console.Write(RetNum);
             UserRole AllUser = UserRole.Admin | UserRole.Moderator | UserRole.User | UserRole.Editor | UserRole.Viewer | UserRole.Manager;

             Console.WriteLine(AllUser & (UserRole)RetNum);
             Console.ReadLine();
             */






            /*
            Random random = new Random();
            int value =  random.Next(0,3);
            Console.WriteLine(value);
            TrafficLight AllTraffic = TrafficLight.Red| TrafficLight.Yellow | TrafficLight.Green;
            Console.WriteLine((TrafficLight)(1 << value) & AllTraffic);
            Console.ReadLine();
            */




            /*
             Console.WriteLine("choose file format");
             string str = Console.ReadLine();
            try
            {
                Enum.Parse(typeof(uploads), str);
                Console.WriteLine($"you can upload {str} type file");
            }catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
            Console.ReadLine();
            */




            /*
            Files AllFiles = Files.Read | Files.Write | Files.Execute;
            Files NotRead = ~Files.Read;
            Console.WriteLine(AllFiles & NotRead);
            Console.ReadLine();
            */






            //My problem
            /*
             * Given an array of non-negative integers, count the number of unordered pairs of array elements, such that their bitwise AND is a power of 2.
             */
            /*
            int[] array = new int[5];
            for(int i = 0; i < array.Length; i++)
            {
                int.TryParse(Console.ReadLine(),out int value);
                if(value > 0)
                {
                    array[i] = value;
                }
                else
                {
                    i = (i>0)?i-1:0;
                }
            }
            string bitvize = "";
            for(int i = 0; i < array.Length; i++)
            {
                for(int j=i+1;j<array.Length; j++)
                {
                    int index = 0;
                    bitvize = Convert.ToString((array[i] & array[j]),2);

                    for(int k = 0; k < bitvize.Length; k++)
                    {
                        if (bitvize[k] == '1')
                        {
                            index++;
                        }
                    }
                    if(index == 1)
                    {
                        Console.WriteLine((array[i] + "" + array[j]));
                    }
                    bitvize = "";

                }
            }
            Console.ReadLine();
            */






            /*
            Styles MyStyle = Styles.Italic | Styles.Bold;
            bool isValid = isSet(Styles.Italic, MyStyle);
            Console.WriteLine(isValid);
            Console.ReadLine();
            */
        }
    }
}
