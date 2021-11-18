using System;
using System.Collections.Generic;
using System.Text;

namespace Practice_8
{
    interface IFigure
    {
        int Square { get; set; }
        int Perimetr { get; set; }

    }

    public class Circle : IFigure, IComparable
    {
        int perimetr=0;
        int square=0;
        public string FigureInfo()
        {
            string info = "Площадь=" + square + " " + "Периметр=" + perimetr;
            return info;
        }
        public Circle()
        {
            square = 0;
            perimetr = 0;
        }
        public int Square
        {          
                get { return square; }
            set { square = value; }
        }
        public int Perimetr
        {
            get { return perimetr; }
            set { perimetr = value; }
        }
        public int CompareTo(object obj)
        {
            Circle temp = (Circle)obj;
            if (this.square > temp.square) return 1;
            if (this.square < temp.square) return -1;
            return 0;
        }
    }
    public class Rectangle : IFigure, IComparable
    {
        int perimetr;
        int square;
        public string FigureInfo()
        {
            string info = "Площадь=" + square + " " + "Периметр=" + perimetr;
            return info;
        }


        public Rectangle()
        {
            square = 0;
            perimetr = 0;
        }
        public int Square
        {
            get { return square; }
            set { square = value; }
        }
        public int Perimetr
        {
            get { return perimetr; }
            set { perimetr = value; }
        }
        public int CompareTo(object obj)
        {
            Rectangle temp = (Rectangle)obj;
            if (this.square > temp.square) return 1;
            if (this.square < temp.square) return -1;
            return 0;
        }
    }

}
