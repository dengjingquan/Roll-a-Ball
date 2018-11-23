using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sc : MonoBehaviour {

    public GameObject img;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void onclick()
    {
        img.GetComponent<RectTransform>().localScale = new Vector3(30f,1f,1f);
    } 
}
