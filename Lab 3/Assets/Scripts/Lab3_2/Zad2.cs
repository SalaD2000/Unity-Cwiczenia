using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zad2 : MonoBehaviour {

    public float predkosc = 5.0f;
    Rigidbody rb;

    private Vector3 startingPosition;
    private bool kierunek = false;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        startingPosition.x = transform.position.x;

    }

    //Poruszanie pojedynczym impulsem po zatrzymaniu sie obiektu

    void FixedUpdate()
    {

        // Debug.Log(transform.position.x);
        // Debug.Log(Mathf.Round(startingPosition.x + 10));

        if(kierunek==false)
        {
            transform.Translate(predkosc * Time.deltaTime, 0, 0);
                if(Mathf.Round(transform.position.x) >= Mathf.Round(startingPosition.x + 10)) 
                {
                    kierunek = true;
                    startingPosition.x = transform.position.x;
                }
        }

        if(kierunek==true)
        {
            transform.Translate(-predkosc * Time.deltaTime, 0, 0);
                if(Mathf.Round(transform.position.x) <= Mathf.Round(startingPosition.x - 10)) 
                {
                    kierunek = false;
                    startingPosition.x = transform.position.x;
                }
        }





        // if(rb.velocity.x == 0 && Mathf.Round(transform.position.x) == startingPosition.x)
        // {
        //     rb.AddForce(Vector3.right * force, ForceMode.Impulse);

        // }
        // if(rb.velocity.x == 0 && Mathf.Round(transform.position.x) != startingPosition.x)
        // {
        //     rb.AddForce(Vector3.left * force, ForceMode.Impulse);

        // }
    }





}
