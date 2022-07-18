using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AggressivenessOfWaterAndGround.Model.Water
{
    internal static class AggressivenessOfCl
    {
        public static uint AmountCL { private get; set; }
        public static bool CoefFiltratMoreThan01 { private get; set; }

        const string NonAggres = "Неагрессивная";
        const string Aggres = "Агрессивная";

        public static string Cement_20_W6_W8
        {
            get
            {
                if (CoefFiltratMoreThan01)
                {
                    if (AmountCL > 500)
                        return Aggres;
                    else
                        return NonAggres;
                }
                else
                {
                    if (AmountCL > 1150)
                        return Aggres;
                    else
                        return NonAggres;
                }
            }
        }
        public static string Cement_20_W10_W14
        {
            get
            {
                if (CoefFiltratMoreThan01)
                {
                    if (AmountCL > 1300)
                        return Aggres;
                    else
                        return NonAggres;
                }
                else
                {
                    if (AmountCL > 3000)
                        return Aggres;
                    else
                        return NonAggres;
                }
            }
        }
        public static string Cement_20_W16_W20
        {
            get
            {
                if (CoefFiltratMoreThan01)
                {
                    if (AmountCL > 4100)
                        return Aggres;
                    else
                        return NonAggres;
                }
                else
                {
                    if (AmountCL > 5000)
                        return Aggres;
                    else
                        return NonAggres;
                }
            }
        }
        public static string Cement_30_W6_W8
        {
            get
            {
                if (CoefFiltratMoreThan01)
                {
                    if (AmountCL > 700)
                        return Aggres;
                    else
                        return NonAggres;
                }
                else
                {
                    if (AmountCL > 1400)
                        return Aggres;
                    else
                        return NonAggres;
                }
            }
        }
        public static string Cement_30_W10_W14
        {
            get
            {
                if (CoefFiltratMoreThan01)
                {
                    if (AmountCL > 1850)
                        return Aggres;
                    else
                        return NonAggres;
                }
                else
                {
                    if (AmountCL > 3700)
                        return Aggres;
                    else
                        return NonAggres;
                }
            }
        }
        public static string Cement_30_W16_W20
        {
            get
            {
                if (CoefFiltratMoreThan01)
                {
                    if (AmountCL > 8300)
                        return Aggres;
                    else
                        return NonAggres;
                }
                else
                {
                    if (AmountCL > 9500)
                        return Aggres;
                    else
                        return NonAggres;
                }
            }
        }
        public static string Cement_50_W6_W8
        {
            get
            {
                if (CoefFiltratMoreThan01)
                {
                    if (AmountCL > 1000)
                        return Aggres;
                    else
                        return NonAggres;
                }
                else
                {
                    if (AmountCL > 1750)
                        return Aggres;
                    else
                        return NonAggres;
                }
            }
        }
        public static string Cement_50_W10_W14
        {
            get
            {
                if (CoefFiltratMoreThan01)
                {
                    if (AmountCL > 2700)
                        return Aggres;
                    else
                        return NonAggres;
                }
                else
                {
                    if (AmountCL > 4700)
                        return Aggres;
                    else
                        return NonAggres;
                }
            }
        }
        public static string Cement_50_W16_W20
        {
            get
            {
                if (CoefFiltratMoreThan01)
                {
                    if (AmountCL > 18000)
                        return Aggres;
                    else
                        return NonAggres;
                }
                else
                {
                    if (AmountCL > 20000)
                        return Aggres;
                    else
                        return NonAggres;
                }
            }
        }
        public static string[] GetAllCement()
        {
            string[] Set = {
                             Cement_20_W6_W8, Cement_20_W10_W14, Cement_20_W16_W20,
                             Cement_30_W6_W8, Cement_30_W10_W14, Cement_30_W16_W20,
                             Cement_50_W6_W8, Cement_50_W10_W14, Cement_50_W16_W20
                           };
            return Set;
        }
    }
}
