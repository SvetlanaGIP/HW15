using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISeries
{
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
