using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour{

	public static Queue<GameObject> pool = new Queue<GameObject>();

	public static GameObject Get() {
		GameObject bullet;
		if (pool.Count > 0) {
			bullet = pool.Dequeue ();
			bullet.SetActive (true);

		} else {
			bullet = GameObject.CreatePrimitive (PrimitiveType.Sphere);
			bullet.AddComponent<Rigidbody> ();
			bullet.AddComponent<poolableBullet> ();
		}
		return bullet;
	}

	public static void AddToPool(GameObject obj) {
		obj.SetActive (false);
		pool.Enqueue (obj);

	}
}
