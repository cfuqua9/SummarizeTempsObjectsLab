using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace SummarizeTempsObjects
{
    public class TempCalculationEngine
    {
        List<int> _temperatures;
        public TempCalculationEngine(List<int> temperatures)
        {
            _temperatures = temperatures;
        }

        public int AverageTemperature()
        {
            // add logic to calculate the average
            int sumoftemps = 0;

            // loop through all of the list temps
            foreach(int temp in _temperatures)
            {
                // add the list item to my summing variable
                sumoftemps += temp;
            }
            return sumoftemps/ _temperatures.Count; // <-- Replace this with the actual average
        }

        public int TempsAboveThreshold(int threshold)
        {
            // add logic to calculate temps above the threshold

            int temperatureCount = 0;

            foreach (int temp in _temperatures)
            {

                if (temp>threshold)
                {
                    temperatureCount += 1;

                }

            }
                
            return 0; // <-- Replace this with the number
        }

        public int TempsBelowThreshold(int threshold)
        {
            // add logic to calculate and return temps below the threshold

            int temperatureCount = 0;
            // loop though all of the list items
            foreach (int temp in _temperatures)
            {
                // if the temp < threshold
                if (temp < threshold)
                {
                    // increment my counter
                    temperatureCount += 1;
                }

            }

            return temperatureCount; // <-- Replace this with the number
        }

        public int TempsAtThreshold(int threshold)
        {
            // add logic to calculate and return temps at the threshold
            return 0; // <-- Replace this with the number
        }

        public int NumberOfTemperatures()
        {
            // add logic to return the number of temparature readings
            return _temperatures.Count; // <-- Replace this with the number
        }
    }
}
