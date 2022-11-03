using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zad3: MonoBehaviour {

    public float prendkosc = 5.0f;
    Rigidbody rb;

    private Vector3 Position;

    public float Predkosc;

    public float rotacja = 0.0f;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Position.x = transform.position.x;
        Position.y = transform.position.y;
        Position.z = transform.position.z;
    }


    void FixedUpdate()
    { 
           transform.Translate(0, 0, Predkosc * Time.deltaTime);
              if((transform.position.x) >= (Position.x + 10) || (transform.position.z) >= (Position.z + 10) || (transform.position.x) <= (Position.x - 10) || (transform.position.z) <= (Position.z - 10)) 
                {
                    transform.Rotate(0, 90, 0);
                    Position.x = Mathf.Round(transform.position.x);
                    Position.z = Mathf.Round(transform.position.z);
                    transform.position = new Vector3 (Position.x, Position.y, Position.z);
                }
    }
}