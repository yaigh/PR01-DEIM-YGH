using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Primero : MonoBehaviour
{

    int men1 = 5;
    int men2 = 5;
    int men3;

    // Start is called before the first frame update
    void Start()
    {
        // Variable int + if

        int men3 = men1 + men2;
        if (men3 < 10)
        {
            print("Estas muerto");
        }
        else if (men3 > 10)
        {
            print("Estas vivo");
        }
        else
        {
            print("A saber como estas");
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
