using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class path : MonoBehaviour
{
    public bool move;
    public GameObject Target;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(move==true){
            GetComponent<NavMeshAgent>().SetDestination(Target.transform.position);
        }
    }
}
