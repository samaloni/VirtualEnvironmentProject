
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


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

            if(key == 3)
            {
                Debug.Log("Player got 3 keys ");
                Application.LoadLevel(1);
                
            }
        }
       else if(collision.collider.name == "FirstPersonCharacter")
        {
            key++;
            Debug.Log("Destroying the game object. Num keys = " + key);
            Destroy(gameObject);
            keyScoreUI.GetComponent<Text>().text = "Congratulations You got Key: " + key;
        }
       else
        {
            Debug.Log("collided with something else : " + collision.collider.name);

        }

    }


}
