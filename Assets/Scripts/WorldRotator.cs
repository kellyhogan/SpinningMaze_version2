using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldRotator : MonoBehaviour {

	public float speed;
	//public int spacing = 1;
	// Use this for initialization
	void Start () {
		
	}
	
	 void Update(){

         //transform.Rotate(new Vector3(-10, 0, 0) * Time.deltaTime);


	}

	    // called per frame, before performing physics
    void FixedUpdate(){
        // float moveHorizontal = Input.GetAxis("Horizontal");
        // float moveVertical = Input.GetAxis("Vertical");

        // Vector3 movement = new Vector3(moveVertical, 0.0f, moveHorizontal);
        // movement = transform.TransformDirection(movement);
        // print(movement);
        // //transform.Rotate(movement * Time.deltaTime);
        // transform.Rotate(movement * speed);

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
