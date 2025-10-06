using Lab2_GorbatovZ.Z_BPI_23_01.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_GorbatovZ.Z_BPI_23_01.ViewModels
{
    class FunctionViewModelA : INotifyPropertyChanged
    {
        private FunctionModelA _func;

        public FunctionViewModelA()
        {
            _func = new FunctionModelA(0, 0);
        }
        public string ImagePath => _func.Path;
        public double A
        {
            get { return _func.A; }
            set
            {
                if (_func.A != value)
                {
                    _func.A = value;
                    OnPropertyChanged();
                    OnPropertyChanged(nameof(Result)); 
                }
            }
        }
        public int Index
        {
            get { return _func.Index; }
            set
            {
                if (_func.Index != value)
                {
                    _func.Index = value;
                    OnPropertyChanged();
                    OnPropertyChanged(nameof(Result));
                }
            }
        }

        public double Result => _func.Result;

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


    }
}
