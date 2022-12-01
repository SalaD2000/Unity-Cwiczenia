using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zad3 : MonoBehaviour
{
    [SerializeField] GameObject[] waypoints;
    int currentWaypointIndex = 0;

    [SerializeField] float speed = 1f;
    bool DoPrzodu = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(transform.position, waypoints[currentWaypointIndex].transform.position) < .1f)
        {


            if(DoPrzodu)
            {
                if(currentWaypointIndex + 1 < waypoints.Length)
                {
                    currentWaypointIndex++;
                }
                else
                {
                    DoPrzodu = false;
                }
            }
            else
            {
                if(currentWaypointIndex > 0)
                {
                    currentWaypointIndex--;
                }
                else
                {
                    DoPrzodu = true;
                }
            }
        }

    transform.position = Vector3.MoveTowards(transform.position, waypoints[currentWaypointIndex].transform.position, speed * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other){
        if(other.gameObject.tag == "Player"){
            other.gameObject.transform.parent = transform;
            Debug.Log("Na platformie");
        }
    }
     
    private void OnTriggerExit(Collider other){
        if(other.gameObject.tag == "Player"){
            other.gameObject.transform.parent = null;
            Debug.Log("Już nie na platformie.");
        }
    }
}
