﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToPlayer : MonoBehaviour {
    GameObject player;
    public float movementSpeed = 100;
    Rigidbody2D body;

	// Use this for initialization
	void Start () {
        body = GetComponent<Rigidbody2D>();
        player = GameObject.FindGameObjectWithTag("Player");
        Vector3 direction = player.transform.position - transform.position;
        direction.z = 0;
        direction.Normalize();

        body.velocity = direction * movementSpeed;
		
	}
	
	
}
