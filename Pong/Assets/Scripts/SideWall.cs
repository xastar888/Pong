﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SideWall : MonoBehaviour {
 

    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        if (hitInfo.name == "Pong Ball")
        {
            string wallName = transform.name;
            Game_Manager.Score(wallName);
            hitInfo.gameObject.SendMessage("RestartGame", 1.0f, SendMessageOptions.RequireReceiver);
        }
    }





// Use this for initialization
void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

    }
}
