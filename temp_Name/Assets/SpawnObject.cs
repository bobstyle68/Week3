using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObject : MonoBehaviour {

    public GameObject ObjectToSpawn;
    Vector3 mousePos;

    // Update is called once per frame
    void Update () {
        if (Input.GetMouseButtonDown(0)) 
        {
            mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            mousePos.z = 0;

            Instantiate(ObjectToSpawn, mousePos, Quaternion.identity);
        }
		
	}
}
