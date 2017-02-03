using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class FollowCam : MonoBehaviour {
	public Transform targetTr;//主人公对象Transform
	public float dist = 2.5f;//摄像机与主人公距离
	public float height=1.0f;//摄像机高度
	public float dampTrace =100.0f;//平滑追踪变量
	private Transform tr;//摄像机Transfprm

	// Use this for initialization
	void Start () {
		tr=GetComponent<Transform>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void LateUpdate () {
		tr.position = Vector3.Lerp (tr.position,targetTr.position-(targetTr.forward*dist)+(Vector3.up*height),Time.deltaTime*dampTrace);
		tr.LookAt (targetTr.position);
	}
}
