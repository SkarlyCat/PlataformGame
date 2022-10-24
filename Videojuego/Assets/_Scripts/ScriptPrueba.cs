using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class ScriptPrueba : MonoBehaviour
{
    string Nombre = "Llave";

    public int giro;

    public bool girar; 

    void Start()

    {
        name = Nombre;
    }

    // Update is called once per frame
    void Update()
    {
        if(girar == true)
        transform.Rotate(0, giro, 0);
        

    }   
}
