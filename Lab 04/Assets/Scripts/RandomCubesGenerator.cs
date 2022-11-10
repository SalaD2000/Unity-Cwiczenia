using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class RandomCubesGenerator : MonoBehaviour
{
    List<Vector3> positions = new List<Vector3>();
    
    public float delay = 3.0f;
    
    int objectCounter = 0;

    // obiekt do generowania
    public int numberToSpawn;

    public GameObject block;

    public List<Material> colours;

    void Start()
    {
        // w momecie uruchomienia generuje this.numberToSpawn kostek w losowych miejscach
        List<int> pozycje_x = new List<int>(Enumerable.Range((int)(this.gameObject.transform.position.x - this.gameObject.transform.GetComponent<Renderer>().bounds.size.x/2), (int)(this.gameObject.transform.GetComponent<Renderer>().bounds.size.x)).OrderBy(x => Guid.NewGuid()).Take(this.numberToSpawn));
        List<int> pozycje_z = new List<int>(Enumerable.Range((int)(this.gameObject.transform.position.z - this.gameObject.transform.GetComponent<Renderer>().bounds.size.z/2), (int)(this.gameObject.transform.GetComponent<Renderer>().bounds.size.z)).OrderBy(x => Guid.NewGuid()).Take(this.numberToSpawn));
        

        for(int i=0; i<this.numberToSpawn; i++)
        {
            this.positions.Add(new Vector3(pozycje_x[i], 5, pozycje_z[i]));
        }
        foreach(Vector3 elem in positions){
            Debug.Log(elem);
        }
        // uruchamiamy coroutine
        StartCoroutine(GenerujObiekt());
    }

    void Update()
    {
        
    }

    IEnumerator GenerujObiekt()
    {

        Debug.Log("wywołano coroutine");
        foreach(Vector3 pos in positions)
        {
            GameObject klon = Instantiate(this.block, this.positions.ElementAt(this.objectCounter++), Quaternion.identity);
            var random = new System.Random();
            int index = random.Next(colours.Count);
            klon.GetComponent<MeshRenderer> ().material = colours[index];
            yield return new WaitForSeconds(this.delay);
        }
        // zatrzymujemy coroutine
        StopCoroutine(GenerujObiekt());
    }
}