using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyBoardMovement : MonoBehaviour {
    public float movementSpeed = 10;
    public float horizontal, vertical;

    Rigidbody2D body;

    public float rotationSpeed = 2;


	// Use this for initialization
	void Start () {
        body = GetComponent<Rigidbody2D>();
		
	}
	
	// Update is called once per frame
	void Update () {
        vertical = Input.GetAxis("Vertical");
        horizontal = Input.GetAxis("Horizontal");

        if (Input.GetKey(KeyCode.Q))
        {
            transform.Rotate(0, 0, -rotationSpeed);
        }
        else if (Input.GetKey(KeyCode.E))
        {
            transform.Rotate(0, 0, rotationSpeed);
        }
		
	}
    void FixedUpdate()
    {
        body.velocity = new Vector2(horizontal, vertical) * movementSpeed * Time.deltaTime;
    }
}
