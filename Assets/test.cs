using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        var oldPosition = this.transform.position;
		this.transform.position  =  new Vector2(oldPosition.x + 5f / 1000, oldPosition.y);
	}
}
