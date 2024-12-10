using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P6_Mov_Enemy : MonoBehaviour
{
    Transform ubi_personaje;
    Calc_distance auxComponenteDistance;

    private void Awake(){
        ubi_personaje = GameObject.Find("Player").GetComponent<Transform>();
    }

    // Start is called before the first frame update
    void Start()
    {
     auxComponenteDistance = GetComponent<Calc_distance>();   
    }

    // Update is called once per frame
    void Update()
    {
        float distanciaAlEnemigo = auxComponenteDistance.getDistance();
        if (distanciaAlEnemigo < 50.5f){
            float velocidad = 9.0f * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position,ubi_personaje.position, velocidad);
        }
    }
}

