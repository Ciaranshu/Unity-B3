using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnermyMoveNinja : EnermyMove {
	//---------------------------------------------------------------------------//
	//----------------------------------Chari------------------------------------//


	//---------------------------------------------------------------------------//
	//----------------------------------Basic------------------------------------//
	void Start () {
		playerObj = GameObject.FindWithTag (EnermyInfo.PlayerTag);
		Invoke ("DesSelf", EnermyInfo.f_NinjaDesSelfTime);
	}
	void Update () {
		move ();	
	}
	protected override void move ()
	{
		transform.position += transform.forward * EnermyInfo.f_NinjaMoveSpeed;
	}
	protected override void attackPlayer (AttackSkill attackSkill){throw new System.NotImplementedException ();}


	//---------------------------------------------------------------------------//
	//----------------------------------Specific------------------------------------//
	private void DesSelf(){
		Debug.Log ("【忍者】自杀了");
		Destroy (gameObject);
	}
}
