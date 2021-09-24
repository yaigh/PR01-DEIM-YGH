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
        StartCoroutine("Cronometro");
    }

    IEnumerator Cronometro()
    {
        
        int x = 0;
        int y = 0;
        int z = 0;
        
        while (true)
        {
            
            print("La hora es" + z + " : " + y + " : " + x + " : ");
            
            text1.text = "La hora es " + z.ToString("D2") + " : " + y.ToString("D2") + " : " + x.ToString("D2") + " : ";
            x++;
            
            yield return new WaitForSeconds(1f);
            
            if (x==60)
            {
                x = 0;
                y++;
            }
            if (y==60)
            {
                y = 0;
                z++;
            }
            
            
        }
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
