using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1
{
    class Person : INotifyPropertyChanged
    {
       
        private string _name;

        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                RaiseEvent();
            }
        }

        private void RaiseEvent([CallerMemberName] string propertyName = null)
        {
           PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        public int Age { get; set; }
        public string Email { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
