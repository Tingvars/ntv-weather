using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherClass
{
    internal class Weather
    {
        public int Temperature { get; set; }
        public bool IsTempCorrect { get; set; }
        public int Humidity { get; set; }
        public bool IsHumidCorrect { get; set; }
        public string Scale { get; set; }
        public bool IsScaleCorrect { get; set; }

        public Weather(int temp, int humid, string sca)
        {
            //so it works whether the user enters c/f/C/F/celcius/fahrenheit/Celcius/Fahrenheit
            string scal = sca.Substring(0, 1).ToLower();
            if (scal == "c")
            {
                Scale = "Celcius";
                IsScaleCorrect = true;
            } 
            else if (scal == "f")
            {
                Scale = "Fahrenheit";
                IsScaleCorrect = true;
            }
            else
            {
                IsScaleCorrect = false;
            }

            if (humid > 0 && humid < 100)
            {
                Humidity = humid;
                IsHumidCorrect = true;
            }
            else
            {
                IsHumidCorrect = false;
            }

            if (Scale == "Celcius")
            {
               if (temp > -60 && temp < 60)
                {
                    Temperature = temp;
                    IsTempCorrect = true;
                } else
                {
                    IsTempCorrect = false;
                }
            } 
            else if (Scale == "Fahrenheit")
            {
                if (temp > -76 && temp < 140)
                {
                    Temperature = temp;
                    IsTempCorrect = true;
                }
                else
                {
                    IsTempCorrect = false;
                }
            }
            if (IsScaleCorrect && IsTempCorrect)
            {
                Console.WriteLine($"Temperature: {Temperature} degrees {Scale}");
            } else 
            { 
                if (!IsScaleCorrect)
                {
                Console.WriteLine("Scale entered incorrectly.");
                } 
                //Temperature is only set if the scale is correct,
                //so this prevents the console from displaying the 
                //"incorrect temp" message if !isScaleCorrect but isTempCorrect:
                if (!IsTempCorrect && IsScaleCorrect)
                {
                Console.WriteLine("Temperature entered incorrectly.");
                }
                 }
            if (IsHumidCorrect)
            {
                Console.WriteLine($"Humidity: {Humidity}%");
            } else
            {
                Console.WriteLine("Humidity entered incorrectly.");
            }
        }
        public void Convert()
        {
            //if statement to stop Convert from happening if scale or temp are wrong:
            if (IsScaleCorrect && IsTempCorrect)
            {
                if (Scale == "Celcius")
                {
                    int newTemp = (Temperature * 9 / 5) + 32;
                    Scale = "Fahrenheit";
                    Console.WriteLine($"{newTemp} degrees {Scale}");
                }
                else if (Scale == "Fahrenheit")
                {
                    int newTemp = (Temperature - 32) * 5 / 9;
                    Scale = "Celcius";
                    Console.WriteLine($"{newTemp} degrees {Scale}");
                }
                
            }
        }
    }
}
