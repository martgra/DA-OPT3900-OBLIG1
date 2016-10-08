using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObligEn
{
    public class GreedyMethod
    // klasse som inneholder metode for å kalkulere beste rute basert på greedy metode.
    {
        public static int[] greedyRoute(int[,] cities)
        // metode som regner ut beste rute basert på greedy metode. initialiseres ved å sende inn array cities.
        {
            int[] route = new int[cities.GetLength(0)];
            // initierer array route av typen int med lengden til cities i dimensjon 0. Brukes til å lagre ruten på byene.
            bool[] connected = new bool[cities.GetLength(0)];
            // initierer array connected av typen boolean. Gis lengden på lengden på cities i dimensjon 0. 
            int i, j;
            // oppretter variablene i og j.
            Random rnd = new Random();
            // oppretter objektet rnd av typen Random.

            for (i = 0; i < cities.GetLength(0); i++)
            /* forløkke som går lik lengden cities i dimensjon 1. Fyller inn array route med verdien til i 
                fyller inn verdien til connected i posisjon i med false. 
             */
            {
                route[i] = i;
                connected[i] = false;
            }
            
            i = route[rnd.Next(0, cities.GetLength(0))];
            // veldger tilfeldig verdi for i innenfor intervallet 0 og lengden på cities i dimensjon 0. 
            route[0] = i;
            // legger den tilfeldige byen i starten av ruten
            route[i] = 0;
            // legger verdien som ligger i starten av ruten til posisjon til verdien i hadde. 
            connected[0] = true;
            // angir at den første i byen i ruten er valgt.
            int current = route[0];
            // gir variablen current verdien til byen som ligger lagret i første posisjon i ruten.
            int min;
            // oppretter verdien min av typen int. skal brukes til å finne den billigste veien til neste by.
            int next = 1;
            // oppretter variabel for å kunne lagre neste by i ruten. 

            for (i = 0; i < cities.GetLength(0) - 1; i++)
            // løkken kjører for å finne billigste verdi til neste by fra nåværende posisjon.
            {
                min = -1;

                for (j = 0; j < cities.GetLength(0); j++)
                {
                    if (cities[current, j] != 0 && connected[j] == false)
                    {
                        if (min == -1)
                        {
                            min = cities[current, j];
                            next = j;
                        }

                        else if (cities[current, j] < min)
                        {
                            min = cities[current, j];
                            next = j;
                        }
                    }
                }

                if (next != route[i + 1])
                {
                    route[cities.GetLength(0) - 1] = i;
                    route[i + 1] = next;
                }

                connected[current] = true;
                current = next;
            }

            return route;

        }
    }
}