using UnityEngine;
using System.Collections;

public class loadLevel2 : MonoBehaviour {

	bool nextStage = false;

	void Update(){

		if (nextStage == true) {
			Application.LoadLevel("Gui Scene 2");
		}

	}
	
	void OnTriggerEnter(Collider other){
		Debug.Log ("i've hit the thing");
		nextStage = true;


	}

}
