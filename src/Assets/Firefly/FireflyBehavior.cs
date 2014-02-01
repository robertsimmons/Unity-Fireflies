using UnityEngine;
using System.Collections;

public class FireflyBehavior : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	}

	void OnMouseDown(){
		Destroy (transform.gameObject);
	}
}
