using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestoryComponent : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.DownArrow))
        {
            Destroy(GetComponent<MeshRenderer>());
        }
    }
}
