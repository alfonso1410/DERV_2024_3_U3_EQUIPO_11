using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class objeto_Caido : MonoBehaviour
{
    // Start is called before the first frame update
    public int colorrandom;
    private bool cb_r = false;
    private bool cb_v = false;
    private bool cb_a = false;
    private bool cubo_seleccionado = false;

    [SerializeField] Transform spawn;
    [SerializeField] Transform spawn2;
    [SerializeField] Transform spawn3;
    [SerializeField] TextMeshProUGUI texto;
    GameObject cubo1, cubo2, cubo3;
    private void Awake()
    {
        cubo1 = GameObject.Find("rojo");
        cubo2 = GameObject.Find("verde");
        cubo3 = GameObject.Find("azul");
    }
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (!cubo_seleccionado)
        {
            randomNum();
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("TakenObject"))
        {
            bool correcto = false; // Variable para comprobar si el cubo es correcto
            if (other.gameObject.name == "rojo" && colorrandom == 0 && cb_r == true)
            {
                cubo1.transform.position = spawn.transform.position;
                cubo1.SetActive(false);
                correcto = true; 
            }
            else if (other.gameObject.name == "verde" && colorrandom == 1 && cb_v == true)
            {
                cubo2.transform.position = spawn.transform.position;
                cubo2.SetActive(false);
                correcto = true; 
            }
            else if (other.gameObject.name == "azul" && colorrandom == 2 && cb_a == true)
            {
                cubo3.transform.position = spawn.transform.position;
                cubo3.SetActive(false);
                correcto = true; 
            }
            if (!correcto)
            {
                texto.text = "Cubo incorrecto intenta de nuevo";

               
                if (other.gameObject.name == "rojo")
                {
                    cubo1.transform.position = spawn.transform.position;
                    cb_r = false;
                }
                else if (other.gameObject.name == "verde")
                {
                    cubo2.transform.position = spawn2.transform.position;
                    cb_v = false;
                }
                else if (other.gameObject.name == "azul")
                {
                    cubo3.transform.position = spawn3.transform.position;
                    cb_a = false;
                }
               
                cubo_seleccionado = true; 
            }
            else
            {
                cubo_seleccionado = false;      
            }
        }
    }



    void randomNum()
    {
        colorrandom = Random.Range(0, 3);
        while (colorrandom == 0 && cb_r || colorrandom == 1 && cb_v || colorrandom == 2 && cb_a)
        {
            colorrandom = Random.Range(0, 3);
            if (colorrandom == 0 && cb_r == false)
            {
                texto.text = "Lleva el cubo rojo";
                cb_r = true;

            }
            else if (colorrandom == 1 && cb_v == false)
            {
                texto.text = "Lleva el cubo verde";
                cb_v = true;

            }
            else if (colorrandom == 2 && cb_a == false)
            {
                texto.text = "Lleva el cubo azul";
                cb_a = true;
            }

            if (cb_r && cb_v && cb_a && !cubo_seleccionado)
            {
               // texto.text = "Juego terminado";
                break;
                
            }
        }
        cubo_seleccionado = true;
        if (colorrandom == 0 && cb_r == false)
        {
            texto.text = "Lleva el cubo rojo";
            cb_r = true;

        }
        else if (colorrandom == 1 && cb_v == false)
        {
            texto.text = "Lleva el cubo verde";
            cb_v = true;

        }
        else if (colorrandom == 2 && cb_a == false)
        {
            texto.text = "Lleva el cubo azul";
            cb_a = true;

        }
    }

}