using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ContadorUno : MonoBehaviour
{
    [SerializeField] Text text1;
    [SerializeField] float speed; 

    // Start is called before the first frame update
    void Start()
    {

        StartCoroutine("Cronometro");

    }


    IEnumerator Cronometro()
    {
        for(int n = 0; n <= 100; n++)
        {
            text1.text = "Contador: " + n;
            yield return new WaitForSeconds(1f);

        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
