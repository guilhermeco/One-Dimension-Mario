using UnityEngine;
using System.Collections;

public class goLevel4 : MonoBehaviour {

	bool nextStage = false;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (nextStage == true) {
			Application.LoadLevel("Paul Level 4");
		}
	}

	void OnTriggerEnter(Collider other){
		Debug.Log ("hit");
		nextStage = true;
	}
}
