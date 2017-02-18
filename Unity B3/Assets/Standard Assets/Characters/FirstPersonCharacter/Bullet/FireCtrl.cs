using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireCtrl : MonoBehaviour {
	//initialize the bullet
	public GameObject bullet;

	//fire position of bullet
	public Transform fireposition;

	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0)) {
			Fire ();		
		}
		if (Input.GetKeyDown ("space")) {
			Fire ();
		}
	}

	void Fire(){
		//dynamically create bullet
		CreateBullet();
        GameObject.Find("Player").GetComponent<PlayerCtrl>().Fire();
	}

	void CreateBullet(){
		//dynamically initialize the bullet
		Instantiate(bullet,fireposition.position,fireposition.rotation);
	}
}
