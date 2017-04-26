using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoot : MonoBehaviour {
	public float speed = 50f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.Space)) {
			//Vector3 modPos = new Vector3 (0, 1, 0);
			GameObject bullet = ObjectPool.Get();
			//bullet.transform.position = transform.position + modPos;
			//bullet.GetComponent<Rigidbody> ().velocity = speed;

		}
	}
}
