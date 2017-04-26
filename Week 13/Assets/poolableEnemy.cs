using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class poolableEnemy : Poolable {

	public bool gotHit = false;

	public override void Setup() 
	{
		//Setup a new enemy
		betterName = types.ENEMY;
	}

	public override bool RePoll ()
	{
		return gotHit;
	}

	public override void Reset ()
	{
		//Respawn
	}
}

