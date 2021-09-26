using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Poo : MonoBehaviour
{
    MyClass miObjeto = new MyClass();

    // Start is called before the first frame update
    void Start()
    {
        miObjeto.atributo1 = "Hola";
        miObjeto.atributo2 = 5;
        miObjeto.MyMethod();
    }

    public class MyClass
    {
        public string atributo1;
        public int atributo2;
        private bool resultado = false;

        public void MyMethod()
        {
            print("Hola");
            resultado = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
