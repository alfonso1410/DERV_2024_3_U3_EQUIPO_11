using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Calc_distance : MonoBehaviour
{
    Transform ubi_obj_a_calc_dist;
    float distance;

    public float getDistance(){
        return distance;
    }
    

    private void Awake(){
        ubi_obj_a_calc_dist = GameObject.Find("Player").GetComponent<Transform>();
    }
    // Update is called once per frame
    void Update()
    {
        distance = Vector3.Distance(transform.position, ubi_obj_a_calc_dist.position);
    }
}
