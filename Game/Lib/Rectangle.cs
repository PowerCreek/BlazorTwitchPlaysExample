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
                OnPropertyChanged();
                _x = value;
            }  
        }

        public int Y
        {
            get => _y;
            set
            {
                if (_y == value) return;
                OnPropertyChanged();
                _y = value;
            }  
        }

        public int Width
        {
            get => _width;
            set
            {
                if (_width == value) return;
                OnPropertyChanged();
                _width = value;
            }  
        }

        public int Height
        {
            get => _height;
            set
            {
                if (_height == value) return;
                OnPropertyChanged();
                _height = value;
            }  
        }
        
        public Action<Rectangle> OnChange { get; set; } = (c) => { };

        private void OnPropertyChanged()
        {
            OnChange(this);
        }
    }
}