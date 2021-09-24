using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Primero : MonoBehaviour
{
    
    public float numero2;
    bool alive = true;
    bool alive2 = false;
    // Start is called before the first frame update
    void Start()
    {
        if (numero2 < 20)
        {
            print(alive);
        }
        else
        {
            print(alive2);
        }
    }
    

// Update is called once per frame
void Update()
    {
        
    }
}
