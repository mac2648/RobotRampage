using System.Collections.Generic;
using UnityEngine;

public class Demo : MonoBehaviour
{
   void Start()
    {
        Dictionary<string, int> cityPopulation = new Dictionary<string, int>();
        cityPopulation.Add("Tokyo", 38000000);
        cityPopulation.Add("Dehli", 25700000);
        cityPopulation.Add("Shanghai", 23700000);
        cityPopulation.Add("sao paulo", 21100000);
        cityPopulation.Add("mexico city", 21000000);

        Debug.Log("city population ");

        foreach(KeyValuePair<string, int> city in cityPopulation)
        {
            Debug.Log("City: " + city.Key + " Population " + city.Value);
        }
        Debug.Log("Total amount of cities " + cityPopulation.Count);
    }
}
