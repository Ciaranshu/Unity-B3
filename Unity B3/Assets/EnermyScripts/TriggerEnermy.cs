using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerEnermy : Trigger {

	private string triggerTag;

	protected override void Start () {
		triggerTag = transform.parent.tag;
	}
	

	protected override void OnTriggerEnter(Collider coll){
		Debug.Log ("?//");
		if (coll.gameObject.tag == EnermyInfo.weaponTag) {
			switch (triggerTag) {
			case EnermyInfo.tag_Guard:
				Debug.Log ("【守卫】被 玩家 攻击了");
				Des ();
				break;
			case EnermyInfo.tag_Necromancer:
				Debug.Log ("【巫师】被 玩家 攻击了");
				Des ();
				break;
			case EnermyInfo.tag_Ninja:
				Debug.Log ("【忍者】被 玩家 攻击了");
				Des ();
				break;
			default:
				break;
			}
		} 
	}

	protected override void Des(){
		GameObject blood = Resources.Load (EnermyInfo.tag_BloodCore)as GameObject;
		Destroy (transform.parent.gameObject);
		Instantiate (blood, transform.position, Quaternion.identity);
	}
}
