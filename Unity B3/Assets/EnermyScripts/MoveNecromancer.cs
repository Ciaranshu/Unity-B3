using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveNecromancer : EnermyMove {

	private AttackSkill skill;

	// Use this for initialization
	void Start () {
		playerObj = GameObject.FindWithTag (EnermyInfo.PlayerTag);//player
		modelTrns = transform.FindChild (EnermyInfo.tag_NecromancerModel);//model transformation to move without other parts

		skill = 
			new AttackSkill (
			transform.FindChild (EnermyInfo.tag_NecromancerAttackCore).gameObject,
			EnermyInfo.tag_NecromancerAttack);//skill initialization

		attackPlayer (skill);//call the attack
	}
	
	// Update is called once per frame
	void Update () {
		move ();
	}

	protected override void move ()
	{	//towards player
		Vector3 temp = playerObj.transform.position;
		temp.y = modelTrns.localPosition.y;
		modelTrns.LookAt(temp);

		//call to locate the skill
		if (skill.getPS ().isStopped) {
			//Debug.Log ("攻击暂停？");
			skill.setLookAt (playerObj.transform.position);
		}
	}
	protected override void attackPlayer (AttackSkill attackSkill)
	{
		InvokeRepeating ("emit", EnermyInfo.f_NecromancerAttackStart, EnermyInfo.f_NecromancerAttackStop);
	}

	private void emit(){
		skill.getPS ().Play ();
		Invoke ("stop", EnermyInfo.f_NecromancerAttackStay);
	}
	private void stop(){
		skill.getPS ().Stop ();
	}

}
