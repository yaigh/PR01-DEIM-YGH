using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Primero : MonoBehaviour
{
    float numero1 = 0f;


    // Start is called before the first frame update
    void Start()
    {
        

    }
    

// Update is called once per frame
void Update()
    {
        while (numero1 < 20)
        {
            numero1++;
            print(numero1);

        }

    }
}
