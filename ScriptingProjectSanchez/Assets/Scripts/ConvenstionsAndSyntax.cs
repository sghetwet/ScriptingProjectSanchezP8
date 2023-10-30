using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConvenstionsAndSyntax : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //this line tells me the x position of my object (single line comments)
        
        /* hi
         * this is for multiple line comments
         * */
        Debug.Log(transform.position.x);

        if(transform.position.y <= 5f)
        {
            Debug.Log("I'm about to hit the ground!");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
