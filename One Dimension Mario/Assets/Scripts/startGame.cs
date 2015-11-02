using UnityEngine;
using System.Collections;

public class startGame : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	}

	void OnTriggerEnter(Collider other){
		Debug.Log ("hit");
		Application.LoadLevel("Gui Scene 1");
	}
}
