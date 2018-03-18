using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Lesson3
{
    public class InkEditModes : INotifyPropertyChanged
    {
        private InkCanvasEditingMode _editingMode;

        public InkEditModes()
        {
            EditingMode = InkCanvasEditingMode.Select;
        }

        public InkCanvasEditingMode EditingMode
        {
            get { return _editingMode; }
            set
            {
                _editingMode = value;
                RaiseEvent();
            }
        }

        private string _nameTag;

        public string NameTag
        {
            get { return _nameTag; }
            set
            {
                _nameTag = value;
                RaiseEvent();
            }
        }

        public void RaiseEvent([CallerMemberName]string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
