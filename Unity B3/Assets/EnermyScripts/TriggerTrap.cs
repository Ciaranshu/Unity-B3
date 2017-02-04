using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerTrap : Trigger {

	// Use this for initialization
	protected override void Start () {
		
	}

	protected override void OnTriggerEnter (Collider coll)
	{
		if (coll.tag == EnermyInfo.PlayerTag) {
			Debug.Log ("【陷阱】攻击玩家成功！");

		}
	}

	protected override void Des ()
	{
		throw new System.NotImplementedException ();
	}
}
