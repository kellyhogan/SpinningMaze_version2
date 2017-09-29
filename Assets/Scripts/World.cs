using UnityEngine;
using System.Collections;

public class World : MonoBehaviour {

    public GameObject player;


	// Use this for initialization
	void Start () {

	}

	void Update(){

	}

	// Update is called once per frame
	void FixedUpdate () {
        player.GetComponent<Rigidbody>().AddForce(transform.up * -9.8f);
	}
}
