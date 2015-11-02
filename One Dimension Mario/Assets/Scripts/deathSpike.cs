using UnityEngine;
using System.Collections;

public class deathSpike : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter (Collider col) {

		if (col.gameObject.name == "Player") {

			int currentLevel = Application.loadedLevel;
			Debug.Log (currentLevel);
		
			Debug.Log ("REKT");
		
			Destroy (col.gameObject);
		
			Application.LoadLevel (currentLevel);
		}
	}
}
