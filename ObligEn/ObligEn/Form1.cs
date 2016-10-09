using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObligEn
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        //
        public void buttonCalculate_Click(object sender, EventArgs e)
        {

            if(numberOfCities.Text != "")
            // if statement for å sjekke at det skrives noe i input label
            {

                int cities = Convert.ToInt32(numberOfCities.Text);
                // input på antall byer fra input label
                int[,] array1 = GenerateGraph.generateGraph(cities);
                //generering av felles graf for byene med argument antall byer
                int[] randomRoute = RandomMethod.randMethod(array1, cities);
                // funksjon for Random metode. Returnerer random rute
                int[] randomIntterativeRoute = RandomItterativeMethod.iterativeRndMethod(array1, cities);
                // funksjon from Random Itterative metode. Returnerer Random Itterative rute
                int[] greedyRoute = GreedyMethod.greedyRoute(array1);
                //funksjon for Greedy metode. Returnerer greedy rute.
                int[] greedyItterativeRoute = GreedyItterative.greedyItterative(greedyRoute, array1);
                //funksjon for greedy itterative rute med greedy rute som utgangspunkt. Returnerer greedy itterativ rute.
                int[] GreedyItterativeRandom = GreedyItterative.greedyItterative(randomRoute, array1);
                //funksjon for greedy itterative rute med random rute som utgangspunkt. Returnerer greedy itterativ rute.
                int[] GreedyItterativeRandomItterative = GreedyItterative.greedyItterative(randomIntterativeRoute, array1);
                //funksjon for greedy itterative rute med random itterative rute som utgangspunkt. Returnerer greedy itterativ rute.
                
                /*
                #### Variabler til bruk for utredning av snitt og beste resultat ####
                */

                int itteration = 100;
                //antall itterasjoner som skal kjøres i forløkken for å regne ut beste resultat og snitt.
                int[] randomMethod = new int[itteration];
                //tabell for å lagre alle "tries" for random metode. Pr nå redundent
                int[] randomItterativeMethod = new int[itteration];
                //tabell for å lagre alle "tries" for random itterativ metode. Pr nå redundent
                int[] greedyMethod = new int[itteration];
                //tabell for å lagre alle "tries" for greedy metode. Pr nå redundent
                int[] greedyItterativeGreedy = new int[itteration];
                //tabell for å lagre alle "tries" for greedy itterativ metode med greedy som utgangspunkt. Pr nå redundent
                int[] greedyItterativeRandom = new int[itteration];
                //tabell for å lagre alle "tries" for greedy itterativ metode med random som utgangspunkt. Pr nå redundent
                int[] greedyItterativeRandomItterative = new int[itteration];
                //tabell for å lagre alle "tries" for greedy itterativ metode med random itterativ som utgangspunkt. Pr nå redundent

                double randomMethodMean = 0;
                //variabel for gjennomsnitt random metode
                double randomItterativeMethodMean = 0;
                //variabel for gjennomsnitt random itterativ metode
                double greedyMethodMean = 0;
                //variabel for gjennomsnitt greedy metode
                double greedyItterativeGreedyMean = 0;
                //variabel for gjennomsnitt greedy itterativ metode med greedy som utgangspunkt
                double greedyItterativeRandomMean = 0;
                //variabel for gjennomsnitt greedy itterativ metode med random som utgangspunkt
                double greedyItterativeItterativeRandomMean = 0;
                //variabel for gjennomsnitt greedy itterativ metode med random itterativ som utgangspunkt


                int randomMethodBest = 0;
                //variabel for beste resultat fra Random metode
                int randomItterativeMethodBest = 0;
                //variabel for beste resultat fra Random Itterativ metode
                int greedyMethodBest = 0;
                //variabel for beste resultat fra Greedy metode
                int greedyItterativeGreedyBest = 0;
                //variabel for beste resultat fra Greedy itterativ metode med Greedy som utgangspunkt
                int greedyItterativeRandomBest = 0;
                //variabel for beste resultat fra Greedy itterativ metode med random som utgangspunkt
                int greedyItterativeItterativeRandomBest = 0;
                //variabel for beste resultat fra Greedy itterativ metode med random itterativ som utgangspunkt


                /*
                #### Initialisering av beste resultat #####    
                 */ 
            

                randomMethodBest = CalculateCost.calculateTotalCost(randomRoute, array1);
                randomItterativeMethodBest = CalculateCost.calculateTotalCost(randomIntterativeRoute, array1);
                greedyMethodBest = CalculateCost.calculateTotalCost(greedyRoute, array1);
                greedyItterativeGreedyBest = CalculateCost.calculateTotalCost(greedyItterativeRoute, array1);
                greedyItterativeRandomBest = CalculateCost.calculateTotalCost(GreedyItterativeRandom, array1);
                greedyItterativeItterativeRandomBest = CalculateCost.calculateTotalCost(GreedyItterativeRandomItterative, array1);


                /*
                #### Forløkke for gjennomkjøring av alle metodene. Kjøres antall ganger som bestemt i variabel itterasjoner.
                */

                for (int i = 0; i < itteration; i++)
                {
                           
                    randomRoute = RandomMethod.randMethod(array1, cities);
                    // returnerer ny rute fra Random metode med argument antall byer og generert graf.
                    randomMethod[i] = CalculateCost.calculateTotalCost(randomRoute, array1);
                    // lagrer resultatet på posisjon i i tabell. Pr nå redundent
                    randomMethodMean = randomMethodMean + CalculateCost.calculateTotalCost(randomRoute, array1);
                    // legger til kostnaden i variabel for å regne ut snitt. 
                    if (randomMethodBest > CalculateCost.calculateTotalCost(randomRoute, array1))
                    {
                        randomMethodBest = CalculateCost.calculateTotalCost(randomRoute, array1);
                    }
                    // oppdaterer beste resultat fra metoden Random hvis denne er bedre enn nåværende beste resultat

                    randomIntterativeRoute = RandomItterativeMethod.iterativeRndMethod(array1, cities);
                    // returnerer ny rute fra Random Itterativ metode med argument antall byer og generert graf.
                    randomItterativeMethod[i] = CalculateCost.calculateTotalCost(randomIntterativeRoute, array1);
                    // lagrer resultatet på posisjon i i tabell. Pr nå redundent
                    randomItterativeMethodMean = randomItterativeMethodMean + CalculateCost.calculateTotalCost(randomIntterativeRoute, array1);
                    // legger til kostnaden i variabel for å regne ut snitt. 
                    if (randomItterativeMethodBest > CalculateCost.calculateTotalCost(randomIntterativeRoute, array1))
                    {
                        randomItterativeMethodBest = CalculateCost.calculateTotalCost(randomIntterativeRoute, array1);
                    }
                    // oppdaterer beste resultat fra metoden Random Itterativ hvis denne er bedre enn nåværende beste resultat


                    greedyRoute = GreedyMethod.greedyRoute(array1);
                    // returnerer ny rute fra Greedy metode med argument generert graf.
                    greedyMethod[i] = CalculateCost.calculateTotalCost(greedyRoute, array1);
                    // lagrer resultatet på posisjon i i tabell. Pr nå redundent
                    greedyMethodMean = greedyMethodMean + CalculateCost.calculateTotalCost(greedyRoute, array1);
                    // legger til kostnaden i variabel for å regne ut snitt. 
                    if (greedyMethodBest > CalculateCost.calculateTotalCost(greedyRoute, array1))
                    {
                        greedyMethodBest = CalculateCost.calculateTotalCost(greedyRoute, array1);
                    }
                    // oppdaterer beste resultat fra metoden Greedy metode hvis denne er bedre enn nåværende beste resultat


                    greedyItterativeRoute = GreedyItterative.greedyItterative(greedyRoute, array1);
                    // returnerer ny rute fra Greedy Itterativ metode med argument rute fra Greedy metode og generert graf.
                    greedyItterativeGreedy[i] = CalculateCost.calculateTotalCost(greedyItterativeRoute, array1);
                    // lagrer resultatet på posisjon i i tabell. Pr nå redundent
                    greedyItterativeGreedyMean = greedyItterativeGreedyMean + CalculateCost.calculateTotalCost(greedyItterativeRoute, array1);
                    // legger til kostnaden i variabel for å regne ut snitt. 
                    if (greedyItterativeGreedyBest > CalculateCost.calculateTotalCost(greedyItterativeRoute, array1))
                    {
                        greedyItterativeGreedyBest = CalculateCost.calculateTotalCost(greedyItterativeRoute, array1);
                    }
                    // oppdaterer beste resultat fra metoden Greedy Itterativ metode med Greedy rute og generert graf som argument hvis denne er bedre enn nåværende beste resultat

                    GreedyItterativeRandom = GreedyItterative.greedyItterative(randomRoute, array1);
                    // returnerer ny rute fra Greedy Itterativ metode med argument rute fra Random metode og generert graf.
                    greedyItterativeRandom[i] = CalculateCost.calculateTotalCost(GreedyItterativeRandom, array1);
                    // lagrer resultatet på posisjon i i tabell. Pr nå redundent
                    greedyItterativeRandomMean = greedyItterativeRandomMean + CalculateCost.calculateTotalCost(GreedyItterativeRandom, array1);
                    // legger til kostnaden i variabel for å regne ut snitt. 
                    if (greedyItterativeRandomBest > CalculateCost.calculateTotalCost(GreedyItterativeRandom, array1))
                    {
                        greedyItterativeRandomBest = CalculateCost.calculateTotalCost(GreedyItterativeRandom, array1);
                    }
                    // oppdaterer beste resultat fra metoden Greedy Itterativ metode med Random rute og generert graf som argument hvis denne er bedre enn nåværende beste resultat


                    GreedyItterativeRandomItterative = GreedyItterative.greedyItterative(randomIntterativeRoute, array1);
                    // returnerer ny rute fra Greedy Itterativ metode med argument rute fra Random Itterativ metode og generert graf.
                    greedyItterativeRandomItterative[i] = CalculateCost.calculateTotalCost(GreedyItterativeRandomItterative, array1);
                    // lagrer resultatet på posisjon i i tabell. Pr nå redundent
                    greedyItterativeItterativeRandomMean = greedyItterativeItterativeRandomMean + CalculateCost.calculateTotalCost(GreedyItterativeRandomItterative, array1);
                    // legger til kostnaden i variabel for å regne ut snitt. 
                    if (greedyItterativeItterativeRandomBest > CalculateCost.calculateTotalCost(GreedyItterativeRandomItterative, array1))
                    {
                        greedyItterativeItterativeRandomBest = CalculateCost.calculateTotalCost(GreedyItterativeRandomItterative, array1);
                    }
                    // oppdaterer beste resultat fra metoden Greedy Itterativ metode med Random Itterativ rute og generert graf som argument hvis denne er bedre enn nåværende beste resultat

                }

                /*
                 #### Utredning av gjennomsnitt ####
                 */
                randomMethodMean = randomMethodMean/itteration;
                randomItterativeMethodMean = randomItterativeMethodMean/itteration;
                greedyMethodMean = greedyMethodMean/itteration;
                greedyItterativeGreedyMean = greedyItterativeGreedyMean/itteration;
                greedyItterativeRandomMean = greedyItterativeRandomMean/itteration;
                greedyItterativeItterativeRandomMean = greedyItterativeItterativeRandomMean/itteration;

                /*
                 #### Oppdaterer tekst for beste resultat ####
                 */

                randomResult.Text = randomMethodBest.ToString();
                itRandomResult.Text = randomItterativeMethodBest.ToString();
                greedyResult.Text = greedyMethodBest.ToString();
                GreedyItterativeResult.Text = greedyItterativeGreedyBest.ToString();
                GRandomInputResult.Text = greedyItterativeRandomBest.ToString();
                GRandomItterativeResult.Text = greedyItterativeItterativeRandomBest.ToString();

                /*
                 #### Oppdaterer tekst for gjennomsnitt
                 */
                RandomMean.Text = randomMethodMean.ToString();
                RandomItterativeMean.Text = randomItterativeMethodMean.ToString();
                GreedyMean.Text = greedyMethodMean.ToString();
                GreedyItterativeGreedyMean.Text = greedyItterativeGreedyMean.ToString();
                GreedyItterativeRandomMean.Text = greedyItterativeRandomMean.ToString();
                GreedyItterativeRandomItterativeMean.Text = greedyItterativeItterativeRandomMean.ToString();





            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
