using UnityEngine;
using System.Collections;

public class FireflyBehavior : MonoBehaviour {

	private Score score;

	// Use this for initialization
	void Start () {
		score = GameObject.Find("Score").GetComponent<Score>();
	}
	
	// Update is called once per frame
	void Update () {

	}

	void OnMouseDown(){
		Destroy (transform.gameObject);
		score.score += 1;
	}
}
