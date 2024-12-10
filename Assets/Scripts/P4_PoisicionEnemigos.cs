using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P4_PoisicionEnemigos : MonoBehaviour
{
    [SerializeField] Transform ubi_spawn;
    GameObject enemigo;
    

    private void Awake(){
        enemigo = GameObject.Find("Enemigo");
    }
    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.CompareTag("Player")){
            enemigo.transform.position = ubi_spawn.position;
        }
    }
}
