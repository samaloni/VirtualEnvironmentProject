using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerOnBoat : MonoBehaviour {

    public GameObject myBoat;
    public GameObject fps;

     void Start()
    {
        fps = GameObject.Find("FPSController");
    }

     void OnCollisionEnter(Collision collision)
    {
        Debug.Log(gameObject.name + "Collided  wiiith" + collision.collider.name);

        if(collision.collider.name == "FPSController" || collision.collider.name== "boat")
        {
            Debug.Log(gameObject.name + "Collided  wiiith" + collision.collider.name);
            fps.GetComponent<Rigidbody>().isKinematic = true;
        }
    }
}
