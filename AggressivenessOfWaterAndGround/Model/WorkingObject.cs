using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace AggressivenessOfWaterAndGround.Model
{
    internal class WorkingObject : INotifyPropertyChanged
    {
        private string _code;
        private string _name;
        private string _archiveNumber; 

        public string ObjectCode
        {
            get { return _code; }
            set
            { 
                _code = value;
                OnPropertyChanged("ObjectCode");
            }
        }
        public string ObjectName
        {
            get { return _name; }
            set 
            { 
                _name = value;
                OnPropertyChanged("ObjectName");
            }
        }
        public string ArchiveNumber
        {
            get { return _archiveNumber; }
            set
            { 
                _archiveNumber = value;
                OnPropertyChanged("ArchiveNumber");
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
