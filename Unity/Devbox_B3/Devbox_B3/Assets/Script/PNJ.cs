using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PNJ : MonoBehaviour
{
    [Header("Pnj Models")]
    public GameObject PnjObjectMale;
    public GameObject PnjObjectFemale;

    [Header("Storage")]
    public GameObject PnjShelf;
    public GameObject StudentsAnchor;
    public GameObject StaffAnchor;
    public GameObject TeacherAnchor;

    [Header("Default Anchors Folder")]
    public GameObject ProjectRooms;
    public GameObject OfficeRooms;
    public GameObject EnglishRooms;
    public GameObject RestingRooms;
    public GameObject Toilets;

    [Header("Default Anchors Standalone")]
    public GameObject SoftSkills;
    public GameObject Amphi;
    public GameObject Terrace;
    public GameObject Library;
    public GameObject Leave;

    [Header("User Values")]
    public float PnjSpeed;
    public int Waiter;

    // Start is called before the first frame update
    void Start()
    {


        int counter = 5;
        for (int i = 1; i <= counter; i++)
        {
            StartCoroutine(Personae_A(i, 0));
            StartCoroutine(Personae_B(i, 1));
            StartCoroutine(Personae_C(i, 2));
            StartCoroutine(Personae_D(i, 3));
            StartCoroutine(Personae_E(i, 4));
            StartCoroutine(Personae_F(i, 5));
            StartCoroutine(Personae_G(i, 6));
            StartCoroutine(Personae_H(i, 7));

            
        }
        counter = 1;
        for (int i = 1; i<= counter; i++)
        {
            StartCoroutine(Personae_Staff_A(i, 0));

            StartCoroutine(Personae_Teacher_B(i, 1));
            StartCoroutine(Personae_Teacher_C(i, 2));

        }
        counter = 2;
        for (int i = 1; i <= counter; i++)
        {
            StartCoroutine(Personae_Teacher_A(i, 0));
        }
        counter = 4;
        for (int i = 1; i <= counter; i++)
        {
            StartCoroutine(Personae_Staff_B(i, 1));
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // -------------- Premade starting For Project Rooms -----------------
    //GameObject pnjdestination = new GameObject("Personae_A_" + i);
    //pnjdestination.transform.parent = StudentsAnchor.transform.GetChild(0).transform;
    //pnjdestination.transform.position = ProjectRooms.transform.GetChild(i%count).transform.position;
    //pnjdestination.transform.rotation = Quaternion.identity;
    IEnumerator Personae_A(int i, int x)
    {
        int count = ProjectRooms.transform.childCount;
        float randomX = Random.Range(-3f, 3f);
        float randomZ = Random.Range(-3f, 3f);

        // Genereting Destination and placing it
        GameObject pnjdestination = new GameObject("Personae_A_"+i);
        pnjdestination.transform.parent = StudentsAnchor.transform.GetChild(x).transform;
        pnjdestination.transform.position = Amphi.transform.position;
        pnjdestination.transform.rotation = Quaternion.identity;

        // Generating PNJ associate the nav mesh agent to it 
        GameObject pnj = Instantiate(PnjObjectMale) as GameObject;
        pnj.transform.name = "Pnj A " + i;
        pnj.transform.parent = PnjShelf.transform;
        pnj.transform.localPosition = new Vector3(randomX, 0, randomZ);
        pnj.transform.rotation = Quaternion.identity;
        var nav = pnj.AddComponent<NavMeshAgent>();
        nav.speed = PnjSpeed;

        // Adding the script to manage the destination and setting the destination.
        var script = pnj.AddComponent<Pathfinder>();
        script.destination = pnjdestination;

        // Waiter
        yield return new WaitForSeconds(Waiter);

        // Change the coordinates of the actual destination with the new ones 
        for (int j = 0; j < StudentsAnchor.transform.GetChild(x).transform.childCount; j++)
        {
            var test = StudentsAnchor.transform.GetChild(x).transform.GetChild(j);
            test.transform.position = RestingRooms.transform.GetChild(0).transform.position;

        }
        // Waiter
        yield return new WaitForSeconds(Waiter);

        // Change the coordinates of the actual destination with the new ones 
        for (int j = 0; j < StudentsAnchor.transform.GetChild(x).transform.childCount; j++)
        {
            var test = StudentsAnchor.transform.GetChild(x).transform.GetChild(j);
            test.transform.position = ProjectRooms.transform.GetChild(j % count).transform.position;
        }
        // Waiter
        yield return new WaitForSeconds(Waiter);

        // Change the coordinates of the actual destination with the new ones 
        for (int j = 0; j < StudentsAnchor.transform.GetChild(x).transform.childCount; j++)
        {
            var test = StudentsAnchor.transform.GetChild(x).transform.GetChild(j);
            test.transform.position = Leave.transform.position;
        }
    }

    IEnumerator Personae_B(int i, int x)
    {
        int count = ProjectRooms.transform.childCount;
        float randomX = Random.Range(-3f, 3f);
        float randomZ = Random.Range(-3f, 3f);

        // Genereting Destination and placing it
        GameObject pnjdestination = new GameObject("Personae_B_" + i);
        pnjdestination.transform.parent = StudentsAnchor.transform.GetChild(x).transform;
        pnjdestination.transform.position = EnglishRooms.transform.GetChild(0).transform.position;
        pnjdestination.transform.rotation = Quaternion.identity;

        // Generating PNJ associate the nav mesh agent to it 
        GameObject pnj = Instantiate(PnjObjectFemale) as GameObject;
        pnj.transform.name = "Pnj B " + i;
        pnj.transform.parent = PnjShelf.transform;
        pnj.transform.localPosition = new Vector3(randomX, 0, randomZ);
        pnj.transform.rotation = Quaternion.identity;
        var nav = pnj.AddComponent<NavMeshAgent>();
        nav.speed = PnjSpeed;

        // Adding the script to manage the destination and setting the destination.
        var script = pnj.AddComponent<Pathfinder>();
        script.destination = pnjdestination;

        // Waiter
        yield return new WaitForSeconds(Waiter);

        // Change the coordinates of the actual destination with the new ones 
        for (int j = 0; j < StudentsAnchor.transform.GetChild(x).transform.childCount; j++)
        {
            var test = StudentsAnchor.transform.GetChild(x).transform.GetChild(j);
            test.transform.position = RestingRooms.transform.GetChild(0).transform.position;

        }
        // Waiter
        yield return new WaitForSeconds(Waiter);

        // Change the coordinates of the actual destination with the new ones 
        for (int j = 0; j < StudentsAnchor.transform.GetChild(x).transform.childCount; j++)
        {
            var test = StudentsAnchor.transform.GetChild(x).transform.GetChild(j);
            test.transform.position = EnglishRooms.transform.GetChild(0).transform.position;
        }
        // Waiter
        yield return new WaitForSeconds(Waiter);

        // Change the coordinates of the actual destination with the new ones 
        for (int j = 0; j < StudentsAnchor.transform.GetChild(x).transform.childCount; j++)
        {
            var test = StudentsAnchor.transform.GetChild(x).transform.GetChild(j);
            test.transform.position = Leave.transform.position;
        }
    }
    IEnumerator Personae_C(int i, int x)
    {
        int count = ProjectRooms.transform.childCount;
        float randomX = Random.Range(-3f, 3f);
        float randomZ = Random.Range(-3f, 3f);

        // Genereting Destination and placing it
        GameObject pnjdestination = new GameObject("Personae_C_" + i);
        pnjdestination.transform.parent = StudentsAnchor.transform.GetChild(x).transform;
        pnjdestination.transform.position = ProjectRooms.transform.GetChild(i % count).transform.position;
        pnjdestination.transform.rotation = Quaternion.identity;

        // Generating PNJ associate the nav mesh agent to it 
        GameObject pnj = Instantiate(PnjObjectMale) as GameObject;
        pnj.transform.name = "Pnj C " + i;
        pnj.transform.parent = PnjShelf.transform;
        pnj.transform.localPosition = new Vector3(randomX, 0, randomZ);
        pnj.transform.rotation = Quaternion.identity;
        var nav = pnj.AddComponent<NavMeshAgent>();
        nav.speed = PnjSpeed;

        // Adding the script to manage the destination and setting the destination.
        var script = pnj.AddComponent<Pathfinder>();
        script.destination = pnjdestination;

        // Waiter
        yield return new WaitForSeconds(Waiter);

        // Change the coordinates of the actual destination with the new ones 
        for (int j = 0; j < StudentsAnchor.transform.GetChild(0).transform.childCount; j++)
        {
            var test = StudentsAnchor.transform.GetChild(x).transform.GetChild(j);
            test.transform.position = Leave.transform.position;

        }
        // Waiter
        yield return new WaitForSeconds(Waiter);

        // Change the coordinates of the actual destination with the new ones 
        for (int j = 0; j < StudentsAnchor.transform.GetChild(x).transform.childCount; j++)
        {
            var test = StudentsAnchor.transform.GetChild(x).transform.GetChild(j);
            test.transform.position = Amphi.transform.position;
        }
        // Waiter
        yield return new WaitForSeconds(Waiter);

        // Change the coordinates of the actual destination with the new ones 
        for (int j = 0; j < StudentsAnchor.transform.GetChild(x).transform.childCount; j++)
        {
            var test = StudentsAnchor.transform.GetChild(x).transform.GetChild(j);
            test.transform.position = Leave.transform.position;
        }
    }
    IEnumerator Personae_D(int i, int x)
    {
        int count = ProjectRooms.transform.childCount;
        float randomX = Random.Range(-3f, 3f);
        float randomZ = Random.Range(-3f, 3f);

        // Genereting Destination and placing it
        GameObject pnjdestination = new GameObject("Personae_D_" + i);
        pnjdestination.transform.parent = StudentsAnchor.transform.GetChild(x).transform;
        pnjdestination.transform.position = Amphi.transform.position;
        pnjdestination.transform.rotation = Quaternion.identity;

        // Generating PNJ associate the nav mesh agent to it 
        GameObject pnj = Instantiate(PnjObjectFemale) as GameObject;
        pnj.transform.name = "Pnj D " + i;
        pnj.transform.parent = PnjShelf.transform;
        pnj.transform.localPosition = new Vector3(randomX, 0, randomZ);
        pnj.transform.rotation = Quaternion.identity;
        var nav = pnj.AddComponent<NavMeshAgent>();
        nav.speed = PnjSpeed;

        // Adding the script to manage the destination and setting the destination.
        var script = pnj.AddComponent<Pathfinder>();
        script.destination = pnjdestination;

        // Waiter
        yield return new WaitForSeconds(Waiter);

        // Change the coordinates of the actual destination with the new ones 
        for (int j = 0; j < StudentsAnchor.transform.GetChild(0).transform.childCount; j++)
        {
            var test = StudentsAnchor.transform.GetChild(x).transform.GetChild(j);
            test.transform.position = Leave.transform.position;

        }
        // Waiter
        yield return new WaitForSeconds(Waiter);

        // Change the coordinates of the actual destination with the new ones 
        for (int j = 0; j < StudentsAnchor.transform.GetChild(x).transform.childCount; j++)
        {
            var test = StudentsAnchor.transform.GetChild(x).transform.GetChild(j);
            test.transform.position = ProjectRooms.transform.GetChild(j % count).transform.position;
        }
        // Waiter
        yield return new WaitForSeconds(Waiter);

        // Change the coordinates of the actual destination with the new ones 
        for (int j = 0; j < StudentsAnchor.transform.GetChild(x).transform.childCount; j++)
        {
            var test = StudentsAnchor.transform.GetChild(x).transform.GetChild(j);
            test.transform.position = Leave.transform.position;
        }
    }
    IEnumerator Personae_E(int i, int x)
    {
        int count = ProjectRooms.transform.childCount;
        float randomX = Random.Range(-3f, 3f);
        float randomZ = Random.Range(-3f, 3f);

        // Genereting Destination and placing it
        GameObject pnjdestination = new GameObject("Personae_E_" + i);
        pnjdestination.transform.parent = StudentsAnchor.transform.GetChild(x).transform;
        pnjdestination.transform.position = ProjectRooms.transform.GetChild(i % count).transform.position;
        pnjdestination.transform.rotation = Quaternion.identity;

        // Generating PNJ associate the nav mesh agent to it 
        GameObject pnj = Instantiate(PnjObjectMale) as GameObject;
        pnj.transform.name = "Pnj E " + i;
        pnj.transform.parent = PnjShelf.transform;
        pnj.transform.localPosition = new Vector3(randomX, 0, randomZ);
        pnj.transform.rotation = Quaternion.identity;
        var nav = pnj.AddComponent<NavMeshAgent>();
        nav.speed = PnjSpeed;

        // Adding the script to manage the destination and setting the destination.
        var script = pnj.AddComponent<Pathfinder>();
        script.destination = pnjdestination;

        // Waiter
        yield return new WaitForSeconds(Waiter);

        // Change the coordinates of the actual destination with the new ones 
        for (int j = 0; j < StudentsAnchor.transform.GetChild(0).transform.childCount; j++)
        {
            var test = StudentsAnchor.transform.GetChild(x).transform.GetChild(j);
            test.transform.position = Leave.transform.position;

        }
        // Waiter
        yield return new WaitForSeconds(Waiter);

        // Change the coordinates of the actual destination with the new ones 
        for (int j = 0; j < StudentsAnchor.transform.GetChild(x).transform.childCount; j++)
        {
            var test = StudentsAnchor.transform.GetChild(x).transform.GetChild(j);
            test.transform.position = Amphi.transform.position;
        }
        // Waiter
        yield return new WaitForSeconds(Waiter);

        // Change the coordinates of the actual destination with the new ones 
        for (int j = 0; j < StudentsAnchor.transform.GetChild(x).transform.childCount; j++)
        {
            var test = StudentsAnchor.transform.GetChild(x).transform.GetChild(j);
            test.transform.position = Leave.transform.position;
        }
    }
    IEnumerator Personae_F(int i, int x)
    {
        int count = ProjectRooms.transform.childCount;
        float randomX = Random.Range(-3f, 3f);
        float randomZ = Random.Range(-3f, 3f);

        // Genereting Destination and placing it
        GameObject pnjdestination = new GameObject("Personae_F_" + i);
        pnjdestination.transform.parent = StudentsAnchor.transform.GetChild(x).transform;
        pnjdestination.transform.position = ProjectRooms.transform.GetChild(i % count).transform.position;
        pnjdestination.transform.rotation = Quaternion.identity;

        // Generating PNJ associate the nav mesh agent to it 
        GameObject pnj = Instantiate(PnjObjectMale) as GameObject;
        pnj.transform.name = "Pnj F " + i;
        pnj.transform.parent = PnjShelf.transform;
        pnj.transform.localPosition = new Vector3(randomX, 0, randomZ);
        pnj.transform.rotation = Quaternion.identity;
        var nav = pnj.AddComponent<NavMeshAgent>();
        nav.speed = PnjSpeed;

        // Adding the script to manage the destination and setting the destination.
        var script = pnj.AddComponent<Pathfinder>();
        script.destination = pnjdestination;

        // Waiter
        yield return new WaitForSeconds(Waiter);

        // Change the coordinates of the actual destination with the new ones 
        for (int j = 0; j < StudentsAnchor.transform.GetChild(0).transform.childCount; j++)
        {
            var test = StudentsAnchor.transform.GetChild(x).transform.GetChild(j);
            test.transform.position = RestingRooms.transform.GetChild(0).transform.position;

        }
        // Waiter
        yield return new WaitForSeconds(Waiter);

        // Change the coordinates of the actual destination with the new ones 
        for (int j = 0; j < StudentsAnchor.transform.GetChild(x).transform.childCount; j++)
        {
            var test = StudentsAnchor.transform.GetChild(x).transform.GetChild(j);
            test.transform.position = EnglishRooms.transform.GetChild(1).transform.position;
        }
        // Waiter
        yield return new WaitForSeconds(Waiter);

        // Change the coordinates of the actual destination with the new ones 
        for (int j = 0; j < StudentsAnchor.transform.GetChild(x).transform.childCount; j++)
        {
            var test = StudentsAnchor.transform.GetChild(x).transform.GetChild(j);
            test.transform.position = Leave.transform.position;
        }
    }
    IEnumerator Personae_G(int i, int x)
    {
        int count = ProjectRooms.transform.childCount;
        float randomX = Random.Range(-3f, 3f);
        float randomZ = Random.Range(-3f, 3f);

        // Genereting Destination and placing it
        GameObject pnjdestination = new GameObject("Personae_G_" + i);
        pnjdestination.transform.parent = StudentsAnchor.transform.GetChild(x).transform;
        pnjdestination.transform.position = EnglishRooms.transform.GetChild(1).transform.position;
        pnjdestination.transform.rotation = Quaternion.identity;

        // Generating PNJ associate the nav mesh agent to it 
        GameObject pnj = Instantiate(PnjObjectFemale) as GameObject;
        pnj.transform.name = "Pnj G " + i;
        pnj.transform.parent = PnjShelf.transform;
        pnj.transform.localPosition = new Vector3(randomX, 0, randomZ);
        pnj.transform.rotation = Quaternion.identity;
        var nav = pnj.AddComponent<NavMeshAgent>();
        nav.speed = PnjSpeed;

        // Adding the script to manage the destination and setting the destination.
        var script = pnj.AddComponent<Pathfinder>();
        script.destination = pnjdestination;

        // Waiter
        yield return new WaitForSeconds(Waiter);

        // Change the coordinates of the actual destination with the new ones 
        for (int j = 0; j < StudentsAnchor.transform.GetChild(x).transform.childCount; j++)
        {
            var test = StudentsAnchor.transform.GetChild(x).transform.GetChild(j);
            test.transform.position = RestingRooms.transform.GetChild(0).transform.position;

        }
        // Waiter
        yield return new WaitForSeconds(Waiter);

        // Change the coordinates of the actual destination with the new ones 
        for (int j = 0; j < StudentsAnchor.transform.GetChild(x).transform.childCount; j++)
        {
            var test = StudentsAnchor.transform.GetChild(x).transform.GetChild(j);
            test.transform.position = ProjectRooms.transform.GetChild(j % count).transform.position;
        }
        // Waiter
        yield return new WaitForSeconds(Waiter);

        // Change the coordinates of the actual destination with the new ones 
        for (int j = 0; j < StudentsAnchor.transform.GetChild(x).transform.childCount; j++)
        {
            var test = StudentsAnchor.transform.GetChild(x).transform.GetChild(j);
            test.transform.position = Leave.transform.position;
        }
    }
    IEnumerator Personae_H(int i, int x)
    {
        int count = ProjectRooms.transform.childCount;
        float randomX = Random.Range(-3f, 3f);
        float randomZ = Random.Range(-3f, 3f);

        // Genereting Destination and placing it
        GameObject pnjdestination = new GameObject("Personae_H_" + i);
        pnjdestination.transform.parent = StudentsAnchor.transform.GetChild(x).transform;
        pnjdestination.transform.position = Amphi.transform.position;
        pnjdestination.transform.rotation = Quaternion.identity;

        // Generating PNJ associate the nav mesh agent to it 
        GameObject pnj = Instantiate(PnjObjectMale) as GameObject;
        pnj.transform.name = "Pnj H " + i;
        pnj.transform.parent = PnjShelf.transform;
        pnj.transform.localPosition = new Vector3(randomX, 0, randomZ);
        pnj.transform.rotation = Quaternion.identity;
        var nav = pnj.AddComponent<NavMeshAgent>();
        nav.speed = PnjSpeed;

        // Adding the script to manage the destination and setting the destination.
        var script = pnj.AddComponent<Pathfinder>();
        script.destination = pnjdestination;

        // Waiter
        yield return new WaitForSeconds(Waiter);

        // Change the coordinates of the actual destination with the new ones 
        for (int j = 0; j < StudentsAnchor.transform.GetChild(x).transform.childCount; j++)
        {
            var test = StudentsAnchor.transform.GetChild(x).transform.GetChild(j);
            test.transform.position = Leave.transform.position;

        }
        // Waiter
        yield return new WaitForSeconds(Waiter);

        // Change the coordinates of the actual destination with the new ones 
        for (int j = 0; j < StudentsAnchor.transform.GetChild(x).transform.childCount; j++)
        {
            var test = StudentsAnchor.transform.GetChild(x).transform.GetChild(j);
            test.transform.position = EnglishRooms.transform.GetChild(2).transform.position;
        }
        // Waiter
        yield return new WaitForSeconds(Waiter);

        // Change the coordinates of the actual destination with the new ones 
        for (int j = 0; j < StudentsAnchor.transform.GetChild(x).transform.childCount; j++)
        {
            var test = StudentsAnchor.transform.GetChild(x).transform.GetChild(j);
            test.transform.position = Leave.transform.position;
        }
    }
    IEnumerator Personae_Staff_A(int i, int x)
    {
        int count = OfficeRooms.transform.childCount;
        float randomX = Random.Range(-3f, 3f);
        float randomZ = Random.Range(-3f, 3f);

        // Genereting Destination and placing it
        GameObject pnjdestination = new GameObject("Personae_Staff_A" + i);
        pnjdestination.transform.parent = StaffAnchor.transform.GetChild(x).transform;
        pnjdestination.transform.position = OfficeRooms.transform.GetChild(i%count).transform.position;
        pnjdestination.transform.rotation = Quaternion.identity;

        // Generating PNJ associate the nav mesh agent to it 
        GameObject pnj = Instantiate(PnjObjectMale) as GameObject;
        pnj.transform.name = "Pnj Staff A " + i;
        pnj.transform.parent = PnjShelf.transform;
        pnj.transform.localPosition = new Vector3(randomX, 0, randomZ);
        pnj.transform.rotation = Quaternion.identity;
        var nav = pnj.AddComponent<NavMeshAgent>();
        nav.speed = PnjSpeed;

        // Adding the script to manage the destination and setting the destination.
        var script = pnj.AddComponent<Pathfinder>();
        script.destination = pnjdestination;

        // Waiter
        yield return new WaitForSeconds(Waiter);

        // Change the coordinates of the actual destination with the new ones 
        for (int j = 0; j < StaffAnchor.transform.GetChild(x).transform.childCount; j++)
        {
            var test = StaffAnchor.transform.GetChild(x).transform.GetChild(j);
            test.transform.position = RestingRooms.transform.GetChild(1).transform.position;

        }
        // Waiter
        yield return new WaitForSeconds(Waiter);

        // Change the coordinates of the actual destination with the new ones 
        for (int j = 0; j < StaffAnchor.transform.GetChild(x).transform.childCount; j++)
        {
            var test = StaffAnchor.transform.GetChild(x).transform.GetChild(j);
            test.transform.position = OfficeRooms.transform.GetChild(j%count).transform.position;
        }
        // Waiter
        yield return new WaitForSeconds(Waiter);

        // Change the coordinates of the actual destination with the new ones 
        for (int j = 0; j < StaffAnchor.transform.GetChild(x).transform.childCount; j++)
        {
            var test = StaffAnchor.transform.GetChild(x).transform.GetChild(j);
            test.transform.position = Leave.transform.position;
        }
    }
    IEnumerator Personae_Staff_B(int i, int x)
    {
        int count = OfficeRooms.transform.childCount;
        float randomX = Random.Range(-3f, 3f);
        float randomZ = Random.Range(-3f, 3f);

        // Genereting Destination and placing it
        GameObject pnjdestination = new GameObject("Personae_Staff_B" + i);
        pnjdestination.transform.parent = StaffAnchor.transform.GetChild(x).transform;
        pnjdestination.transform.position = OfficeRooms.transform.GetChild(i % count).transform.position;
        pnjdestination.transform.rotation = Quaternion.identity;

        // Generating PNJ associate the nav mesh agent to it 
        GameObject pnj = Instantiate(PnjObjectFemale) as GameObject;
        pnj.transform.name = "Pnj Staff B " + i;
        pnj.transform.parent = PnjShelf.transform;
        pnj.transform.localPosition = new Vector3(randomX, 0, randomZ);
        pnj.transform.rotation = Quaternion.identity;
        var nav = pnj.AddComponent<NavMeshAgent>();
        nav.speed = PnjSpeed;

        // Adding the script to manage the destination and setting the destination.
        var script = pnj.AddComponent<Pathfinder>();
        script.destination = pnjdestination;

        // Waiter
        yield return new WaitForSeconds(Waiter);

        // Change the coordinates of the actual destination with the new ones 
        for (int j = 0; j < StaffAnchor.transform.GetChild(x).transform.childCount; j++)
        {
            var test = StaffAnchor.transform.GetChild(x).transform.GetChild(j);
            test.transform.position = RestingRooms.transform.GetChild(1).transform.position;

        }
        // Waiter
        yield return new WaitForSeconds(Waiter);

        // Change the coordinates of the actual destination with the new ones 
        for (int j = 0; j < StaffAnchor.transform.GetChild(x).transform.childCount; j++)
        {
            var test = StaffAnchor.transform.GetChild(x).transform.GetChild(j);
            test.transform.position = OfficeRooms.transform.GetChild(j%count).transform.position;
        }
        // Waiter
        yield return new WaitForSeconds(Waiter);

        // Change the coordinates of the actual destination with the new ones 
        for (int j = 0; j < StaffAnchor.transform.GetChild(x).transform.childCount; j++)
        {
            var test = StaffAnchor.transform.GetChild(x).transform.GetChild(j);
            test.transform.position = Leave.transform.position;
        }
    }
    IEnumerator Personae_Teacher_A(int i, int x)
    {
        int count = OfficeRooms.transform.childCount;
        float randomX = Random.Range(-3f, 3f);
        float randomZ = Random.Range(-3f, 3f);

        // Genereting Destination and placing it
        GameObject pnjdestination = new GameObject("Personae_Teacher_A" + i);
        pnjdestination.transform.parent = TeacherAnchor.transform.GetChild(x).transform;
        pnjdestination.transform.position = EnglishRooms.transform.GetChild((i-1) % count).transform.position;
        pnjdestination.transform.rotation = Quaternion.identity;

        // Generating PNJ associate the nav mesh agent to it 
        GameObject pnj = Instantiate(PnjObjectFemale) as GameObject;
        pnj.transform.name = "Pnj Teacher A " + i;
        pnj.transform.parent = PnjShelf.transform;
        pnj.transform.localPosition = new Vector3(randomX, 0, randomZ);
        pnj.transform.rotation = Quaternion.identity;
        var nav = pnj.AddComponent<NavMeshAgent>();
        nav.speed = PnjSpeed;

        // Adding the script to manage the destination and setting the destination.
        var script = pnj.AddComponent<Pathfinder>();
        script.destination = pnjdestination;

        // Waiter
        yield return new WaitForSeconds(Waiter);

        // Change the coordinates of the actual destination with the new ones 
        for (int j = 0; j < TeacherAnchor.transform.GetChild(x).transform.childCount; j++)
        {
            var test = TeacherAnchor.transform.GetChild(x).transform.GetChild(j);
            test.transform.position = RestingRooms.transform.GetChild(1).transform.position;

        }
        // Waiter
        yield return new WaitForSeconds(Waiter);

        // Change the coordinates of the actual destination with the new ones 
        for (int j = 0; j < TeacherAnchor.transform.GetChild(x).transform.childCount; j++)
        {
            var test = TeacherAnchor.transform.GetChild(x).transform.GetChild(j);
            test.transform.position = EnglishRooms.transform.GetChild(j%count).transform.position;
        }
        // Waiter
        yield return new WaitForSeconds(Waiter);

        // Change the coordinates of the actual destination with the new ones 
        for (int j = 0; j < TeacherAnchor.transform.GetChild(x).transform.childCount; j++)
        {
            var test = TeacherAnchor.transform.GetChild(x).transform.GetChild(j);
            test.transform.position = Leave.transform.position;
        }
    }
    IEnumerator Personae_Teacher_B(int i, int x)
    {
        int count = OfficeRooms.transform.childCount;
        float randomX = Random.Range(-3f, 3f);
        float randomZ = Random.Range(-3f, 3f);

        // Genereting Destination and placing it
        GameObject pnjdestination = new GameObject("Personae_Teacher_B" + i);
        pnjdestination.transform.parent = TeacherAnchor.transform.GetChild(x).transform;
        pnjdestination.transform.position = SoftSkills.transform.position;
        pnjdestination.transform.rotation = Quaternion.identity;

        // Generating PNJ associate the nav mesh agent to it 
        GameObject pnj = Instantiate(PnjObjectFemale) as GameObject;
        pnj.transform.name = "Pnj Teacher B " + i;
        pnj.transform.parent = PnjShelf.transform;
        pnj.transform.localPosition = new Vector3(randomX, 0, randomZ);
        pnj.transform.rotation = Quaternion.identity;
        var nav = pnj.AddComponent<NavMeshAgent>();
        nav.speed = PnjSpeed;

        // Adding the script to manage the destination and setting the destination.
        var script = pnj.AddComponent<Pathfinder>();
        script.destination = pnjdestination;

        // Waiter
        yield return new WaitForSeconds(Waiter);

        // Change the coordinates of the actual destination with the new ones 
        for (int j = 0; j < TeacherAnchor.transform.GetChild(x).transform.childCount; j++)
        {
            var test = TeacherAnchor.transform.GetChild(x).transform.GetChild(j);
            test.transform.position = RestingRooms.transform.GetChild(1).transform.position;

        }
        // Waiter
        yield return new WaitForSeconds(Waiter);

        // Change the coordinates of the actual destination with the new ones 
        for (int j = 0; j < TeacherAnchor.transform.GetChild(x).transform.childCount; j++)
        {
            var test = TeacherAnchor.transform.GetChild(x).transform.GetChild(j);
            test.transform.position = SoftSkills.transform.position;
        }
        // Waiter
        yield return new WaitForSeconds(Waiter);

        // Change the coordinates of the actual destination with the new ones 
        for (int j = 0; j < TeacherAnchor.transform.GetChild(x).transform.childCount; j++)
        {
            var test = TeacherAnchor.transform.GetChild(x).transform.GetChild(j);
            test.transform.position = Leave.transform.position;
        }
    }
    IEnumerator Personae_Teacher_C(int i, int x)
    {
        int count = OfficeRooms.transform.childCount;
        float randomX = Random.Range(-3f, 3f);
        float randomZ = Random.Range(-3f, 3f);

        // Genereting Destination and placing it
        GameObject pnjdestination = new GameObject("Personae_Teacher_C" + i);
        pnjdestination.transform.parent = TeacherAnchor.transform.GetChild(x).transform;
        pnjdestination.transform.position = Amphi.transform.position;
        pnjdestination.transform.rotation = Quaternion.identity;

        // Generating PNJ associate the nav mesh agent to it 
        GameObject pnj = Instantiate(PnjObjectFemale) as GameObject;
        pnj.transform.name = "Pnj Teacher C " + i;
        pnj.transform.parent = PnjShelf.transform;
        pnj.transform.localPosition = new Vector3(randomX, 0, randomZ);
        pnj.transform.rotation = Quaternion.identity;
        var nav = pnj.AddComponent<NavMeshAgent>();
        nav.speed = PnjSpeed;

        // Adding the script to manage the destination and setting the destination.
        var script = pnj.AddComponent<Pathfinder>();
        script.destination = pnjdestination;

        // Waiter
        yield return new WaitForSeconds(Waiter);

        // Change the coordinates of the actual destination with the new ones 
        for (int j = 0; j < TeacherAnchor.transform.GetChild(x).transform.childCount; j++)
        {
            var test = TeacherAnchor.transform.GetChild(x).transform.GetChild(j);
            test.transform.position = RestingRooms.transform.GetChild(1).transform.position;

        }
        // Waiter
        yield return new WaitForSeconds(Waiter);

        // Change the coordinates of the actual destination with the new ones 
        for (int j = 0; j < TeacherAnchor.transform.GetChild(x).transform.childCount; j++)
        {
            var test = TeacherAnchor.transform.GetChild(x).transform.GetChild(j);
            test.transform.position = Amphi.transform.position;
        }
        // Waiter
        yield return new WaitForSeconds(Waiter);

        // Change the coordinates of the actual destination with the new ones 
        for (int j = 0; j < TeacherAnchor.transform.GetChild(x).transform.childCount; j++)
        {
            var test = TeacherAnchor.transform.GetChild(x).transform.GetChild(j);
            test.transform.position = Leave.transform.position;
        }
    }
}
