using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Tiempo_juego : MonoBehaviour
{
   // Start is called before the first frame update
    [SerializeField] Cambio_escena auxiliar; //se ocupa vincular el componente por el inspector
    int contador_segundos;
    [SerializeField] TextMeshProUGUI TextoTiempo;
    Vida auxvida;
  

    void Start()
    {
        auxvida = GameObject.Find("Player").GetComponent<Vida>();
        contador_segundos = 60;
        TextoTiempo.text = contador_segundos.ToString();
        StartCoroutine("corrutinaTiempo");
       
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator corrutinaTiempo(){

        while(contador_segundos >= 0){
            TextoTiempo.text = contador_segundos--.ToString();
            yield return new WaitForSeconds(1f);//el proceso se ejecutara cada cuarto de segundo
            float vida = auxvida.vida;
            Debug.Log(vida);
            if(contador_segundos <= 0 || vida <= 0){
                Debug.Log("El juego termino");
                auxiliar.cambioEscena(2); //escena fin
        }
        
        }
     
    }
}