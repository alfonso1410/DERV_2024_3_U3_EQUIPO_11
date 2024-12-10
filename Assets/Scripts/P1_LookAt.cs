using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P1_LookAt : MonoBehaviour
{
    Transform ubi_ob_a_mirar;
    P2_CalcularDistancia auxComponenteDistance;


    private void Awake(){
        ubi_ob_a_mirar = GameObject.Find("Jugador").GetComponent<Transform>();
    }
    // Start is called before the first frame update
    void Start()
    {
        auxComponenteDistance = GetComponent<P2_CalcularDistancia>();
    }

    // Update is called once per frame
    void Update()
    {
        float distanciaAlEnemigo = auxComponenteDistance.getDistance();
        if (distanciaAlEnemigo < 6.5f){
            float valY = ubi_ob_a_mirar.position.y;
            if (valY>3.0f){
                transform.LookAt(new Vector3(
                    ubi_ob_a_mirar.position.x, 
                    3.0f, 
                    ubi_ob_a_mirar.position.z));
            }
            else{
                transform.LookAt(ubi_ob_a_mirar.position);
            }
        }
        
    }
}
