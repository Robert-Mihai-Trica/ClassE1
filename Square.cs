using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassE1
{
    class Square
    {
        private int side;
        private int area;

        public Square(int side)
        {
            this.side = side;
            calcArea();
        }
        private void calcArea()
        {
            this.area = side * side;
        }
        public int Side
        {
            get
            {
                return side;
            }
        }
        public int Area
        {
            get
            {
                return area;
            }
        }
    }
}
