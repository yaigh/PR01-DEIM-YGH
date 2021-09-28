using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PersonajeScript : MonoBehaviour
{

    [SerializeField] Text EneryText;
    public float energy;


    // Start is called before the first frame update
    void Start()
    {
       // EneryText.text = "ENERGIA: " + energy + "%";

    }

    public void UpdateText()
    {
        EneryText.text = "ENERGIA: " + energy + "%";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
