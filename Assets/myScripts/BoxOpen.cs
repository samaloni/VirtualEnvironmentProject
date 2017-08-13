using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxOpen : MonoBehaviour {

    public GameObject treasurebox;
   // public Animator anim;

     void Start()
    {
       // anim = GetComponent<Animator>();
        
    }
    /*  
      void OnCollisionEnter(Collision collision)
      {
          Debug.Log(gameObject.name + " Collided with " + collision.collider.name);

          if(collision.collider.name == "FPSController" || collision.collider.name == "FirstPersonCharacter")
          {
              Debug.Log("entered the box");
              gameObject.GetComponent<Animation>().Play();

          }


      }*/

    private void OnTriggerEnter(Collider other)
      {
          Debug.Log(gameObject.name + " Collided with " + other.name);

          if (other.name == "FPSController" || other.name == "FirstPersonCharacter")
          {
              Debug.Log("entered the box");
            treasurebox.GetComponent<Animation>().Play();

              //anim.Play("treasure_box");
              //anim.SetBool("treasurecollider", true);


          }
      }



}
