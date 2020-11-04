using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculateTheHeat
{
    class CalculateBoiler
    {
        private decimal areaHouse = 0;
        private decimal reservPower = 0;
        private decimal heightWall = 0;
        private decimal materialWall = 0;

        public decimal HeightWall
        {
            get
            {
                return heightWall;
            }
        }

        public CalculateBoiler()
        {
        }

        public int CalculateBoilerArea(string areaValue, string reservPowerValue)
        {
            areaHouse = Convert.ToDecimal(areaValue);

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

        public int CalculateBoilerHeightWall(string areaValue, string heigthWallValue, string materialWallValue)
        {
            areaHouse = Convert.ToDecimal(areaValue);
            HeightWallCoef(heigthWallValue);
            MaerialWallCoef(materialWallValue);

            return Convert.ToInt32(heightWall * areaHouse * materialWall);
        }

        private void MaerialWallCoef(string Value)
        {
            if (Value == "Кирпичный дом")
            {
                materialWall = 0.034M;
            }
            else
                materialWall = 0.041M;
        }

        private void HeightWallCoef(string value)
        {
            switch (value)
            {
                case "до 2.7":
                    heightWall = 2.7M;
                    break;
                case "до 2.8":
                    heightWall = 2.8M;
                    break;
                case "до 2.9":
                    heightWall = 2.9M;
                    break;
                case "до 3":
                    heightWall = 3M;
                    break;
                case "3,1 — 3,9":
                    heightWall = 3.5M;
                    break;
                case "4 м и более":
                    heightWall = 4M;
                    break;
                default:
                    heightWall = 2.7M;
                    break;
            }
            if (heightWall > 3)
            {
              //  BoilerForm boilerFormNew = new BoilerForm();
              //  boilerFormNew.labelVolumeAttention.Text = "При высоте потолков свыше 3 м, значения сильно усредняются...";
                
            }
        }

    }
}
