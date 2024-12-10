using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Manager_UI : MonoBehaviour
{


    private Manager_UI instance;
    [SerializeField] GameObject usuario;
    TextMeshProUGUI nombre_usuario;
    string usu;
    int id_active_scene;
    private void Awake(){
        if(instance != null && instance != this){
            Destroy(gameObject);
        }
        else{
            instance = this;
            DontDestroyOnLoad(gameObject);
        }

    }
    // Start is called before the first frame update
    void Start()
    {
       
        
    }

    // Update is called once per frame
    void Update()
    {
        id_active_scene = SceneManager.GetActiveScene().buildIndex;
       

        if(id_active_scene!= 0){ //para todas las demas escenas solo obtengo el nombre de usuario que fue ingresado
           usu = PlayerPrefs.GetString("usuario", "");
           Debug.Log("Usuario:" + usu);      
        }
        
    }

    public void cambiarEscena(int idx_new){
        if (id_active_scene == 0){ 
            nombre_usuario = usuario.GetComponent<TextMeshProUGUI>();
            usu = nombre_usuario.text;//almacena el string que ingreso el usuario
            PlayerPrefs.SetString("usuario",  usu); //almacena en memoria el nombre del usuario
        }
        SceneManager.LoadScene(idx_new);
    }
}
