using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryFigureApp.Figure
{
    public class Rectangle : IFigure
    {
        public bool EventCheck = false;

        private double[] _sides;
        private double _number;

        public Rectangle(params double[] sides)
        {
            _sides = sides;
            _number = _sides[0];
        }

        public double ResultArea()
        {
            if (_sides.Length != 4)
                return 0;

            if (Array.TrueForAll(_sides, value => value == _number))
            {
                EventCheck = true;
            }
            // Проверка на трапецию
            else if (_sides.Distinct().Count() > 2)
            {
                return 0;
            }
            else
            {
                var firstSide = _sides.Where(x => _sides.Any()).FirstOrDefault();
                var secondSide = _sides.Where(x => x.CompareTo(firstSide) != 0).FirstOrDefault();

                return firstSide * secondSide;
            }

            return 0;


        }

        public void ViewInfo()
        {
            string message = EventCheck ? "Это квадрат" : ResultArea().ToString();
            Console.WriteLine(message);
        }
    }
}
