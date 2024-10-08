using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int x = 0;
        float y = 5;
        float floaty = 5.5f;
        string textOutput = "Hello World";
        Debug.Log(textOutput);

        y = x + 5;
        Debug.Log(y);

        //Debug.Log(textOutput + y);
        float output = floaty + y;
        Debug.Log(output);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
