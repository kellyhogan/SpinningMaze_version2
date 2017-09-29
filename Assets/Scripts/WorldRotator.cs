using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldRotator : MonoBehaviour {

	public float speed;
	void Start () {
		
	}
	
	 void Update(){

	}

	    // called per frame, before performing physics
    void FixedUpdate(){
    	if (Input.GetKey(KeyCode.J))
      		transform.Rotate(Vector3.up * speed);
     	if (Input.GetKey(KeyCode.L))
         	transform.Rotate(Vector3.down * speed);
     	if (Input.GetKey(KeyCode.I))
         	transform.Rotate(Vector3.right * speed);
     	if (Input.GetKey(KeyCode.K))
         	transform.Rotate(Vector3.left * speed);
    }
}
