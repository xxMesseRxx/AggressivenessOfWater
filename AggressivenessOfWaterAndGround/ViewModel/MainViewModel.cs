using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using AggressivenessOfWaterAndGround.Model.Water;
using System.Collections.ObjectModel;

namespace AggressivenessOfWaterAndGround.ViewModel
{
    internal class MainViewModel : INotifyPropertyChanged
    {
        public AggressivenessOfSO4 AggressOfSO4 { get; private set; } = new AggressivenessOfSO4();
        public AggressivenessOfCl AggressOfCl { get; private set; } = new AggressivenessOfCl();
        public ObservableCollection<SampleOfWater> WaterSamples { get; set; }
        
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }

        public MainViewModel()
        {
            WaterSamples = new ObservableCollection<SampleOfWater>();
        }
    }
}
