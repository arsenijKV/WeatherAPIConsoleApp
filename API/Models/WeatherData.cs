using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherConsoleApp.Models
{
    

    public class WeatherData
    {
        public LocationInfo Location { get; set; }
        public CurrentInfo Current { get; set; }
    }

    public class LocationInfo
    {
        public string Name { get; set; }
        public string Region { get; set; }
        public string Country { get; set; }
        public string Localtime { get; set; }
    }

    public class CurrentInfo
    {
        public double Temp_c { get; set; }
        public ConditionInfo Condition { get; set; }
        public double Wind_kph { get; set; }
        public int Humidity { get; set; }
        public double Feelslike_c { get; set; }
    }

    public class ConditionInfo
    {
        public string Text { get; set; }
        public string Icon { get; set; }
    }

}
