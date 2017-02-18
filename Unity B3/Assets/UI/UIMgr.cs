using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIMgr : MonoBehaviour {
    public GameObject menu;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void show()
    {
        menu.gameObject.SetActive(true);
    }
    public void unshow()
    {
        menu.gameObject.SetActive(false);
    }
    public void quit()
    {
        Application.Quit();
    }
}
