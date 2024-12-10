using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Vida : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI txt_vida;
    public int vida = 0;
    
    public void OnCollisionEnter(Collision other) {
         GameObject obj = other.gameObject;
        if(obj.CompareTag("Enemy")){
            vida -= 10;
            
        }
    
    txt_vida.text = vida.ToString();
    }

    // Start is called before the first frame update
    void Start()
    {
        vida = 100;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
