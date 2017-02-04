using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DesBlood : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Invoke ("Des", 10.0f);
	}

	void Des(){
		Destroy (gameObject);
	}
	

}
