﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace AggressivenessOfWaterAndGround.Model.Water
{
    internal class AggressivenessOfSO4 : INotifyPropertyChanged
    {
        public uint AmountSO4 {private get; set; }

        private double amountHCO3;
        public double AmountHCO3
        {
            private get { return amountHCO3; }
            set { amountHCO3 = value < 0 ? 0 : value; }
        }
        

        const double IncreasingCoefToW6 = 1.3;
        const double IncreasingCoefToW8 = 1.7;

        // These properties are returning the power of aggressiveness
        // that depends from amount SO4 and HCO3
        public string CementIW4
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
        public string CementIW6
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
        public string CementIW8
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
        public string CementIW10_14
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
        public string CementIW16_20
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
        public string CementIIW4
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
        public string CementIIW6
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
        public string CementIIW8
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
        public string CementIIW10_14
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
        public string CementIIW16_20
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
        public string CementIIIW4
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
        public string CementIIIW6
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
        public string CementIIIW8
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
        public string CementIIIW10_14
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
        public string CementIIIW16_20
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

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
