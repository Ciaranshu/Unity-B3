using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class AttackSkill {

	private GameObject coreObj;
	private GameObject skillObj;

	private ParticleSystem ps;

	//-------------------------------------------Initialization
	public AttackSkill(GameObject coreObj,string skillName){

		this.coreObj = coreObj;
		skillObj = coreObj.transform.FindChild (skillName).gameObject;
		ps = skillObj.GetComponent<ParticleSystem> ();

	}

	//-------------------------------------------GetFunction
	public ParticleSystem getPS(){
		return ps;
	}
	public GameObject getSkillObj(){
		return skillObj;
	}

	//-------------------------------------------SetFunction
	public void setPosition(Vector3 newPosition){
		coreObj.transform.position = newPosition;
	}
	public void setLookAt(Vector3 targetPosition){
		coreObj.transform.LookAt (targetPosition);
	}
}
