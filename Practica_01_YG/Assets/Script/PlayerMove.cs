using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    private Vector3 cubePosition = new Vector3(0f, 0f, 0f);

    // Start is called before the first frame update
    void Start()
    {
        transform.position = cubePosition;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
