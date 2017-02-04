using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Trigger : MonoBehaviour {

	// Use this for initialization
	protected abstract void Start ();
	
	// Update is called once per frame
	protected abstract void OnTriggerEnter(Collider coll);

	protected abstract void Des();
}
