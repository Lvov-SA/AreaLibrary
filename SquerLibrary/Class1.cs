using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaLibrary
{

    public class Figure 
    {
        public bool isRectangle = false; //переменная для хранения данных, есть ли у треугольника прямой угол
        public double area; // переменная хранения площади фигуры
        /// <summary>
        /// конструктор с перегрузкой, вызыввется при передаче трех значений
        /// </summary>
        /// <param name="a_">первая сторона треугольника</param>
        /// <param name="b_">вторая сторона треугольника</param>
        /// <param name="c_">третья сторона треугольника</param>
        public Figure(double a_, double b_, double c_)
        {
            if(a_<=0 || b_<=0 || c_ <= 0)
            {
                throw new Exception("Данные введены некорректно");
            }
            double p = (a_ + b_ + c_) / 2; // полупериметр для удобства чтения формулы вычисления
            if (p <= a_ || p<= b_ || p<= c_)
            {
                throw new Exception("Данные введены некорректно");
            }
            area = Math.Sqrt(p * (p - a_) * (p - b_) * (p - c_));
            
            // проверка на прямоугольность исходя из теоремы Пифагора
            if (c_ == Math.Sqrt(Math.Pow(a_, 2) + Math.Pow(b_, 2)) || b_ == Math.Sqrt(Math.Pow(a_, 2) + Math.Pow(c_, 2)) || a_ == Math.Sqrt(Math.Pow(b_, 2) + Math.Pow(c_, 2)))
            {
                isRectangle = true;
            }
            else
            {
                isRectangle = false;
            }
        }
        /// <summary>
        ///  конструктор с перегрузкой, вызывается при передаче только одного значения
        /// </summary>
        /// <param name="r_"> радиус окружности</param>
        public Figure(double r_)
        {
            if (r_ <= 0)
            {
                throw new Exception("Данные введены некорректно");
            }
            area = Math.PI * Math.Pow(r_, 2);
        }
    }

}
