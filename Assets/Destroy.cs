using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour {

	private GameObject MainCamera;


	// Use this for initialization
	void Start () {
		this.MainCamera = GameObject.Find ("Main Camera");
	}
	
	// Update is called once per frame
	void Update () {
		if (this.gameObject.transform.position.z < this.MainCamera.transform.position.z){
			Destroy (this.gameObject);
		}
			
		
	}

}
