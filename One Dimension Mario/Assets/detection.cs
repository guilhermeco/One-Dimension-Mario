using UnityEngine;
using System.Collections;

public class detection : MonoBehaviour {

	string wallColor;

	// Use this for initialization
	void Start () {
	


	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter (Collision col) {

		Debug.Log ("I SEE YOU NERDS");

		wallColor = col.gameObject.GetComponent<playerControl> ().bckColor;

		Debug.Log (wallColor);

		if (wallColor == col.gameObject.tag) {

			Debug.Log ("NVM");


		} else {

			int currentLevel = Application.loadedLevel;
			Debug.Log (currentLevel);

			Debug.Log ("REKT");

			Destroy (col.gameObject);

			Application.LoadLevel(currentLevel);

		}
	}
}