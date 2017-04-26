using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Poolable : MonoBehaviour {
	
	void Start () {
		Setup ();
	}
	// Update is called once per frame
	void Update () {
		if (RePoll()){
			ObjectPool.AddToPool (gameObject);
		}	
	}

	public virtual void Setup(){
		
	}

	public virtual bool RePoll(){
		return true;
	}

	public virtual void Reset () {
		/*Rigidbody rb = GetComponent<Rigidbody> ();

		rb.velocity = Vector3.zero;
		//GetComponent<Rigidbody> ().Velocity = Vector3.zero;
		rb.AddForce(Vector3.up*movementSpeed);
		transform.position = player.transform.position + new Vector3 (0, 1, 0);*/
	}
}
