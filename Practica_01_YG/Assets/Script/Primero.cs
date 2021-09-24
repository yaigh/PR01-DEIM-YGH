using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Primero : MonoBehaviour
{
    private Vector3 Initpos;
    [SerializeField] Vector3 Destpos;
    private Vector3 Finalpos;
    public float speed = 4f;


    // Start is called before the first frame update
    void Start()
    {
        
    }
    

// Update is called once per frame
void Update()
    {
        Initpos = transform.position;
        Finalpos = Initpos + Destpos * Time.deltaTime * speed;
        print(Initpos);

    }
}
