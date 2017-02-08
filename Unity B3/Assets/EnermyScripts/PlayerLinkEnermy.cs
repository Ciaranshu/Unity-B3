using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLinkEnermy : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

	}

	void OnParticleCollision(GameObject go){
		switch (go.tag) {
		case EnermyInfo.tag_BossAttack1:
			Debug.Log ("玩家被【火焰】攻击");
			break;
		case EnermyInfo.tag_BossAttack2:
			Debug.Log ("玩家被【粉笔】攻击");
			break;
		case EnermyInfo.tag_NecromancerAttack:
			Debug.Log ("玩家被【巫师】攻击");
			break;
		default:
			break;
		}
	}

	void OnCollisionEnter(Collision coll){
		switch (coll.gameObject.tag) {
		case EnermyInfo.tag_Ninja:
			Debug.Log ("玩家被【忍者】攻击");
			break;
		case EnermyInfo.tag_Guard:
			Debug.Log ("玩家被【守卫】攻击");
			break;
		default:
			break;
		}
	}

	void OnTriggerEnter(Collider coll){
		if (coll.tag == EnermyInfo.tag_TrapTrigger) {
			Debug.Log ("玩家进入【陷阱】");
		}
	}
}
