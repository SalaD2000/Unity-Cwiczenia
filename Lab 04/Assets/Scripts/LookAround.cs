using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAround : MonoBehaviour
{
    // ruch wokół osi Y będzie wykonywany na obiekcie gracza, więc
    // potrzebna nam referencja do niego (konkretnie jego komponentu Transform)
    public Transform player;
    public float minAngle = -90.0f;
    public float maxAngle = 90.0f;

    Vector3 aba;
    float Ycounter;
    float Xcounter;

    public float sensitivity = 200f;

    void Start()
    {
        // zablokowanie kursora na środku ekranu, oraz ukrycie kursora
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {   

        // pobieramy wartości dla obu osi ruchu myszy
        float mouseXMove = Input.GetAxis("Mouse X") * sensitivity * Time.deltaTime;
        float mouseYMove = Input.GetAxis("Mouse Y") * sensitivity * Time.deltaTime;

        

        Ycounter = Mathf.Clamp(Ycounter, minAngle, maxAngle);
        Ycounter += mouseYMove;
        Xcounter += mouseXMove;
        // Debug.Log("Y=" + Ycounter + "X=" + Xcounter);

        aba = new Vector3(0,1,0);

        // wykonujemy rotację wokół osi Y
        player.Rotate(aba * mouseXMove);
        // player.localEulerAngles = new Vector3(-Ycounter, mouseXMove, 0);

        // a dla osi X obracamy kamerę dla lokalnych koordynatów
        // -mouseYMove aby uniknąć ofektu mouse inverse
        transform.localRotation = Quaternion.Euler(-Ycounter, 0f, 0f);

    }
}