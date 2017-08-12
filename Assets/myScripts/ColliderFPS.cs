
using UnityEngine;
using UnityEngine.UI;


public class ColliderFPS : MonoBehaviour {

    public GameObject keyScoreUI;
    public static int key = 0;
    public AudioSource audiosrc;
    public AudioClip beepClip;


     void Start()
    {
        keyScoreUI = GameObject.Find("KeyScore");
       // audiosrc = GetComponent<AudioSource>();
       // audiosrc.clip = beepClip;
    }

    void OnCollisionEnter(Collision collision)
    {
        
       Debug.Log(gameObject.name +" Collided with " +collision.collider.name );
       if(collision.collider.name == "FPSController")
        {
           
         //   audiosrc.Play();
            key++;
            Debug.Log("Destroying the game object. Num keys = " +key);
            Destroy(gameObject);
            keyScoreUI.GetComponent<Text>().text = "Key: " + key;
        }

    }


}
