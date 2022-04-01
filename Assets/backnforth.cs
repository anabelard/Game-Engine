using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backnforth : MonoBehaviour
{
    public float speed = 10.0f;
    public float strength = 5f;
    private float randomOffset;


    void Start (){
        randomOffset = Random.Range(0f,1f);
    }

    void Update() {
        Vector3 pos = transform.position;
        pos.z = Mathf.Sin(Time.time*speed*randomOffset)*strength;
        transform.position=pos;
    }
}