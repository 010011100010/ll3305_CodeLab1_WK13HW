using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class poolableBullet : Poolable {
	public float maxDistance = 10f;
	public float movementSpeed = 50f;
	GameObject player;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public override void Setup() {
		player = GameObject.Find ("Player");
	}

	public override bool RePoll(){
		if (Vector3.Distance (player.transform.position, transform.position) > maxDistance) {
			return true;
		}
		return false;
	}

	public override void Reset ()
	{
		
		Rigidbody rb = GetComponent<Rigidbody> ();

		rb.velocity = Vector3.zero;
		//GetComponent<Rigidbody> ().Velocity = Vector3.zero;
		rb.AddForce (Vector3.up * movementSpeed);
		transform.position = player.transform.position + new Vector3 (0, 1, 0);
	}
}
