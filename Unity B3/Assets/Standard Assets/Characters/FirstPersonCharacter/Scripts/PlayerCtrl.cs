﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityStandardAssets.Characters;

public class PlayerCtrl : MonoBehaviour {

    //初始化血量
    public int hp =100; 
    //初始化弹药数量
    public float ammo = 100f;
    //死亡状态
    public bool isDead = false;
    //复活等待时间
    private float waitingTime=3.0f;

	//分配变量
	private Transform tr;
	//移动速度变量
	//public float moveSpeed=10.0f;
	//旋转速度变量
	//public float rotSpeed=100.0f;

    public Image hpbar;

    public Text hpnumber;
	// Use this for initialization
	void Start () {
		//向初始部分分配Transform
		tr=GetComponent<Transform>();

	}
	
	// Update is called once per frame
	void Update () {
  
        //检测血量
     // if (hp <= 0) StartCoroutine(this.RespawnPlayer());

    }

    //IEnumerator RespawnPlayer()
    //{

    //    isDead = true;

    //    //不可攻击 不被攻击

    //    //等待复活时间 期间不可移动 
    //    moveSpeed = 0;
    //    rotSpeed = 0;
    //    yield return new WaitForSeconds(waitingTime);

    //    //重置人物血量
    //    hp = 100;

    //    //重置人物弹药量
    //    if (ammo < 100) ammo = 100;

    //    //在某一位置复活
    //    tr.position = new Vector3(0.0f, 0.0f, 0.0f);

    //    moveSpeed = 10.0f;
    //    rotSpeed = 100.0f;
    //    isDead = false;
    //}

    int returnhp()
    {
        return hp;
    }
    void hit(int blood)
    {
        hp -= blood;
        hpbar.fillAmount = (float)hp / 100;
        hpnumber.text = hp.ToString();
    }
}
