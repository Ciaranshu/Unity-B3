using UnityEngine;
using System.Collections;

public class BulletControl : MonoBehaviour
{
	//the power of bullet
	public int damage = 20;
	//the speed of bullet
	public float speed = 1000.0f;

	void Start(){
		GetComponent<Rigidbody>().AddForce(transform.forward*speed);
	}

	void OnCollisionEnter(Collision Coll){
        if (Coll.gameObject.tag != "Player")
        {
            Destroy(this.gameObject);
        }

        Debug.Log(Coll.collider.tag);
	}
}
