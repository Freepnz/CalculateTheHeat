using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateTheHeat
{
    class CalculateBoiler
    {
        private decimal areaHouse = 0;
        private decimal reservPower = 0;

        public CalculateBoiler()
        {
        }

        public int CalculateBoilerArea(string areaValue, string reservPowerValue)
        {
            areaHouse = areaHouseConvert(areaValue);

            switch (reservPowerValue)
            {
                case "10":
                    reservPower = 1.1M;
                    break;
                case "15":
                    reservPower = 1.15M;
                    break;
                case "20":
                    reservPower = 1.2M;
                    break;
                case "25":
                    reservPower = 1.25M;
                    break;
                default:
                    break;
            }

            int result = Convert.ToInt32((areaHouse / 10) * reservPower);
            return result;
        }

        private decimal areaHouseConvert(string value)
        {
            decimal areaConvert = Convert.ToDecimal(value);
            return decimal.Round(areaConvert, MidpointRounding.AwayFromZero);  //округляем площадь до большего значения от нуля
        }
    }
}
