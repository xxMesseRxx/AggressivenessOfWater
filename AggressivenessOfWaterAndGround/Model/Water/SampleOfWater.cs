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

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
