using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Primero : MonoBehaviour
{
    private int aleatorio;


    // Start is called before the first frame update
    void Start()
    {
        while (aleatorio != 10)
        {
       
            aleatorio = Random.Range(0, 20);
            print("El numero es " + aleatorio);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
