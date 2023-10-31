using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.SceneManagement;
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

        Console.WriteLine("city population");

        foreach(KeyValuePair<string, int> city in cityPopulation)
        {
            Console.WriteLine("City: " + city.Key + "Population" + city.Value);

        }

        Console.WriteLine("Total amount of cities" + cityPopulation.Count);
    }
}
