using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pathfinder : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject destination;
    UnityEngine.AI.NavMeshAgent npc;
    void Start()
    {
        npc = GetComponent<UnityEngine.AI.NavMeshAgent>();

    }

    // Update is called once per frame
    void Update()
    {
        npc.SetDestination(destination.transform.position);


    }
}
