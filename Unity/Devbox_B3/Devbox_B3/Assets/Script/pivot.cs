using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using OVR;

public class pivot : MonoBehaviour
{
    public float speed;
    public Rigidbody player;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        var joystickAxis = OVRInput.Get(OVRInput.RawAxis2D.RThumbstick, OVRInput.Controller.RTouch);
    
        player.transform.Rotate(new Vector3(player.transform.rotation.x , player.transform.rotation.y * (-joystickAxis.x), player.transform.rotation.z));

        // player.position = new Vector3(player.position.x, fixedY, player.position.z);
    }
}