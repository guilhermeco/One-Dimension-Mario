using UnityEngine;
using System.Collections;

public class toLevel4 : MonoBehaviour {

	bool nextStage = false;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (nextStage == true) {
			Application.LoadLevel ("Paul level 4 real one");
		}
		
	}
	
	void OnTriggerEnter(Collider other){
		Debug.Log ("hit");
		nextStage = true;
	}
}
