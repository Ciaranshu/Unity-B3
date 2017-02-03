using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCtrl : MonoBehaviour {

	private float h = 0.0f;
	private float v = 0.0f;

	//分配变量
	private Transform tr;
	//移动速度变量
	public float moveSpeed=10.0f;
	//旋转速度变量
	public float rotSpeed=100.0f;

	// Use this for initialization
	void Start () {
		//向初始部分分配Transform
		tr=GetComponent<Transform>();

	}
	
	// Update is called once per frame
	void Update () {
		h = Input.GetAxis ("Horizontal");
		v = Input.GetAxis ("Vertical");

		Debug.Log ("H=" + h.ToString ());
		Debug.Log ("V=" + v.ToString ());

		Vector3 moveDir = (Vector3.forward * v) + (Vector3.right * h);
		tr.Translate (moveDir.normalized * Time.deltaTime * moveSpeed, Space.Self);

		tr.Rotate (Vector3.up * Time.deltaTime * rotSpeed * Input.GetAxis ("Mouse X"));
	}
}
