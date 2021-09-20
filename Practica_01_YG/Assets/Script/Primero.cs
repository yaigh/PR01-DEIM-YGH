using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Primero : MonoBehaviour
{
    





    // Start is called before the first frame update
    void Start()
    {
        Saludar("Yaiza" , 20);
        Saludar("Adrian", 21);
        Saludar("Patri", 22);

    }
    void Saludar(string nombre, int edad)
    {
        print("Hola " + nombre + " Edad " + edad);
    }
    

// Update is called once per frame
void Update()
    {
        
    }
}
