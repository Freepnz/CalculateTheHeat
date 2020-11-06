using System;
using System.Collections.Generic;
using System.IO;
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
        private decimal k1, k2, k3, k4, k5, k6, k7, k8, k9, k10;


        public decimal HeightWall { get { return heightWall; } }

        public CalculateBoiler()
        {
        }

        public int CalculateBoilerArea(string areaValue, int reservPowerValue)
        {
            if (areaValue == "")
            {
                areaHouse = 0;
            }
            else
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
            if (areaValue == "")
            {
                areaHouse = 0;
            }
            else
                areaHouse = Convert.ToDecimal(areaValue);
            heightWall = heigthWallValue;
            MaerialWallCoef(materialWallValue);

            return Convert.ToInt32(heightWall * areaHouse * materialWall);
        }

        public int CalculateBoilerAllFeatures(string areaValue, int k1val, int k2val, int k3val, int k4val, int k5val, int k6val, int k7val, string k8val, int k9val, int k10val)
        {
            if (areaValue == "")
            {
                areaHouse = 0;
            }
            else
                areaHouse = Convert.ToDecimal(areaValue);
            #region Коэффициенты К
            switch (k1val)
            {
                case 0: this.k1 = 1.0M; break;
                case 1: this.k1 = 1.2M; break;
                case 2: this.k1 = 1.3M; break;
                default: break;
            }
            switch (k2val)
            {
                case 0: this.k2 = 1.1M; break;
                case 1: this.k2 = 1.0M; break;
                default: break;
            }
            switch (k3val)
            {
                case 0: this.k3 = 1.17M; break;
                case 1: this.k3 = 1.0M; break;
                case 2: this.k3 = 0.85M; break;
                default: break;
            }
            switch (k4val)
            {
                case 0: this.k4 = 1.4M; break;
                case 1: this.k4 = 1.25M; break;
                case 2: this.k4 = 1.2M; break;
                case 3: this.k4 = 1.1M; break;
                case 4: this.k4 = 0.9M; break;
                case 5: this.k4 = 0.7M; break;
                default: break;
            }
            switch (k5val)
            {
                case 0: this.k5 = 1.00M; break;
                case 1: this.k5 = 1.02M; break;
                case 2: this.k5 = 1.08M; break;
                case 3: this.k5 = 1.15M; break;
                default: break;
            }
            switch (k6val)
            {
                case 0: this.k6 = 1.00M; break;
                case 1: this.k6 = 0.9M; break;
                case 2: this.k6 = 0.8M; break;
                default: break;
            }
            switch (k7val)
            {
                case 0: this.k7 = 1.17M; break;
                case 1: this.k7 = 1.00M; break;
                case 2: this.k7 = 0.85M; break;
                default: break;
            }

            k8 = SearchAreaWindows(areaHouse, k8val);

            switch (k9val)
            {
                case 0: this.k9 = 0.9M; break;
                case 1: this.k9 = 1.00M; break;
                case 2: this.k9 = 1.05M; break;
                case 3: this.k9 = 1.15M; break;
                default: break;
            }
            switch (k10val)
            {
                case 0: this.k10 = 1.00M; break;
                case 1: this.k10 = 1.03M; break;
                case 2: this.k10 = 1.1M; break;
                case 3: this.k10 = 1.2M; break;
                case 4: this.k10 = 1.28M; break;
                case 5: this.k10 = 1.28M; break;
                default: break;
            }
            #endregion
            return Convert.ToInt32(100 * areaHouse * k1 * k2 * k3 * k4 * k5 * k6 * k7 * k8 * k9 * k10 / 1000);
        }

        private decimal SearchAreaWindows(decimal areaHouse, string k8val)
        {
            if (k8val == "")
            {
                return 0.8M;
            }
            else
            {
            decimal result = Convert.ToDecimal(k8val) / areaHouse;

            if (result <= 0.1M)
            {
                return 0.8M;
            }
            if (result >= 0.11M && result <= 0.2M)
            {
                return 0.9M;
            }
            if (result >= 0.21M && result <= 0.3M)
            {
                return 1;
            }
            if (result >= 0.31M && result <= 0.4M)
            {
                return 1.05M;
            }
            if (result >= 0.41M && result <= 0.5M)
            {
                return 1.15M;
            }
            else
                return 1.2M;
            }
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

        public void SaveResultInFile(string result, string K1val, string K2val, string K3val, string K5val, string K10val, string K7val, string K9val, string K6val, string K4val, string areaWindows)
        {
            string path = @"C:\\" + "Дом" + areaHouse + "кв" + ".txt";

            using (StreamWriter streamWriter = new StreamWriter(path, true))
            {
                streamWriter.WriteLine();
                streamWriter.WriteLine(DateTime.Now);
                streamWriter.WriteLine(result);
                streamWriter.WriteLine("Параметры:");
                streamWriter.WriteLine("Кол-во внешних стен в помещении:");
                streamWriter.WriteLine(K1val);
                streamWriter.WriteLine("Ориентация помещения:");
                streamWriter.WriteLine(K2val);
                streamWriter.WriteLine("теплоизоляции стен:");
                streamWriter.WriteLine(K3val);
                streamWriter.WriteLine("Коэф. учитывающий высоту потолка:");
                streamWriter.WriteLine(K5val);
                streamWriter.WriteLine("Cпособ подключения радиаторов:");
                streamWriter.WriteLine(K10val);
                streamWriter.WriteLine("Учет теплопотерь окон (тип и к-во стеклопакетов):");
                streamWriter.WriteLine(K7val);
                streamWriter.WriteLine("Учет расположения батареи и наличия экрана:");
                streamWriter.WriteLine(K9val);
                streamWriter.WriteLine("Kоэф. учитывающий теплопотери потолка:");
                streamWriter.WriteLine(K6val);
                streamWriter.WriteLine("Подробный учет климатических условий локации (уличная температура воздуха в самую холодную неделю зимы):");
                streamWriter.WriteLine(K4val);
                streamWriter.WriteLine("Общая площадь остекления, м2:");
                streamWriter.WriteLine(areaWindows);
            }

            MessageBox.Show(@"Сохранённая информация расположена " + path);
        }
    }
}
