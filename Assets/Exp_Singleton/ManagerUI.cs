using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class ManagerUI : MonoBehaviour
{

    TextMeshProUGUI [] contador;

    float con_segundos;
    float tiempo_transcurrido;

    private void Awake() {
        contador = GetComponentsInChildren<TextMeshProUGUI>();

    }
    // Start is called before the first frame update
    void Start()
    {
        con_segundos = 0;
        tiempo_transcurrido = 0;
    }

    // Update is called once per frame
    void Update()
    {
        tiempo_transcurrido += Time.deltaTime;
        if(tiempo_transcurrido > 1.0f){
            con_segundos++;
            tiempo_transcurrido = 0;
            contador[0].text = con_segundos.ToString();
        }
    }
}
