using UnityEngine;
using System.Collections;

public class loadLevel2 : MonoBehaviour {
	
	void OnTriggerEnter(Collider other){

		if (other.gameObject.name == "Player") {
			Debug.Log ("i've hit the thing");
			Application.LoadLevel ("Gui Scene 2");
		}
	}

}
