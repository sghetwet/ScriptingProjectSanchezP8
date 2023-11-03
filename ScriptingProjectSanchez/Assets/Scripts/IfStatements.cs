using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfStatements : MonoBehaviour
{
    float coffeeTemperature = 85.0f;
    float hotlimitTemperature = 70.0f;
    float coldlimitTemperature = 40.0f;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            TemperatureTest();

            coffeeTemperature -= Time.deltaTime * 5f;
    }

    // Update is called once per frame
    void TemperatureTest()
    {
        //If the coffee's temperatue is greater than the hottest
        if (coffeeTemperature > hotlimitTemperature)
        {
            //...do this
            print("Coffee is too hot.");
        }
        //if it isnt, but the coffee temperature is less than the lowest temp
        else if (coffeeTemperature < coldlimitTemperature)
         
        {
            //... do this
            print("Coffee is to cold.");
        }
     //...do this.
     else
        {
            //...do this.
            print("Coffee is just right.");
        }
    }
}
