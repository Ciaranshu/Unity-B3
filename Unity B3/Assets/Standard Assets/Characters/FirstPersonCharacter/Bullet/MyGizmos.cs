using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyGizmos : MonoBehaviour {
	public Color color = Color.blue;
	public float radius = 0.01f;

	void OnDrawGizmos(){
		//set the color of Gizmos
		Gizmos.color = color;
		//create the ball of Gizmos with 0.1f as radius
		Gizmos.DrawSphere(transform.position,radius);
	
	}


}
