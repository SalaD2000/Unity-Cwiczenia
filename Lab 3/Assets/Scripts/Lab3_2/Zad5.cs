using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Zad5 : MonoBehaviour
{

    public GameObject myPrefab;
    //public List<Vector2> Kordynaty = new List<Vector2>();
    // Start is called before the first frame update
    void Start()
    {   
        List<Vector2> Kordynaty = new List<Vector2>();

        for(int a = 0; a<10; a++)
        {
            int O = -4;
            int P = 4;

            int b = Random.Range(O, P);
            int c = Random.Range(O, P);

            Vector2 d = new Vector2(b, c);

            if(Kordynaty.Count < 10)
            {
                if(!Kordynaty.Contains(d))
                {
                    Kordynaty.Add(d);
                    Instantiate(myPrefab, new Vector3(b, 0.5f, c), Quaternion.identity);
                }
                else{
                    a--;
                } 
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
