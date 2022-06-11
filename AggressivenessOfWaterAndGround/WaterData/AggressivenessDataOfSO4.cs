using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AggressivenessOfWaterAndGround.WaterData
{
    internal static class AggressivenessDataOfSO4
    {
        public static uint AmountSO4 {private get; set; }
        private static double s_amountHCO3;
        public static double AmountHCO3
        {
            private get { return s_amountHCO3; }
            set { s_amountHCO3 = value < 0 ? 0 : value; }
        }
        
        const string NonAggres = "Неагрессивная";
        const string MildlyAggres = "Слабоагрессивная";
        const string MediumAggres = "Среднеагрессивная";
        const string HighlyAggres = "Сильноагрессивная";
        const double IncreasingCoefToW6 = 1.3;
        const double IncreasingCoefToW8 = 1.7;

        // These properties are returning the power of aggressiveness
        // that depends from amount SO4 and HCO3
        public static string CementIW4
        {
            get
            {
                if (AmountHCO3 > 0 && AmountHCO3 <= 3)
                {
                    if (AmountSO4 <= 250)
                        return NonAggres;

                    else if (AmountSO4 > 250 && AmountSO4 <= 500)
                        return MildlyAggres;

                    else if (AmountSO4 > 500 && AmountSO4 <= 1000)
                        return MediumAggres;

                    else
                        return HighlyAggres;
                }

                else if (AmountHCO3 > 3 && AmountHCO3 <= 6)
                {
                    if (AmountSO4 <= 500)
                        return NonAggres;

                    else if (AmountSO4 > 500 && AmountSO4 <= 1000)
                        return MildlyAggres;

                    else if (AmountSO4 > 1000 && AmountSO4 <= 1200)
                        return MediumAggres;

                    else
                        return HighlyAggres;
                }

                else if (AmountHCO3 > 6)
                {
                    if (AmountSO4 <= 1000)
                        return NonAggres;

                    else if (AmountSO4 > 1000 && AmountSO4 <= 1200)
                        return MildlyAggres;

                    else if (AmountSO4 > 1200 && AmountSO4 <= 1500)
                        return MediumAggres;

                    else
                        return HighlyAggres;
                }

                else
                    return "Введите значение HCO3";
            } 
        }
        public static string CementIW6
        {
            get
            {
                if (AmountHCO3 > 0 && AmountHCO3 <= 3)
                {
                    if (AmountSO4 <= (250 * IncreasingCoefToW6))
                        return NonAggres;

                    else if (AmountSO4 > (250 * IncreasingCoefToW6) && AmountSO4 <= (500 * IncreasingCoefToW6))
                        return MildlyAggres;

                    else if (AmountSO4 > (500 * IncreasingCoefToW6) && AmountSO4 <= (1000 * IncreasingCoefToW6))
                        return MediumAggres;

                    else
                        return HighlyAggres;
                }

                else if (AmountHCO3 > 3 && AmountHCO3 <= 6)
                {
                    if (AmountSO4 <= (500 * IncreasingCoefToW6))
                        return NonAggres;

                    else if (AmountSO4 > (500 * IncreasingCoefToW6) && AmountSO4 <= (1000 * IncreasingCoefToW6))
                        return MildlyAggres;

                    else if (AmountSO4 > (1000 * IncreasingCoefToW6) && AmountSO4 <= (1200 * IncreasingCoefToW6))
                        return MediumAggres;

                    else
                        return HighlyAggres;
                }

                else if (AmountHCO3 > 6)
                {
                    if (AmountSO4 <= (1000 * IncreasingCoefToW6))
                        return NonAggres;

                    else if (AmountSO4 > (1000 * IncreasingCoefToW6) && AmountSO4 <= (1200 * IncreasingCoefToW6))
                        return MildlyAggres;

                    else if (AmountSO4 > (1200 * IncreasingCoefToW6) && AmountSO4 <= (1500 * IncreasingCoefToW6))
                        return MediumAggres;

                    else
                        return HighlyAggres;
                }

                else
                    return "Введите значение HCO3";
            }
        }
        public static string CementIW8
        {
            get
            {
                if (AmountHCO3 > 0 && AmountHCO3 <= 3)
                {
                    if (AmountSO4 <= (250 * IncreasingCoefToW8))
                        return NonAggres;

                    else if (AmountSO4 > (250 * IncreasingCoefToW8) && AmountSO4 <= (500 * IncreasingCoefToW8))
                        return MildlyAggres;

                    else if (AmountSO4 > (500 * IncreasingCoefToW8) && AmountSO4 <= (1000 * IncreasingCoefToW8))
                        return MediumAggres;

                    else
                        return HighlyAggres;
                }

                else if (AmountHCO3 > 3 && AmountHCO3 <= 6)
                {
                    if (AmountSO4 <= (500 * IncreasingCoefToW8))
                        return NonAggres;

                    else if (AmountSO4 > (500 * IncreasingCoefToW8) && AmountSO4 <= (1000 * IncreasingCoefToW8))
                        return MildlyAggres;

                    else if (AmountSO4 > (1000 * IncreasingCoefToW8) && AmountSO4 <= (1200 * IncreasingCoefToW8))
                        return MediumAggres;

                    else
                        return HighlyAggres;
                }

                else if (AmountHCO3 > 6)
                {
                    if (AmountSO4 <= (1000 * IncreasingCoefToW8))
                        return NonAggres;

                    else if (AmountSO4 > (1000 * IncreasingCoefToW8) && AmountSO4 <= (1200 * IncreasingCoefToW8))
                        return MildlyAggres;

                    else if (AmountSO4 > (1200 * IncreasingCoefToW8) && AmountSO4 <= (1500 * IncreasingCoefToW8))
                        return MediumAggres;

                    else
                        return HighlyAggres;
                }

                else
                    return "Введите значение HCO3";
            }
        }
        public static string CementIW10_14
        {
            get
            {
                if (AmountSO4 <= 850)
                    return NonAggres;

                else if (AmountSO4 > 850 && AmountSO4 <= 1250)
                    return MildlyAggres;

                else if (AmountSO4 > 1250 && AmountSO4 <= 2500)
                    return MediumAggres;

                else
                    return HighlyAggres;
            }
        }
        public static string CementIW16_20
        {
            get
            {
                if (AmountSO4 <= 1250)
                    return NonAggres;

                else if (AmountSO4 > 1250 && AmountSO4 <= 2500)
                    return MildlyAggres;

                else if (AmountSO4 > 2500 && AmountSO4 <= 5000)
                    return MediumAggres;

                else
                    return HighlyAggres;
            }
        }
        public static string CementIIW4
        {
            get
            {
                if (AmountHCO3 > 0 && AmountHCO3 <= 3)
                {
                    if (AmountSO4 <= 1500)
                        return NonAggres;

                    else if (AmountSO4 > 1500 && AmountSO4 <= 3000)
                        return MildlyAggres;

                    else if (AmountSO4 > 3000 && AmountSO4 <= 4000)
                        return MediumAggres;

                    else
                        return HighlyAggres;
                }

                else if (AmountHCO3 > 3 && AmountHCO3 <= 6)
                {
                    if (AmountSO4 <= 3000)
                        return NonAggres;

                    else if (AmountSO4 > 3000 && AmountSO4 <= 4000)
                        return MildlyAggres;

                    else if (AmountSO4 > 4000 && AmountSO4 <= 5000)
                        return MediumAggres;

                    else
                        return HighlyAggres;
                }

                else if (AmountHCO3 > 6)
                {
                    if (AmountSO4 <= 4000)
                        return NonAggres;

                    else if (AmountSO4 > 4000 && AmountSO4 <= 5000)
                        return MildlyAggres;

                    else if (AmountSO4 > 5000 && AmountSO4 <= 6000)
                        return MediumAggres;

                    else
                        return HighlyAggres;
                }

                else
                    return "Введите значение HCO3";
            }
        }
        public static string CementIIW6
        {
            get
            {
                if (AmountHCO3 > 0 && AmountHCO3 <= 3)
                {
                    if (AmountSO4 <= (1500 * IncreasingCoefToW6))
                        return NonAggres;

                    else if (AmountSO4 > (1500 * IncreasingCoefToW6) && AmountSO4 <= (3000 * IncreasingCoefToW6))
                        return MildlyAggres;

                    else if (AmountSO4 > (3000 * IncreasingCoefToW6) && AmountSO4 <= (4000 * IncreasingCoefToW6))
                        return MediumAggres;

                    else
                        return HighlyAggres;
                }

                else if (AmountHCO3 > 3 && AmountHCO3 <= 6)
                {
                    if (AmountSO4 <= (3000 * IncreasingCoefToW6))
                        return NonAggres;

                    else if (AmountSO4 > (3000 * IncreasingCoefToW6) && AmountSO4 <= (4000 * IncreasingCoefToW6))
                        return MildlyAggres;

                    else if (AmountSO4 > (4000 * IncreasingCoefToW6) && AmountSO4 <= (5000 * IncreasingCoefToW6))
                        return MediumAggres;

                    else
                        return HighlyAggres;
                }

                else if (AmountHCO3 > 6)
                {
                    if (AmountSO4 <= (4000 * IncreasingCoefToW6))
                        return NonAggres;

                    else if (AmountSO4 > (4000 * IncreasingCoefToW6) && AmountSO4 <= (5000 * IncreasingCoefToW6))
                        return MildlyAggres;

                    else if (AmountSO4 > (5000 * IncreasingCoefToW6) && AmountSO4 <= (6000 * IncreasingCoefToW6))
                        return MediumAggres;

                    else
                        return HighlyAggres;
                }

                else
                    return "Введите значение HCO3";
            }
        }
        public static string CementIIW8
        {
            get
            {
                if (AmountHCO3 > 0 && AmountHCO3 <= 3)
                {
                    if (AmountSO4 <= (1500 * IncreasingCoefToW8))
                        return NonAggres;

                    else if (AmountSO4 > (1500 * IncreasingCoefToW8) && AmountSO4 <= (3000 * IncreasingCoefToW8))
                        return MildlyAggres;

                    else if (AmountSO4 > (3000 * IncreasingCoefToW8) && AmountSO4 <= (4000 * IncreasingCoefToW8))
                        return MediumAggres;

                    else
                        return HighlyAggres;
                }

                else if (AmountHCO3 > 3 && AmountHCO3 <= 6)
                {
                    if (AmountSO4 <= (3000 * IncreasingCoefToW8))
                        return NonAggres;

                    else if (AmountSO4 > (3000 * IncreasingCoefToW8) && AmountSO4 <= (4000 * IncreasingCoefToW8))
                        return MildlyAggres;

                    else if (AmountSO4 > (4000 * IncreasingCoefToW8) && AmountSO4 <= (5000 * IncreasingCoefToW8))
                        return MediumAggres;

                    else
                        return HighlyAggres;
                }

                else if (AmountHCO3 > 6)
                {
                    if (AmountSO4 <= (4000 * IncreasingCoefToW8))
                        return NonAggres;

                    else if (AmountSO4 > (4000 * IncreasingCoefToW8) && AmountSO4 <= (5000 * IncreasingCoefToW8))
                        return MildlyAggres;

                    else if (AmountSO4 > (5000 * IncreasingCoefToW8) && AmountSO4 <= (6000 * IncreasingCoefToW8))
                        return MediumAggres;

                    else
                        return HighlyAggres;
                }

                else
                    return "Введите значение HCO3";
            }
        }
        public static string CementIIW10_14
        {
            get
            {
                if (AmountSO4 <= 5100)
                    return NonAggres;

                else if (AmountSO4 > 5100 && AmountSO4 <= 8000)
                    return MildlyAggres;

                else if (AmountSO4 > 8000 && AmountSO4 <= 9000)
                    return MediumAggres;

                else
                    return HighlyAggres;
            }
        }
        public static string CementIIW16_20
        {
            get
            {
                if (AmountSO4 <= 8000)
                    return NonAggres;

                else if (AmountSO4 > 8000 && AmountSO4 <= 9000)
                    return MildlyAggres;

                else if (AmountSO4 > 9000 && AmountSO4 <= 10000)
                    return MediumAggres;

                else
                    return HighlyAggres;
            }
        }
        public static string CementIIIW4
        {
            get
            {
                if (AmountHCO3 > 0 && AmountHCO3 <= 3)
                {
                    if (AmountSO4 <= 3000)
                        return NonAggres;

                    else if (AmountSO4 > 3000 && AmountSO4 <= 6000)
                        return MildlyAggres;

                    else if (AmountSO4 > 6000 && AmountSO4 <= 8000)
                        return MediumAggres;

                    else
                        return HighlyAggres;
                }

                else if (AmountHCO3 > 3 && AmountHCO3 <= 6)
                {
                    if (AmountSO4 <= 6000)
                        return NonAggres;

                    else if (AmountSO4 > 6000 && AmountSO4 <= 8000)
                        return MildlyAggres;

                    else if (AmountSO4 > 8000 && AmountSO4 <= 12000)
                        return MediumAggres;

                    else
                        return HighlyAggres;
                }

                else if (AmountHCO3 > 6)
                {
                    if (AmountSO4 <= 8000)
                        return NonAggres;

                    else if (AmountSO4 > 8000 && AmountSO4 <= 12000)
                        return MildlyAggres;

                    else if (AmountSO4 > 12000 && AmountSO4 <= 15000)
                        return MediumAggres;

                    else
                        return HighlyAggres;
                }

                else
                    return "Введите значение HCO3";
            }
        }
        public static string CementIIIW6
        {
            get
            {
                if (AmountHCO3 > 0 && AmountHCO3 <= 3)
                {
                    if (AmountSO4 <= (3000 * IncreasingCoefToW6))
                        return NonAggres;

                    else if (AmountSO4 > (3000 * IncreasingCoefToW6) && AmountSO4 <= (6000 * IncreasingCoefToW6))
                        return MildlyAggres;

                    else if (AmountSO4 > (6000 * IncreasingCoefToW6) && AmountSO4 <= (8000 * IncreasingCoefToW6))
                        return MediumAggres;

                    else
                        return HighlyAggres;
                }

                else if (AmountHCO3 > 3 && AmountHCO3 <= 6)
                {
                    if (AmountSO4 <= (6000 * IncreasingCoefToW6))
                        return NonAggres;

                    else if (AmountSO4 > (6000 * IncreasingCoefToW6) && AmountSO4 <= (8000 * IncreasingCoefToW6))
                        return MildlyAggres;

                    else if (AmountSO4 > (8000 * IncreasingCoefToW6) && AmountSO4 <= (12000 * IncreasingCoefToW6))
                        return MediumAggres;

                    else
                        return HighlyAggres;
                }

                else if (AmountHCO3 > 6)
                {
                    if (AmountSO4 <= (8000 * IncreasingCoefToW6))
                        return NonAggres;

                    else if (AmountSO4 > (8000 * IncreasingCoefToW6) && AmountSO4 <= (12000 * IncreasingCoefToW6))
                        return MildlyAggres;

                    else if (AmountSO4 > (12000 * IncreasingCoefToW6) && AmountSO4 <= (15000 * IncreasingCoefToW6))
                        return MediumAggres;

                    else
                        return HighlyAggres;
                }

                else
                    return "Введите значение HCO3";
            }
        }
        public static string CementIIIW8
        {
            get
            {
                if (AmountHCO3 > 0 && AmountHCO3 <= 3)
                {
                    if (AmountSO4 <= (3000 * IncreasingCoefToW8))
                        return NonAggres;

                    else if (AmountSO4 > (3000 * IncreasingCoefToW8) && AmountSO4 <= (6000 * IncreasingCoefToW8))
                        return MildlyAggres;

                    else if (AmountSO4 > (6000 * IncreasingCoefToW8) && AmountSO4 <= (8000 * IncreasingCoefToW8))
                        return MediumAggres;

                    else
                        return HighlyAggres;
                }

                else if (AmountHCO3 > 3 && AmountHCO3 <= 6)
                {
                    if (AmountSO4 <= (6000 * IncreasingCoefToW8))
                        return NonAggres;

                    else if (AmountSO4 > (6000 * IncreasingCoefToW8) && AmountSO4 <= (8000 * IncreasingCoefToW8))
                        return MildlyAggres;

                    else if (AmountSO4 > (8000 * IncreasingCoefToW8) && AmountSO4 <= (12000 * IncreasingCoefToW8))
                        return MediumAggres;

                    else
                        return HighlyAggres;
                }

                else if (AmountHCO3 > 6)
                {
                    if (AmountSO4 <= (8000 * IncreasingCoefToW8))
                        return NonAggres;

                    else if (AmountSO4 > (8000 * IncreasingCoefToW8) && AmountSO4 <= (12000 * IncreasingCoefToW8))
                        return MildlyAggres;

                    else if (AmountSO4 > (12000 * IncreasingCoefToW8) && AmountSO4 <= (15000 * IncreasingCoefToW8))
                        return MediumAggres;

                    else
                        return HighlyAggres;
                }

                else
                    return "Введите значение HCO3";
            }
        }
        public static string CementIIIW10_14
        {
            get
            {
                if (AmountSO4 <= 10200)
                    return NonAggres;

                else if (AmountSO4 > 10200 && AmountSO4 <= 12000)
                    return MildlyAggres;

                else if (AmountSO4 > 12000 && AmountSO4 <= 15000)
                    return MediumAggres;

                else
                    return HighlyAggres;
            }
        }
        public static string CementIIIW16_20
        {
            get
            {
                if (AmountSO4 <= 12000)
                    return NonAggres;

                else if (AmountSO4 > 12000 && AmountSO4 <= 15000)
                    return MildlyAggres;

                else if (AmountSO4 > 15000 && AmountSO4 <= 20000)
                    return MediumAggres;

                else
                    return HighlyAggres;
            }
        }

        public static string[] GetAllCement()
        {
            string[] Set = { 
                             CementIW4, CementIW6, CementIW8, CementIW10_14, CementIW16_20,
                             CementIIW4, CementIIW6, CementIIW8, CementIIW10_14, CementIIW16_20,
                             CementIIIW4, CementIIIW6, CementIIIW8, CementIIIW10_14, CementIIIW16_20
                           };
            return Set;
        }
    }
}
