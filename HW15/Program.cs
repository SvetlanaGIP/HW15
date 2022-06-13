using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW15
{
    class Program
    {
//        Разработать интерфейс ISeries генерации ряда чисел.
//            Интерфейс содержит следующие элементы:
//метод void setStart(int x) - устанавливает начальное значение
//метод int getNext() - возвращает следующее число ряда
//метод void reset() - выполняет сброс к начальному значению
//Разработать классы ArithProgression и GeomProgression,
//которые реализуют интерфейс ISeries.
//В классах реализовать методы интерфейса в соответствии с логикой
//арифметической и геометрической прогрессии соответственно.
        static void Main(string[] args)
        {
            ArithProgression arithProgression = new ArithProgression();
            arithProgression.setStart(0);
            Console.WriteLine("current arith={0}", arithProgression.getNext());
            Console.WriteLine("current arith={0}", arithProgression.getNext());
            Console.WriteLine("call reset");
            arithProgression.reset();
            Console.WriteLine("current arith={0}", arithProgression.getNext());
            Console.WriteLine("current arith={0}", arithProgression.getNext());
            Console.WriteLine("current arith={0}\n", arithProgression.getNext());


            GeomProgression geomProgression = new GeomProgression();
            geomProgression.setStart(2);
            Console.WriteLine("current geom={0}", geomProgression.getNext());
            Console.WriteLine("current geom={0}", geomProgression.getNext());
            Console.WriteLine("call reset");
            geomProgression.reset();
            Console.WriteLine("current geom={0}", geomProgression.getNext());
            Console.WriteLine("current geom={0}", geomProgression.getNext());
            Console.WriteLine("current geom={0}", geomProgression.getNext());

            Console.Write("press any key to exit");
            Console.ReadKey();
        }
        interface ISeries
        {
            void setStart(int x);
            int getNext();

            void reset();
        }

        class ArithProgression : ISeries
        {
            int startValue = 0;
            int curValue;
            int diff = 10;


            public int getNext()
            {
                this.curValue = this.curValue + diff;
                return this.curValue;
            }

            public void reset()
            {
                this.curValue = this.startValue;
            }

            public void setStart(int x)
            {
                this.startValue = x;
                this.curValue = x;
            }
        }

        class GeomProgression : ISeries
        {
            int startValue = 0;
            int curValue;
            int k = 2;

            public int getNext()
            {
                this.curValue = this.curValue * k;
                return this.curValue;
            }

            public void reset()
            {
                this.curValue = this.startValue;
            }

            public void setStart(int x)
            {
                this.startValue = x;
                this.curValue = x;
            }
        }
    }
}
