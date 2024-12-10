using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class p6_Gestionproyectiles : MonoBehaviour
{
    [SerializeField] GameObject proyectil; //prefab
    [SerializeField] Transform pos_inicio_proyectiles; //spawn

    [SerializeField] List<GameObject> proyectiles;

    int proyectil_despachado;

    // Start is called before the first frame update
    void Start()
    {
        int n = 10; //10 proyectiles
        proyectiles = new List<GameObject>();
        GameObject tmp;
        for (int i = 0; i<n; i++){
            tmp = Instantiate<GameObject>(proyectil, pos_inicio_proyectiles.position, pos_inicio_proyectiles.rotation);
            tmp.name = "Proyectil"+1;
            tmp.tag = "bala";
            tmp.SetActive(false);
            proyectiles.Add(tmp);
        }
        proyectil_despachado = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.F)){
            proyectiles[proyectil_despachado].transform.position = pos_inicio_proyectiles.position;
            proyectiles[proyectil_despachado].transform.rotation = pos_inicio_proyectiles.rotation;
            proyectiles[proyectil_despachado].GetComponent<Rigidbody>().velocity = new Vector3(0,0,0);
            proyectiles[proyectil_despachado].SetActive(true);
            proyectil_despachado++;
            proyectil_despachado %= proyectiles.Count;
        }
        
    }
}
