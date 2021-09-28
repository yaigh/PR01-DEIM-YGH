using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstaculoScript : MonoBehaviour
{
    public GameObject otroObjeto;
    private PersonajeScript personajeScript;


    // Start is called before the first frame update
    void Start()
    {
        /*
        print(personajeScript.energy);
        personajeScript.energy = 50;
        print(personajeScript.energy);
        */

        personajeScript = otroObjeto.GetComponent<PersonajeScript>();

        personajeScript.energy = 150;
        personajeScript.SendMessage("UpdateText");

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
