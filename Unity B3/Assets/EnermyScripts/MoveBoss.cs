using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBoss : EnermyMove {


	private float currentBlood = EnermyInfo.f_BossTotalBlood;//current value of blood

	private AttackSkill skill_1;

	private AttackSkill skill_2;


	// Use this for initialization
	void Start () {
		playerObj = GameObject.Find (EnermyInfo.PlayerTag).gameObject;
		modelTrns = transform.FindChild (EnermyInfo.tag_BossModel);

		skill_1 = new AttackSkill (transform.FindChild (EnermyInfo.tag_BossAttack1Core).gameObject, EnermyInfo.tag_BossAttack1);
		skill_2 = new AttackSkill (transform.FindChild (EnermyInfo.tag_BossAttack2Core).gameObject, EnermyInfo.tag_BossAttack2);

		attackPlayer (skill_1);//emit skill_1
	}
	
	// Update is called once per frame
	void Update () {
		if (modelTrns != null) {
			move ();//move the boss
		} else {
			Invoke ("Des", 8.0f);
		}

		if (skill_2.getPS ().isStopped) {
			float currentDistance = Vector3.Distance (playerObj.transform.position, transform.position);
			if (currentDistance > EnermyInfo.f_BossAttack2MinDis) {
				attackPlayer (skill_2);
			}
		}//emit skill_2 with conditions
	}

	protected override void move ()
	{
		transform.position += modelTrns.forward * EnermyInfo.f_BossSpeed;//walk slowly towards player
		modelTrns.LookAt(playerObj.transform.position);//only rotate the boss face towards the player
		//transform.RotateAround (transform.position, Vector3.up, Vector3.Angle (transform.forward, playerObj.transform.position));//turn to player
	}
	protected override void attackPlayer (AttackSkill attackSkill)
	{
		switch (attackSkill.getSkillObj ().tag) {
		case EnermyInfo.tag_BossAttack1:
			InvokeRepeating ("emit_1",EnermyInfo.f_BossAttack1Start,EnermyInfo.f_BossAttack1Stop);
			break;
		case EnermyInfo.tag_BossAttack2:
			attackSkill.getSkillObj ().transform.parent.LookAt (playerObj.transform.position);//aim at player
			Invoke ("emit_2",EnermyInfo.f_BossAttack2Start);//start emitting
			break;
		}
	}


	private void emit_1(){
		skill_1.getPS ().Play ();
		Invoke ("stop_1",EnermyInfo.f_BossAttack1Stay);
	}
	private void stop_1(){
		skill_1.getPS ().Stop ();
	}
	private void emit_2(){
		skill_2.getPS ().Play ();
		Invoke ("stop_2", EnermyInfo.f_BossAttack2Stay);
	}
	private void stop_2(){
		skill_2.getPS ().Stop ();
	}


	public float getCurrentBlood(){
		return currentBlood;
	}
	public bool setCurrentBlood(){
		currentBlood -= EnermyInfo.f_BossHurtedBloodDcr;
		if (currentBlood > 0)
			return true;
		else {
			currentBlood = 0;
			return false;
		}
	}


	private void Des(){
		Destroy (gameObject);
	}
}
