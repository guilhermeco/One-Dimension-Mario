using UnityEngine;
using System.Collections;

public class caughtByLight : MonoBehaviour {

	void Update () {
	
	}

	void OnTriggerEnter(Collider col){

		if (col.gameObject.name == "Player") {

		GetComponent<Renderer> ().material.color = Color.yellow;

		}

	}
}
