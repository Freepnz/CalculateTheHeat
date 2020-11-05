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
        private decimal heightWall = 0;     //Глянуть возможность использования автосвойства
        private decimal materialWall = 0;
        private decimal k1;
        private decimal k2;
        private decimal k3;
        private decimal k4;
        private decimal k5;
        private decimal k6;
        private decimal k7;
        private decimal k8;
        private decimal k9;
        private decimal k10;

        public decimal HeightWall { get { return heightWall; } }

        public CalculateBoiler()
        {
        }

        public int CalculateBoilerArea(string areaValue, int reservPowerValue)
        {
            areaHouse = Convert.ToDecimal(areaValue);

            switch (reservPowerValue)
            {
                case 0:
                    reservPower = 1.1M;
                    break;
                case 1:
                    reservPower = 1.2M;
                    break;
                default:
                    break;
            }

            int result = Convert.ToInt32((areaHouse / 10) * reservPower);
            return result;
        }

        public int CalculateBoilerHeightWall(string areaValue, decimal heigthWallValue, string materialWallValue)
        {
            areaHouse = Convert.ToDecimal(areaValue);
            heightWall = heigthWallValue;
            MaerialWallCoef(materialWallValue);

            return Convert.ToInt32(heightWall * areaHouse * materialWall);
        }

        public int CalculateBoilerAllFeatures(string areaValue, int k1val, int k2val, int k3val, int k4val, int k5val, int k6val, int k7val, int k8val, int k9val, int k10val)
        {
            areaHouse = Convert.ToDecimal(areaValue);
            #region Коэффициенты К
            switch (k1)
            {
                case 1: this.k1 = 1.0M; break;
                case 2: this.k1 = 1.2M; break;
                case 3: this.k1 = 1.3M; break;
                default: break;
            }
            switch (k2)
            {
                case 1: this.k2 = 1.1M; break;
                case 2: this.k2 = 1.0M; break;
                default: break;
            }
            switch (k3)
            {
                case 1: this.k3 = 1.17M; break;
                case 2: this.k3 = 1.0M; break;
                case 3: this.k3 = 0.85M; break;
                default: break;
            }
            switch (k4)
            {
                case 1: this.k4 = 1.4M; break;
                case 2: this.k4 = 1.25M; break;
                case 3: this.k4 = 1.2M; break;
                case 4: this.k4 = 1.1M; break;
                case 5: this.k4 = 0.9M; break;
                case 6: this.k4 = 0.7M; break;
                default: break;
            }
            switch (k5)
            {
                case 1: this.k5 = 1.00M; break;
                case 2: this.k5 = 1.02M; break;
                case 3: this.k5 = 1.08M; break;
                case 4: this.k5 = 0.15M; break;
                default: break;
            }
            switch (k6)
            {
                case 1: this.k6 = 1.00M; break;
                case 2: this.k6 = 0.9M; break;
                case 3: this.k6 = 0.8M; break;
                default: break;
            }
            switch (k7)
            {
                case 1: this.k7 = 1.17M; break;
                case 2: this.k7 = 1.00M; break;
                case 3: this.k7 = 0.85M; break;
                default: break;
            }
            switch (k8)
            {
                case 1: this.k8 = 0.8M; break;
                case 2: this.k8 = 0.9M; break;
                case 3: this.k8 = 1.00M; break;
                case 4: this.k8 = 1.05M; break;
                case 5: this.k8 = 1.15M; break;
                default: break;
            }
            switch (k9)
            {
                case 1: this.k9 = 0.9M; break;
                case 2: this.k9 = 1.00M; break;
                case 3: this.k9 = 1.05M; break;
                case 4: this.k9 = 1.15M; break;
                default: break;
            }
            switch (k10)
            {
                case 1: this.k10 = 1.00M; break;
                case 2: this.k10 = 1.03M; break;
                case 3: this.k10 = 1.1M; break;
                case 4: this.k10 = 1.2M; break;
                case 5: this.k10 = 1.28M; break;
                case 6: this.k10 = 1.28M; break;
                default: break;
            }
            #endregion
            return Convert.ToInt32(100 * areaHouse * k1 * k2 * k3 * k4 * k5 * k6 * k7 * k8 * k9 * k10 / 1000);
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
    }
}
