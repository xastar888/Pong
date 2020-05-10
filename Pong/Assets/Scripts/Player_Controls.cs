﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Controls : MonoBehaviour {

    public KeyCode MoveUp = KeyCode.UpArrow;
    public KeyCode MoveDown = KeyCode.DownArrow;

    public float speed = 10.0f;
    public float boundY = 2.25f;
    private Rigidbody2D rb2d;



    // Use this for initialization
    void Start () {

        rb2d = GetComponent<Rigidbody2D>();

    }
	
	// Update is called once per frame
	void Update () {

        var vel = rb2d.velocity;
        if (Input.GetKey(MoveUp)) {
            vel.y = speed;
        }
        else if (Input.GetKey(MoveDown)) { 
            vel.y = -speed;
        }
        else {
            vel.y = 0;
        }
        rb2d.velocity = vel;

        var pos = transform.position;
        if (pos.y > boundY) {
            pos.y = boundY;
        }
        else if (pos.y < -boundY) {
            pos.y = -boundY;
        }
        transform.position = pos;
    }
}
