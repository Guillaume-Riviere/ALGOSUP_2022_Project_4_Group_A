using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PNJ : MonoBehaviour
{
    public GameObject PnjShelf;
    public GameObject PnjObject;
    public GameObject ProjectRooms;
    public GameObject MeetingRooms;
    public GameObject amphi;
    public GameObject leave;




    private GameObject pnj;
    private int random;
    private Transform destination_transform;
    private GameObject destination;
    
    private float randomX;
    private float randomZ;

    // Start is called before the first frame update
    void Start()
    {
        var count = ProjectRooms.transform.childCount;
        int counter = 6;

        for (int i = 0; i < counter; i++)
        {
            StartCoroutine(Personae_A(count, i, amphi, leave));
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator Personae_A(int count, int i, GameObject amphi, GameObject leave)
    {
        randomX = Random.Range(-20f, 20f);
        randomZ = Random.Range(-20f, 20f);


        random = Random.Range(0, count);
        destination_transform = ProjectRooms.transform.GetChild(random);


        destination = destination_transform.gameObject;
        pnj = Instantiate(PnjObject) as GameObject;
        pnj.transform.name = "Pnj " + i;
        pnj.transform.parent = PnjShelf.transform;
        pnj.transform.localPosition = new Vector3(randomX, 0, randomZ);
        pnj.transform.rotation = Quaternion.identity;
        pnj.AddComponent<NavMeshAgent>();
        var script = pnj.AddComponent<Pathfinder>();
        script.destination = destination;



        yield return new WaitForSeconds(120);

        destination.transform.SetParent(amphi.transform);
        destination.transform.SetPositionAndRotation(new Vector3(0, 0, 0), Quaternion.identity);


        yield return new WaitForSeconds(120);

        destination.transform.SetParent(leave.transform);
        destination.transform.SetPositionAndRotation(new Vector3(0, 0, 0), Quaternion.identity);

    }
}
