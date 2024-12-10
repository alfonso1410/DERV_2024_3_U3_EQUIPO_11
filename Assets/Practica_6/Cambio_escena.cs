using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Cambio_escena : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        int escenaActiva = SceneManager.GetActiveScene().buildIndex;
        if(escenaActiva == 0){
            if(Input.GetKeyDown(KeyCode.Space)){
                cambioEscena(1); //la escena principal
         }
        }
        else if (escenaActiva == 2){
            if(Input.GetKeyDown(KeyCode.R)){
                cambioEscena(0); //la escena principal
         }
            }
        
      
    }
    
    public void cambioEscena(int index){
        SceneManager.LoadScene(index);
    }

}
