using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class EnermyMove : MonoBehaviour {

	protected GameObject playerObj;
	protected Transform modelTrns;

	protected abstract void move ();
	protected abstract void attackPlayer(AttackSkill attackSkill);
}
