using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Questions
    {

        public double bisection1(double x)
        {
            return 3*x-Math.Cos(x)-1;
        }
      
        public double bisection2(double x)
        {
            return (Math.Pow(x, 3)) - 6 * (Math.Pow(x, 2)) + 11 * x - 6;
        }
        public double bisection3(double x)
        {
            return Math.Pow(x, 4) + Math.Pow(x, 2) - 80;

        }
        // Regular Falsi
        public double regular1(double x)
        {
           
            return (Math.Pow(Math.E, -x)) - x;
        }

        public double regular2(double x)
        {
            return x + Math.Log10(x) - 2;
        }

        public double regular3(double x)
        {
            return Math.Pow(Math.E, x) - Math.Pow(x, 2);
        }
        // Secant Method
        public double secant1(double x)
        {
            return x * Math.Pow(Math.E, x) - 1;
        }
        public double secant2(double x)
        {
            return x*Math.Log10(x) - 1.2;
        }
        public double secant3(double x)
        {
            return 3 * x - Math.Cos(x) - 1;
        }

     

    }
    // Newton Raphson Method
    class newton1
    {
        public double fx(double x)
        {
            return 2 * x - 3 * Math.Sin(x) - 5;
        }
        public double fxd(double x)
        {
            return 2 - Math.Cos(x);
        }
    }
    class newton2
    {
        public double fx(double x)
        {
            return x + Math.Log10(x) - 2;
        }
        public double fxd(double x)
        {
            return 1 + (1 / x);
        }
    }
    class newton3
    {
        public double fx(double x)
        {
            return Math.Cos(x) - 3 * x + 1;
        }
        public double fxd(double x)
        {
            return -Math.Sin(x) - 3;
        }
    }

 // Fixed Point Method
        class fix1
    {
        public double equation1(double x)
        {
            return 3 - Math.Pow(x, 2);

        }
        public double equation2(double x)
        {
            return Math.Pow((3-x),0.333);

        }
        public double equation1_d(double x)
        {
            return -3 * Math.Pow(x, 2);

        }
        public double equation2_d(double x)
        {
            return -1 / 3 * Math.Pow((3 - x), -2 / 3);

        }
    }

    class fix5
    {
        public double equation1(double x)
        {
            return (Math.Cos(x)+1)/3;

        }
        public double equation2(double x)
        {
            return Math.Pow((3 - x), 0.333);

        }
        public double equation1_d(double x)
        {
            return -((Math.Sin(x))/3);

        }
        public double equation2_d(double x)
        {
            return -1 / 3 * Math.Pow((3 - x), -2 / 3);

        }
    }

    class fix2
    {
        public double equation1(double x)
        {
            return (Math.Sin(x) + 10) / 10;

        }
      
        public double equation1_d(double x)
        {
            return (Math.Cos(x))/10;

        }
      
    }
    class fix3
    {
        public double equation1(double x)
        {
            return Math.Tanh(Math.Pow(Math.E,-x));

        }
       
        public double equation1_d(double x)
        {
            return -((Math.Pow(Math.E,-x))/(Math.Pow(Math.E,2*x)+1));

        }
      
    }
    class fix4
    {
    
        public double equation2(double x)
        {
            return Math.Pow(100-Math.Pow(x,3),0.5);
        }
      
        public double equation2_d(double x)
        {
            return -((3*Math.Pow(x,2))/(2*Math.Sqrt(100-Math.Pow(x,3))));


        }
    }

}

