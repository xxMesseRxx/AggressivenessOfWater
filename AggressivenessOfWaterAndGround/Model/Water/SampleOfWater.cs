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
            get { return _concentrationOfNaAndKInMilligramsPerLiter; }
            set
            {
                _concentrationOfNaAndKInMilligramsPerLiter = value;
                OnPropertyChanged("ConcentrationOfNaAndKInMilligramsPerLiter");
            }
        }
        public uint ConcentrationOfMgInMilligramsPerLiter
        {
            get { return _concentrationOfMgInMilligramsPerLiter; }
            set
            {
                _concentrationOfMgInMilligramsPerLiter = value;
                OnPropertyChanged("ConcentrationOfMgInMilligramsPerLiter");
            }
        }
        public uint ConcentrationOfCaInMilligramsPerLiter
        {
            get { return _concentrationOfCaInMilligramsPerLiter; }
            set
            {
                _concentrationOfCaInMilligramsPerLiter = value;
                OnPropertyChanged("ConcentrationOfCaInMilligramsPerLiter");
            }
        }
        public uint ConcentrationOfClInMilligramsPerLiter
        {
            get { return _concentrationOfClInMilligramsPerLiter; }
            set
            {
                _concentrationOfClInMilligramsPerLiter = value;
                OnPropertyChanged("ConcentrationOfClInMilligramsPerLiter");
            }
        }
        public uint ConcentrationOfSoInMilligramsPerLiter
        {
            get { return _concentrationOfSoInMilligramsPerLiter; }
            set
            {
                _concentrationOfSoInMilligramsPerLiter = value;
                OnPropertyChanged("ConcentrationOfSoInMilligramsPerLiter");
            }
        }
        public uint ConcentrationOfHcoInMilligramsPerLiter
        {
            get { return _concentrationOfHcoInMilligramsPerLiter; }
            set
            {
                _concentrationOfHcoInMilligramsPerLiter = value;
                OnPropertyChanged("ConcentrationOfHcoInMilligramsPerLiter");
            }
        }
        public uint ConcentrationOfNoInMilligramsPerLiter
        {
            get { return _concentrationOfNoInMilligramsPerLiter; }
            set
            {
                _concentrationOfNoInMilligramsPerLiter = value;
                OnPropertyChanged("ConcentrationOfNoInMilligramsPerLiter");
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
            get { return _concentrationOfNaAndKInMilligramsEquivalents; }
            set
            {
                _concentrationOfNaAndKInMilligramsEquivalents = value;
                OnPropertyChanged("ConcentrationOfNaAndKInMilligramsEquivalents");
            }
        }
        public double ConcentrationOfMgInMilligramsEquivalents
        {
            get { return _concentrationOfMgInMilligramsEquivalents; }
            set
            {
                _concentrationOfMgInMilligramsEquivalents = value;
                OnPropertyChanged("ConcentrationOfMgInMilligramsEquivalents");
            }
        }
        public double ConcentrationOfCaInMilligramsEquivalents
        {
            get { return _concentrationOfCaInMilligramsEquivalents; }
            set
            {
                _concentrationOfCaInMilligramsEquivalents = value;
                OnPropertyChanged("ConcentrationOfCaInMilligramsEquivalents");
            }
        }
        public double ConcentrationOfClInMilligramsEquivalents
        {
            get { return _concentrationOfClInMilligramsEquivalents; }
            set
            {
                _concentrationOfClInMilligramsEquivalents = value;
                OnPropertyChanged("ConcentrationOfClInMilligramsEquivalents");
            }
        }
        public double ConcentrationOfSoInMilligramsEquivalents
        {
            get { return _concentrationOfSoInMilligramsEquivalents; }
            set
            {
                _concentrationOfSoInMilligramsEquivalents = value;
                OnPropertyChanged("ConcentrationOfSoInMilligramsEquivalents");
            }
        }
        public double ConcentrationOfHcoInMilligramsEquivalents
        {
            get { return _concentrationOfHcoInMilligramsEquivalents; }
            set
            {
                _concentrationOfHcoInMilligramsEquivalents = value;
                OnPropertyChanged("ConcentrationOfHcoInMilligramsEquivalents");
            }
        }
        public double GeneralWaterHardnessInMilligramsEquivalents
        {
            get { return _generalWaterHardnessInMilligramsEquivalents; }
            set
            {
                _generalWaterHardnessInMilligramsEquivalents = value;
                OnPropertyChanged("GeneralWaterHardnessInMilligramsEquivalents");
            }
        }
        public double PermanentWaterHardnessInMilligramsEquivalents
        {
            get { return _permanentWaterHardnessInMilligramsEquivalents; }
            set
            {
                _permanentWaterHardnessInMilligramsEquivalents = value;
                OnPropertyChanged("PermanentWaterHardnessInMilligramsEquivalents");
            }
        }
        public double CarbonateWaterHardnessInMilligramsEquivalents
        {
            get { return _carbonateWaterHardnessInMilligramsEquivalents; }
            set
            {
                _carbonateWaterHardnessInMilligramsEquivalents = value;
                OnPropertyChanged("CarbonateWaterHardnessInMilligramsEquivalents");
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


        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
