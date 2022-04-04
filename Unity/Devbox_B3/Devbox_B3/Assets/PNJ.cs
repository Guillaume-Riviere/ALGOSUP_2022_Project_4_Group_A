using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PNJ : MonoBehaviour
{
    public GameObject PnjShelf;
    public GameObject Pnj;
    public GameObject ProjectRooms;
    public GameObject MeetingRooms;

    // Start is called before the first frame update
    void Start()
    {
        GameObject pnj1;
        int random;
        Transform destination;
        GameObject destination2;
        var count = ProjectRooms.transform.childCount;


        int counter = 160;
        float randomX;
        float randomZ;


        for (int i = 0; i < counter; i++)
        {
            randomX = Random.Range(-20f, 20f);
            randomZ = Random.Range(-20f, 20f);
            random = Random.Range(0, count);
            destination = ProjectRooms.transform.GetChild(random);
            destination2 = destination.gameObject;
            pnj1 = Instantiate(Pnj) as GameObject;
            pnj1.transform.name = "Pnj " + i;
            pnj1.transform.parent = PnjShelf.transform;
            pnj1.transform.localPosition = new Vector3(randomX, 0, randomZ);
            pnj1.transform.rotation = Quaternion.identity;
            pnj1.AddComponent<NavMeshAgent>();
            var script = pnj1.AddComponent<Pathfinder>();
            script.destination = destination2;
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
