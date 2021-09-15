using System;
using Microsoft.AspNetCore.Components.Forms;

namespace TBRPG_1.Game.Lib
{
    public class Percentage
    {

        public Percentage(int max, int current)
        {
            _Max = max;
            _Current = current;
        }
        
        public int _Max = 0;
        public int _Current = 0;

        public double Percent => _Current==0? 0 : (double) _Current / Max;
        
        public int Max
        {
            get=>_Max;
            
            set
            {
                if (_Max == value) return;
                _Max = value;
                double diff = _Max - value;
                _Max = value;
                OnPropertyChanged(diff);
            }
        }

        public int Current
        {
            get => _Current;
            set
            {
                if (_Current == value) return;
                double diff = _Current - value;
                _Current = value;
                OnPropertyChanged(diff);
            }
        }

        public bool Modify(int delta)
        {
            if (Current == 0 && delta < 0) return false;
            if (Current == Max && delta > 0) return false;
            Current = Math.Clamp(Current + delta, 0, Max);
            return !(Current == 0 || Current == Max);
        }

        public Action<double> OnChange { get; set; } = (c) => { };

        private void OnPropertyChanged(double diff)
        {
            OnChange(diff);
        }

    }
}