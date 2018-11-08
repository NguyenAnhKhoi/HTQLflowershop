using System;

namespace ClassLibrary
{
    public class Flowers
    {
        private int[] Flo = new int[4];

        public Flowers(int[] flow)
        {
            this.Flo = flow;
        }

        public int[] getFlo()
        {
            return Flo;
        }
    }
}
