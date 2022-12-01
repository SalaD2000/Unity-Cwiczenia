using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class Zad2 : MonoBehaviour
{
     
    public GameObject movingDoor;
     
    public float maximumOpening;
    public float maximumClosing;
    public float distance = 10f;
    public float movementSpeed = 5f;
     
    bool playerIsHere;
     
    // Start is called before the first frame update
    void Start()
    {
        playerIsHere = false;
        maximumOpening = transform.position.x - distance;
        maximumClosing = transform.position.x;
    }
 
    // Update is called once per frame
    void Update()
    {
        if(playerIsHere){
            if(movingDoor.transform.position.x > maximumOpening){
                movingDoor.transform.Translate(-movementSpeed * Time.deltaTime, 0f, 0f);
            }
        }else{
            if(movingDoor.transform.position.x < maximumClosing){
                movingDoor.transform.Translate(movementSpeed * Time.deltaTime, 0f, 0f);
            }
        }
         
         
    }
     
    private void OnTriggerEnter(Collider other){
        if(other.gameObject.tag == "Player"){
            playerIsHere = true;
            Debug.Log("Gracz przed drzwiami");
        }
    }
     
    private void OnTriggerExit(Collider other){
        if(other.gameObject.tag == "Player"){
            playerIsHere = false;
            Debug.Log("Brak gracza.");
        }
    }
}