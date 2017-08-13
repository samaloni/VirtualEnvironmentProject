using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideUnhideObject : MonoBehaviour
{

    public GameObject hide;
    public Renderer rend;
    public Vector3 currPosition;
    //public GameObject[] objects;

    // Use this for initialization
    void Start()
    {
        rend = GetComponent<Renderer>();
        hide = GameObject.Find("Painting3");
        currPosition = hide.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            
            Debug.Log("pressed Z" +hide.name + "position= " +currPosition);
            hide.transform.position = new Vector3(65, 25, -88);
           // hide.transform.localScale = new Vector3(66, 0, 0);
            //hide.GetComponent<Renderer>().enabled = false;
           // hide.SetActive(!hide.activeSelf);
        }
        if (Input.GetKeyDown(KeyCode.X))
        {

            hide.transform.position = currPosition;
           Debug.Log("pressed x" + hide.name + "position= " + currPosition);
            //hide.GetComponent<Renderer>().enabled = true;
            // hide.SetActive(!hide.activeSelf);
        }

    }
}

  /*  private void OnGUI()
    {

        foreach (GameObject go in objects)
        {
            bool active = GUILayout.Toggle(go.activeSelf, go.name);
            if(active != go.activeSelf)
            {
                go.SetActive(active);
            }
        }

    /*   if (gameObject.name =="Painting3" && Input.GetKeyDown(KeyCode.A))
       {
           Debug.Log("A pressed");
       } 
}
} */
