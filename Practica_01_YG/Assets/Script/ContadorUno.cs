using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ContadorUno : MonoBehaviour
{
    [SerializeField] Text text1;


    // Start is called before the first frame update
    void Start()
    {

        for (int n = 0; n <= 10; n++)
        {
            text1.text = "Contador: " + n; 
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
