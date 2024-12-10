using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class P5_Raycast : MonoBehaviour
{

    [SerializeField] Transform Jugador;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        

        Vector3 direccion = Jugador.position - transform.position;
        direccion = direccion.normalized;
        RaycastHit hit; //hit almacena informacion de la colision
        if(Physics.Raycast(transform.position, direccion, out hit, 10f)){
            Debug.Log("Colisiona con un objeto");
            Debug.DrawRay(transform.position, direccion* hit.distance, Color.green);
        }else{
            Debug.Log("No colisiona");
            Debug.DrawRay(transform.position, direccion * hit.distance,  Color.red);
        }
        

    }
}
