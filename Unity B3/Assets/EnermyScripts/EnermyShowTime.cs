﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnermyShowTime : MonoBehaviour {

    public Transform[] points;
    public GameObject Enermy;
    public float createTime = 0.1f;
    public int maxEnermies = 6;
    public bool isCollisionOver = false;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnCollisionEnter(Collision coll)
    {
        if (!isCollisionOver)
        {
            if (coll.collider.tag == "Player")
            {
                points = GameObject.Find("EnermyPoints").GetComponentsInChildren<Transform>();
                if (points.Length > 0)
                {
                    StartCoroutine(this.CreateEnermies());
                }
            }
        }
        isCollisionOver = true;
    }
    IEnumerator CreateEnermies()
    {

        for (int i = 0; i < maxEnermies; i++)
        {
            yield return new WaitForSeconds(createTime);
            int idx = Random.Range(1, points.Length);
            Instantiate(Enermy, points[idx].position, points[idx].rotation);
        }


    }
}