using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace AggressivenessOfWaterAndGround.Model.Water
{
    internal class AggressivenessOfCl : INotifyPropertyChanged
    {
        private uint _amountCl;
        private bool _coefFiltratMoreThan01;

        public uint AmountCl
        {
            get { return _amountCl; }
            set 
            { 
                _amountCl = value; 
                OnPropertyChanged("AmountCl");
                AllCementPropertyChanged();
            }
        }
        public bool CoefFiltratMoreThan01
        {
            get { return _coefFiltratMoreThan01; }
            set 
            { 
                _coefFiltratMoreThan01 = value;
                OnPropertyChanged("CoefFiltratMoreThan01");
                AllCementPropertyChanged();
            }
        }

        public string Cement_20_W6_W8
        {
            get
            {
                if (CoefFiltratMoreThan01)
                {
                    if (AmountCl > 500)
                        return DegreeOfAggres.Aggres;
                    else
                        return DegreeOfAggres.NonAggres;
                }
                else
                {
                    if (AmountCl > 1150)
                        return DegreeOfAggres.Aggres;
                    else
                        return DegreeOfAggres.NonAggres;
                }
            }
        }
        public string Cement_20_W10_W14
        {
            get
            {
                if (CoefFiltratMoreThan01)
                {
                    if (AmountCl > 1300)
                        return DegreeOfAggres.Aggres;
                    else
                        return DegreeOfAggres.NonAggres;
                }
                else
                {
                    if (AmountCl > 3000)
                        return DegreeOfAggres.Aggres;
                    else
                        return DegreeOfAggres.NonAggres;
                }
            }
        }
        public string Cement_20_W16_W20
        {
            get
            {
                if (CoefFiltratMoreThan01)
                {
                    if (AmountCl > 4100)
                        return DegreeOfAggres.Aggres;
                    else
                        return DegreeOfAggres.NonAggres;
                }
                else
                {
                    if (AmountCl > 5000)
                        return DegreeOfAggres.Aggres;
                    else
                        return DegreeOfAggres.NonAggres;
                }
            }
        }
        public string Cement_30_W6_W8
        {
            get
            {
                if (CoefFiltratMoreThan01)
                {
                    if (AmountCl > 700)
                        return DegreeOfAggres.Aggres;
                    else
                        return DegreeOfAggres.NonAggres;
                }
                else
                {
                    if (AmountCl > 1400)
                        return DegreeOfAggres.Aggres;
                    else
                        return DegreeOfAggres.NonAggres;
                }
            }
        }
        public string Cement_30_W10_W14
        {
            get
            {
                if (CoefFiltratMoreThan01)
                {
                    if (AmountCl > 1850)
                        return DegreeOfAggres.Aggres;
                    else
                        return DegreeOfAggres.NonAggres;
                }
                else
                {
                    if (AmountCl > 3700)
                        return DegreeOfAggres.Aggres;
                    else
                        return DegreeOfAggres.NonAggres;
                }
            }
        }
        public string Cement_30_W16_W20
        {
            get
            {
                if (CoefFiltratMoreThan01)
                {
                    if (AmountCl > 8300)
                        return DegreeOfAggres.Aggres;
                    else
                        return DegreeOfAggres.NonAggres;
                }
                else
                {
                    if (AmountCl > 9500)
                        return DegreeOfAggres.Aggres;
                    else
                        return DegreeOfAggres.NonAggres;
                }
            }
        }
        public string Cement_50_W6_W8
        {
            get
            {
                if (CoefFiltratMoreThan01)
                {
                    if (AmountCl > 1000)
                        return DegreeOfAggres.Aggres;
                    else
                        return DegreeOfAggres.NonAggres;
                }
                else
                {
                    if (AmountCl > 1750)
                        return DegreeOfAggres.Aggres;
                    else
                        return DegreeOfAggres.NonAggres;
                }
            }
        }
        public string Cement_50_W10_W14
        {
            get
            {
                if (CoefFiltratMoreThan01)
                {
                    if (AmountCl > 2700)
                        return DegreeOfAggres.Aggres;
                    else
                        return DegreeOfAggres.NonAggres;
                }
                else
                {
                    if (AmountCl > 4700)
                        return DegreeOfAggres.Aggres;
                    else
                        return DegreeOfAggres.NonAggres;
                }
            }
        }
        public string Cement_50_W16_W20
        {
            get
            {
                if (CoefFiltratMoreThan01)
                {
                    if (AmountCl > 18000)
                        return DegreeOfAggres.Aggres;
                    else
                        return DegreeOfAggres.NonAggres;
                }
                else
                {
                    if (AmountCl > 20000)
                        return DegreeOfAggres.Aggres;
                    else
                        return DegreeOfAggres.NonAggres;
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }

        private void AllCementPropertyChanged()
        {
            OnPropertyChanged("Cement_20_W6_W8");
            OnPropertyChanged("Cement_20_W10_W14");
            OnPropertyChanged("Cement_20_W16_W20");
            OnPropertyChanged("Cement_30_W6_W8");
            OnPropertyChanged("Cement_30_W10_W14");
            OnPropertyChanged("Cement_30_W16_W20");
            OnPropertyChanged("Cement_50_W6_W8");
            OnPropertyChanged("Cement_50_W10_W14");
            OnPropertyChanged("Cement_50_W16_W20");
        }
    }
}
