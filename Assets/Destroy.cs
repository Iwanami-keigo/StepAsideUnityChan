using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour {

	Renderer Item;


	// Use this for initialization
	void Start () {
		Item = GetComponent<Renderer> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Item.isVisible) {
		} else {
			Destroy (this.gameObject);
		}
			
		
	}

}
