using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGaffneyCPT206Lab3CL
{
    public class State
    {
        // fields + getters/setters
        string stateName { get; set; }
        int statePopulation { get; set; }
        string stateFlag { get; set; }
        string stateFlower { get; set; }
        string stateBird { get; set; }
        string stateColors { get; set; }
        string stateLargestCity1 { get; set; }
        string stateLargestCity2 { get; set; }
        string stateLargestCity3 { get; set; }
        string stateCapitol {  get; set; }
        int stateMedianIncome { get; set; }
        int stateJobPerctange { get; set; }



        public State() // default constructor
        {
            stateName = string.Empty;
            statePopulation = 0;
            stateFlag = string.Empty;
            stateFlower = string.Empty;
            stateBird = string.Empty;
            stateColors = string.Empty;
            stateLargestCity1 = string.Empty;
            stateLargestCity2 = string.Empty;
            stateLargestCity3 = string.Empty;
            stateCapitol = string.Empty;
            stateMedianIncome = 0;
            stateJobPerctange = 0;

        }

        public State(string name, int population, string flag,          // Constructor with initial parameters
            string flower, string bird, string colors, string largest1,
            string largest2, string largest3, string capitol,
            int medianIncome, int jobPercentage)
        {
            stateName = name;
            statePopulation = population;
            stateFlag = flag;
            stateFlower = flower;
            stateBird = bird;
            stateColors = colors;
            stateLargestCity1 = largest1;
            stateLargestCity2 = largest2;
            stateLargestCity3 = largest3;
            stateCapitol = capitol;
            stateMedianIncome = medianIncome;
            stateJobPerctange = jobPercentage;
        }


    }
}
