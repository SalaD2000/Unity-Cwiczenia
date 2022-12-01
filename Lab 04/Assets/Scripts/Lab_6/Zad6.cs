using System.Collections;
using System.Collections.Generic;
using UnityEngine;


 
public class Zad6 : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {

    }
 
    // Update is called once per frame
    void Update()
    {
          
         
    }
     
    private void OnTriggerEnter(Collider other){
        if(other.gameObject.tag == "Player")
        {
        Debug.Log("Wybija gracza");
        }
    }

    private void OnTriggerExit(Collider other){
        if(other.gameObject.tag == "Player"){
            Debug.Log("Wybilo gracza.");
        }
    }
}