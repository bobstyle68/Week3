using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateToFaceMouse : MonoBehaviour {

	
	
	
	// Update is called once per frame
	void Update () {
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePos.z = 0;

        Vector3 direction = mousePos - transform.position;

        transform.up = direction;
		
	}
}
