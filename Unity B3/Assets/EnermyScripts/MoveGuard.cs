using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MoveGuard : EnermyMove {

	// Use this for initialization
	void Start () {
		playerObj = GameObject.FindWithTag (EnermyInfo.PlayerTag);
	}
	
	// Update is called once per frame
	void Update () {
		move ();
	}

	protected override void move ()
	{
		gameObject.GetComponent<NavMeshAgent> ().destination = playerObj.transform.position;

	}
	protected override void attackPlayer (AttackSkill attackSkill)
	{
		Debug.Log ("【守卫】成功攻击玩家");
	}

	void OnCollisionEnter(Collision coll){
		if (coll.gameObject.tag == EnermyInfo.PlayerTag) {
			attackPlayer (null);
			transform.position -= transform.forward * EnermyInfo.f_GuardTurnBackDis;
		}
	}
}
