using System;

namespace TBRPG_1.Game.Lib
{
    public class Rectangle
    {
        private int _x;
        private int _y;
        private int _width;
        private int _height;

        public int X
        {
            get => _x;
            set
            {
                if (_x == value) return;
                _x = value;
                OnPropertyChanged(0,0,0,0);
            }  
        }

        public int Y
        {
            get => _y;
            set
            {
                if (_y == value) return;
                _y = value;
                OnPropertyChanged(0,0,0,0);
            }  
        }

        public int Width
        {
            get => _width;
            set
            {
                if (_width == value) return;
                _width = value;
                double diff = _width - value;
                _width = value;
                OnPropertyChanged(0,0,diff,0);
            }  
        }

        public int Height
        {
            get => _height;
            set
            {
                if (_height == value) return;
                double diff = _height - value;
                _height = value;
                OnPropertyChanged(0,0,0,diff);
            }  
        }
        
        public Action<double,double,double,double> OnChange { get; set; } = (a,b,c,d) => { };

        private void OnPropertyChanged(double x, double  y, double w, double h)
        {
            OnChange(x,y,w,h);
        }
    }
}