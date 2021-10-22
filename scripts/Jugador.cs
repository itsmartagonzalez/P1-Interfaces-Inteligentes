using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jugador : MonoBehaviour
{
    int counter;
    private const int IDENTIFIER = 0;
    // Start is called before the first frame update
    void Start()
    {
        counter = 0;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("\tNombre del Objeto: " + gameObject.name
            + "\t Tag: " + gameObject.tag
            + "\t Identificador: " + IDENTIFIER
            + "\tContador: " + counter);
        counter++;
    }
}
