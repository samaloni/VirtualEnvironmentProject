﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boat : MonoBehaviour {

    public float speed = 20;
    public float turnSpeed = 1000f;
    public float accSpeed = 1000f;

    private Rigidbody rbody;


	// Use this for initialization
	void Start () {

        rbody = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKey(KeyCode.I))
            transform.Translate(Vector3.left * speed * Time.deltaTime);

        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        rbody.AddTorque(0f, h * turnSpeed * Time.deltaTime,0f);
        rbody.AddForce(transform.forward * v * accSpeed * Time.deltaTime);
	}


}
