using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorFinans.Kerne
{
    public static class FinansielleBeregninger
    {
        public static double MånedligYdelse(double årligRente, int antalMåneder, double hovedstol)
        {
            double rente = årligRente / 12;
            double faktor = Math.Pow((1 + rente), antalMåneder) - 1;
            return (rente + (rente / faktor)) * hovedstol;
        }
    }
}
