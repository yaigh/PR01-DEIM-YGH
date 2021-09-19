using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Primero : MonoBehaviour
{

    public int var1 = 6;
    public int var2 = 3;
    public int var3;

    // Start is called before the first frame update
    void Start()
    {
        // Variables de ambito publico

        int var3 = var1 * var2;
        print(var3);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
