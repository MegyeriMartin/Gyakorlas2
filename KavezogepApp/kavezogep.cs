using System;
using System.Collections.Generic;
using System.Text;

namespace KavezogepApp
{
    internal class kavezogep
    {
        private int VizKeszletML;
        public void VizTolt(int ml)
        {
            if(ml < 0)
            {
                VizKeszletML = 0;
                Console.WriteLine("Hiba! Negativ erteket adtal meg");
            }
            else
            {
                VizKeszletML += ml;
            }


        }

    public void KaveFozes()
        {
            if(VizKeszletML >= 150)
            {
                VizKeszletML -= 150;
                Console.WriteLine("kave lefozve");
            }
            else
            {
                Console.WriteLine("Nem all rendelkesre eleg viz");
            }
        }
    }
}
