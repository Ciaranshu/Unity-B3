using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class FollowCam : MonoBehaviour {
    //public Transform targetTr;//主人公对象Transform
    //public float dist = 2.5f;//摄像机与主人公距离
    //public float height = 1.0f;//摄像机高度
    //public float dampTrace = 100.0f;//平滑追踪变量
    private Transform tr;//摄像机Transfprm

	// Use this for initialization
	void Start () {
		tr=GetComponent<Transform>();
	}
	
	// Update is called once per frame
	void Update () {



    }

	void LateUpdate () {

	}
}

//以下注释放置在触发斜坡处，以改变Camera视角
//Vector3 rotation = tr.localEulerAngles;
//rotation.x = 9f; // 在这里修改坐标轴的值
//tr.localEulerAngles = rotation;
