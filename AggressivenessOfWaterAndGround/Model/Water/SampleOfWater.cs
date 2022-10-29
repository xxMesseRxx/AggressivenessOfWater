using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace AggressivenessOfWaterAndGround.Model.Water
{
    internal class SampleOfWater : INotifyPropertyChanged
    {
        private string _boreholeNumber;
        private double _samplingDepth;
        private uint _concentrationOfNaAndKInMilligramsPerLiter;
        private uint _concentrationOfMgInMilligramsPerLiter;
        private uint _concentrationOfCaInMilligramsPerLiter;
        private uint _concentrationOfClInMilligramsPerLiter;
        private uint _concentrationOfSoInMilligramsPerLiter;
        private uint _concentrationOfHcoInMilligramsPerLiter;
        private uint _concentrationOfNoInMilligramsPerLiter;
        private uint _dryResidueInMilligramsPerLiter;
        private double _concentrationOfNaAndKInMilligramsEquivalents;
        private double _concentrationOfMgInMilligramsEquivalents;
        private double _concentrationOfCaInMilligramsEquivalents;
        private double _concentrationOfClInMilligramsEquivalents;
        private double _concentrationOfSoInMilligramsEquivalents;
        private double _concentrationOfHcoInMilligramsEquivalents;
        private double _generalWaterHardnessInMilligramsEquivalents;
        private double _permanentWaterHardnessInMilligramsEquivalents;
        private double _carbonateWaterHardnessInMilligramsEquivalents;
        private double _pHindicator;
        private bool _allowTheUserToEnterDataForMilligramsEquivalents;

        public string BoreholeNumber
        {
            get { return _boreholeNumber; }
            set
            {
                _boreholeNumber = value;
                OnPropertyChanged("BoreholeNumber");
            }
        }
        public double SamplingDepth
        {
            get { return _samplingDepth; }
            set
            {
                _samplingDepth = value;
                OnPropertyChanged("SamplingDepth");
            }
        }
        public uint ConcentrationOfNaAndKInMilligramsPerLiter
        {
            get 
            {
                if (AllowTheUserToEnterDataForMilligramsEquivalents)
                {
                    return _concentrationOfNaAndKInMilligramsPerLiter;
                }
                return (uint)Math.Round(ConcentrationOfNaAndKInMilligramsEquivalents * 23, MidpointRounding.AwayFromZero); // 23 is empirical coefficient
            }
            set
            {
                if (AllowTheUserToEnterDataForMilligramsEquivalents)
                {
                    _concentrationOfNaAndKInMilligramsPerLiter = value;
                    OnPropertyChanged("ConcentrationOfNaAndKInMilligramsPerLiter");
                }
            }
        }
        public uint ConcentrationOfMgInMilligramsPerLiter
        {
            get { return _concentrationOfMgInMilligramsPerLiter; }
            set
            {
                _concentrationOfMgInMilligramsPerLiter = value;
                OnPropertyChanged("ConcentrationOfMgInMilligramsPerLiter");
                if (!AllowTheUserToEnterDataForMilligramsEquivalents)
                {
                    OnPropertyChanged("ConcentrationOfMgInMilligramsEquivalents");
                    NaAndKWereChanged();
                }
            }
        }
        public uint ConcentrationOfCaInMilligramsPerLiter
        {
            get { return _concentrationOfCaInMilligramsPerLiter; }
            set
            {
                _concentrationOfCaInMilligramsPerLiter = value;
                OnPropertyChanged("ConcentrationOfCaInMilligramsPerLiter");
                if (!AllowTheUserToEnterDataForMilligramsEquivalents)
                {
                    OnPropertyChanged("ConcentrationOfCaInMilligramsEquivalents");
                }
            }
        }
        public uint ConcentrationOfClInMilligramsPerLiter
        {
            get { return _concentrationOfClInMilligramsPerLiter; }
            set
            {
                _concentrationOfClInMilligramsPerLiter = value;
                OnPropertyChanged("ConcentrationOfClInMilligramsPerLiter");
                if (!AllowTheUserToEnterDataForMilligramsEquivalents)
                {
                    OnPropertyChanged("ConcentrationOfClInMilligramsEquivalents");
                }
            }
        }
        public uint ConcentrationOfSoInMilligramsPerLiter
        {
            get { return _concentrationOfSoInMilligramsPerLiter; }
            set
            {
                _concentrationOfSoInMilligramsPerLiter = value;
                OnPropertyChanged("ConcentrationOfSoInMilligramsPerLiter");
                if (!AllowTheUserToEnterDataForMilligramsEquivalents)
                {
                    OnPropertyChanged("ConcentrationOfSoInMilligramsEquivalents");
                }
            }
        }
        public uint ConcentrationOfHcoInMilligramsPerLiter
        {
            get { return _concentrationOfHcoInMilligramsPerLiter; }
            set
            {
                _concentrationOfHcoInMilligramsPerLiter = value;
                OnPropertyChanged("ConcentrationOfHcoInMilligramsPerLiter");
                if (!AllowTheUserToEnterDataForMilligramsEquivalents)
                {
                    OnPropertyChanged("ConcentrationOfHcoInMilligramsEquivalents");
                }
            }
        }
        public uint ConcentrationOfNoInMilligramsPerLiter
        {
            get { return _concentrationOfNoInMilligramsPerLiter; }
            set
            {
                _concentrationOfNoInMilligramsPerLiter = value;
                OnPropertyChanged("ConcentrationOfNoInMilligramsPerLiter");
                if (!AllowTheUserToEnterDataForMilligramsEquivalents)
                {
                    OnPropertyChanged("ConcentrationOfNoInMilligramsEquivalents");
                }
            }
        }
        public uint DryResidueInMilligramsPerLiter
        {
            get { return _dryResidueInMilligramsPerLiter; }
            set
            {
                _dryResidueInMilligramsPerLiter = value;
                OnPropertyChanged("DryResidueInMilligramsPerLiter");
            }
        }
        public double ConcentrationOfNaAndKInMilligramsEquivalents
        {
            get 
            {
                if (AllowTheUserToEnterDataForMilligramsEquivalents)
                {
                    return _concentrationOfNaAndKInMilligramsEquivalents;
                }
                else if ((ConcentrationOfClInMilligramsEquivalents + ConcentrationOfSoInMilligramsEquivalents +
                        ConcentrationOfHcoInMilligramsEquivalents) - (ConcentrationOfCaInMilligramsEquivalents +
                        ConcentrationOfMgInMilligramsEquivalents) < 0)
                {
                    return 0;
                }
                return (ConcentrationOfClInMilligramsEquivalents + ConcentrationOfSoInMilligramsEquivalents +
                        ConcentrationOfHcoInMilligramsEquivalents) - (ConcentrationOfCaInMilligramsEquivalents +
                        ConcentrationOfMgInMilligramsEquivalents);
            }
            set
            {
                if (AllowTheUserToEnterDataForMilligramsEquivalents)
                {
                    _concentrationOfNaAndKInMilligramsEquivalents = value;
                    OnPropertyChanged("ConcentrationOfNaAndKInMilligramsEquivalents");
                }   
            }
        }
        public double ConcentrationOfMgInMilligramsEquivalents
        {
            get
            {
                if (AllowTheUserToEnterDataForMilligramsEquivalents)
                {
                    return _concentrationOfMgInMilligramsEquivalents;
                }
                return Math.Round(ConcentrationOfMgInMilligramsPerLiter / 12.1525, 2); // equivalent weight Mg=12.1525
            }
            set
            {
                if (AllowTheUserToEnterDataForMilligramsEquivalents)
                {
                    _concentrationOfMgInMilligramsEquivalents = value;
                    OnPropertyChanged("ConcentrationOfMgInMilligramsEquivalents");
                }
            }
        }
        public double ConcentrationOfCaInMilligramsEquivalents
        {
            get
            {
                if (AllowTheUserToEnterDataForMilligramsEquivalents)
                {
                    return _concentrationOfCaInMilligramsEquivalents;
                }
                return ConcentrationOfCaInMilligramsPerLiter / 20.04; // equivalent weight Ca=20.04
            }
            set
            {
                if (AllowTheUserToEnterDataForMilligramsEquivalents)
                {
                    _concentrationOfCaInMilligramsEquivalents = value;
                    OnPropertyChanged("ConcentrationOfCaInMilligramsEquivalents");
                    OnPropertyChanged("ConcentrationOfNaAndKInMilligramsEquivalents");
                }
            }
        }
        public double ConcentrationOfClInMilligramsEquivalents
        {
            get
            {
                if (AllowTheUserToEnterDataForMilligramsEquivalents)
                {
                    return _concentrationOfClInMilligramsEquivalents;
                }
                return ConcentrationOfClInMilligramsPerLiter / 35.453; // equivalent weight Cl=35.453
            }
            set
            {
                if (AllowTheUserToEnterDataForMilligramsEquivalents)
                {
                    _concentrationOfClInMilligramsEquivalents = value;
                    OnPropertyChanged("ConcentrationOfClInMilligramsEquivalents");
                    OnPropertyChanged("ConcentrationOfNaAndKInMilligramsEquivalents");
                }
            }
        }
        public double ConcentrationOfSoInMilligramsEquivalents
        {
            get 
            {
                if (AllowTheUserToEnterDataForMilligramsEquivalents)
                {
                    return _concentrationOfSoInMilligramsEquivalents;
                }
                return ConcentrationOfSoInMilligramsPerLiter / 48.031; // equivalent weight SO=48.031
            }
            set
            {
                if (AllowTheUserToEnterDataForMilligramsEquivalents)
                {
                    _concentrationOfSoInMilligramsEquivalents = value;
                    OnPropertyChanged("ConcentrationOfSoInMilligramsEquivalents");
                    OnPropertyChanged("ConcentrationOfNaAndKInMilligramsEquivalents");
                }
            }
        }
        public double ConcentrationOfHcoInMilligramsEquivalents
        {
            get 
            {
                if (AllowTheUserToEnterDataForMilligramsEquivalents)
                {
                    return _concentrationOfHcoInMilligramsEquivalents;
                }
                return _concentrationOfHcoInMilligramsPerLiter / 61.016; // equivalent weight HCO=61.016
            }
            set
            {
                if (AllowTheUserToEnterDataForMilligramsEquivalents)
                {
                    _concentrationOfHcoInMilligramsEquivalents = value;
                    OnPropertyChanged("ConcentrationOfHcoInMilligramsEquivalents");
                    OnPropertyChanged("ConcentrationOfNaAndKInMilligramsEquivalents");
                }
            }
        }
        public double GeneralWaterHardnessInMilligramsEquivalents
        {
            get
            {
                if (AllowTheUserToEnterDataForMilligramsEquivalents)
                {
                    return _generalWaterHardnessInMilligramsEquivalents;
                }
                return ConcentrationOfCaInMilligramsEquivalents + ConcentrationOfMgInMilligramsEquivalents;
            }
            set
            {
                if (AllowTheUserToEnterDataForMilligramsEquivalents)
                {
                    _generalWaterHardnessInMilligramsEquivalents = value;
                    OnPropertyChanged("GeneralWaterHardnessInMilligramsEquivalents");
                }
            }
        }
        public double PermanentWaterHardnessInMilligramsEquivalents
        {
            get 
            {
                if (AllowTheUserToEnterDataForMilligramsEquivalents)
                {
                    return _permanentWaterHardnessInMilligramsEquivalents;
                }
                return ConcentrationOfCaInMilligramsEquivalents + ConcentrationOfMgInMilligramsEquivalents -
                       ConcentrationOfHcoInMilligramsEquivalents;
            }
            set
            {
                if (AllowTheUserToEnterDataForMilligramsEquivalents)
                {
                    _permanentWaterHardnessInMilligramsEquivalents = value;
                    OnPropertyChanged("PermanentWaterHardnessInMilligramsEquivalents");
                }
            }
        }
        public double CarbonateWaterHardnessInMilligramsEquivalents
        {
            get
            {
                if (AllowTheUserToEnterDataForMilligramsEquivalents)
                {
                    return _carbonateWaterHardnessInMilligramsEquivalents;
                }
                return ConcentrationOfHcoInMilligramsEquivalents;
            }
            set
            {
                if (AllowTheUserToEnterDataForMilligramsEquivalents)
                {
                    _carbonateWaterHardnessInMilligramsEquivalents = value;
                    OnPropertyChanged("CarbonateWaterHardnessInMilligramsEquivalents");
                }
            }
        }
        public double PHindicator
        {
            get { return _pHindicator; }
            set
            {
                _pHindicator = value;
                OnPropertyChanged("PHindicator");
            }
        }
        public bool AllowTheUserToEnterDataForMilligramsEquivalents
        {
            get { return _allowTheUserToEnterDataForMilligramsEquivalents; }
            set
            { 
                _allowTheUserToEnterDataForMilligramsEquivalents = value;
                OnPropertyChanged("AllowTheUserToEnterDataForMilligramsEquivalents");
                OnPropertyChanged("ConcentrationOfMgInMilligramsEquivalents");
                OnPropertyChanged("ConcentrationOfCaInMilligramsPerLiter");
                OnPropertyChanged("ConcentrationOfClInMilligramsPerLiter");
                OnPropertyChanged("ConcentrationOfSoInMilligramsPerLiter");
                OnPropertyChanged("ConcentrationOfHcoInMilligramsPerLiter");
                NaAndKWereChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void NaAndKWereChanged()
        {
            OnPropertyChanged("ConcentrationOfNaAndKInMilligramsPerLiter");
            OnPropertyChanged("ConcentrationOfNaAndKInMilligramsEquivalents");
        }
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
