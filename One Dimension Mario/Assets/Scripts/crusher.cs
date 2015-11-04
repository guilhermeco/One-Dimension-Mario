using UnityEngine;
using System.Collections;

public class crusher : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
		
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void OnTriggerStay (Collider col) {
		
		Debug.Log ("TOUCHING SOMETHING");
		
		if (col.gameObject.name == "Player") {
			
			if (gameObject.tag == col.gameObject.tag) {
				
				Debug.Log ("NVM");

			} else {
				
				int currentLevel = Application.loadedLevel;
				
				Debug.Log ("REKT");
				
				Destroy (col.gameObject);
				
				Application.LoadLevel (currentLevel);
				
			}
			
		}
	}

}
