using UnityEngine;
using System.Collections;

public class goExit : MonoBehaviour {

	bool nextStage = false;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		if (nextStage == true) {
			Application.LoadLevel ("Final Scene");
		}

	}

	void OnTriggerEnter(Collider other){
		Debug.Log ("hit");
		nextStage = true;
	}
}
