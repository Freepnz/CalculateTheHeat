using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateTheHeat
{
    class CalculateBoiler
    {
        private decimal AreaHouse = 0;
        private decimal ReservePower = 0;

        public CalculateBoiler( decimal areaHouse, int reservePover)
        {
            this.AreaHouse = areaHouse;
            this.ReservePower = reservePover;
        }

        public int CalculateBoilerArea(decimal area, int reservePower)
        {
            decimal areaRounding = decimal.Round(area, MidpointRounding.AwayFromZero);  //округляем площадь до большего значения от нуля

            switch (reservePower)
            {
                case 10:
                    ReservePower = 1.1M;
                    break;
                case 15:
                    ReservePower = 1.15M;
                    break;
                case 20:
                    ReservePower = 1.2M;
                    break;
                case 25:
                    ReservePower = 1.25M;
                    break;
                default:
                    break;
            }

            int result = Convert.ToInt32((areaRounding / 10) * ReservePower);
            return result;
        }
    }
}
