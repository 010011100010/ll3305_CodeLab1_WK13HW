using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour{
	public GameObject enemy;

	//public static 
	public static Queue<GameObject> pool = new Queue<GameObject>();
	public static Queue<GameObject> enemyPool = new Queue<GameObject>();

	public static GameObject Get(Poolable.types type) {
		GameObject result;
		if (type == poolable.types.BULLET) {
			if (pool.Count > 0) {
				result = pool.Dequeue ();
				result.SetActive (true);

			} else {
				result = GameObject.CreatePrimitive (PrimitiveType.Sphere);
				result.AddComponent<Rigidbody> ();
				result.AddComponent<poolableBullet> ();
			}
		} else {
			if (enemyPool.Count > 0) {
				result = enemyPool.Dequeue ();
				result.SetActive (true);
			} else {
				result = Instantiate (enemy);
			}
		bullet.GetComponent<poolableBullet> ().Reset();
		return bullet;
	}

	public static void AddToPool(GameObject obj) {
		obj.SetActive (false);
		if (obj.GetComponent<poolableBullet> () != null) {
			pool.Enqueue (obj);
		} else if (obj.GetComponent <poolableBullet>() != null) {
			enemyPool.Enqueue (obj);
		} else {
			Debug.Log ("Error!");
		}

	}
}
