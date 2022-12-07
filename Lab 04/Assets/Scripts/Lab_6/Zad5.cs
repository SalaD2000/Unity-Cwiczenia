using System.Collections;
using System.Collections.Generic;
using UnityEngine;


 
public class Zad5 : MonoBehaviour
{
    public float speed = 5f;
    public Rigidbody rigidPlayer;
    private Rigidbody rigid;
    // public GameObject movingDoor;
     
    // public float maximumOpening;
    // public float maximumClosing;
    // public float distance = 10f;
    // public float movementSpeed = 5f;
     
    // bool playerIsHere;
     
    // Start is called before the first frame update
    void Start()
    {
        rigid = transform.GetComponent<Rigidbody>();
        // playerIsHere = false;
        // maximumOpening = transform.position.x - distance;
        // maximumClosing = transform.position.x;
    }
 
    // Update is called once per frame
    void Update()
    {
          
         
    }
     
    private void OnTriggerEnter(Collider other){
        if(other.gameObject.tag == "Player")
        {
        Debug.Log("Wybija gracza");
        other.GetComponent<MoveWithCharacterController>().Skok(3);
        }
        else
        {
        other.GetComponent<Rigidbody>().AddForce(0, 10f, 0);
        }
    }

    private void OnTriggerExit(Collider other){
        if(other.gameObject.tag == "Player"){
            Debug.Log("Wybilo gracza.");
        }
    }
}