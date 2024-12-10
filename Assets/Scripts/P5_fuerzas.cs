using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P5_fuerzas : MonoBehaviour
{

    Rigidbody rb;
    [SerializeField] float velocidad;
    float tiempo_en_pantalla;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.AddForce(transform.right * velocidad, ForceMode.Impulse);
        tiempo_en_pantalla = 0;
        //rb.AddForce(transform.right * velocidad, ForceMode.VelocityChange);
        //rb.AddForce(transform.right * velocidad, ForceMode.Acceleration);
       // rb.AddForce(transform.right * velocidad, ForceMode.Force);
    }

    private void Update(){
        tiempo_en_pantalla += Time.deltaTime;
        if(tiempo_en_pantalla > 1.5f){
            tiempo_en_pantalla = 0;
            gameObject.SetActive(false);
        }
    }
    void FixedUpdate() {
    rb.AddForce(velocidad * Time.fixedDeltaTime * transform.forward, ForceMode.Impulse);   
    

    }
}
