using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Props : MonoBehaviour {
    public Transform[] points;
    public GameObject prop;
    public float createTime = 0.1f;
    public int maxProps = 10000;
    public bool isCollisionOver = false;
    // Use this for initialization
    void Start () {
      
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnCollisionEnter(Collision coll)
    {
        if (!isCollisionOver)
        {
            if (coll.collider.tag == "Player")
        {
             points = GameObject.Find("PropPoints").GetComponentsInChildren<Transform>();
                if (points.Length > 0)
        {
            StartCoroutine(this.CreateProps());
        }
        }
        }
        isCollisionOver = true; 
    }
    IEnumerator CreateProps()
    {
        
        for (int i = 0; i < maxProps; i++)
        {
            yield return new WaitForSeconds(createTime);
            int idx = Random.Range(1, points.Length);
            Instantiate(prop, points[idx].position, points[idx].rotation);
        }


    }
    
}
