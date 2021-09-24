using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    private Vector3 cubePosition = new Vector3(0f, 0f, 0f);
    public float speed = 0;


    // Start is called before the first frame update
    void Start()
    {
        transform.position = cubePosition;

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 destPos = new Vector3(-1f, 1f, 1f);
        cubePosition = cubePosition + destPos * Time.deltaTime * speed;
        transform.position = cubePosition;

    }
}
