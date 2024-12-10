using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P6_LookAt : MonoBehaviour
{
   Transform ubi_ob_a_mirar;
    Calc_distance auxComponenteDistance;


    private void Awake(){
        ubi_ob_a_mirar = GameObject.Find("Player").GetComponent<Transform>();
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
