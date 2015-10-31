using UnityEngine;
using System.Collections;

public class caughtByLight : MonoBehaviour
{

	bool stopBlink = false;
	
	void Update ()
	{
	
	}


	void OnTriggerEnter (Collider col)
	{

		if (col.gameObject.name == "Player") {

			GetComponent<Renderer> ().material.color = Color.yellow;
		
			Invoke("restartLevel", 1.5f);

			stopBlink = true;
		
		}

		if(stopBlink == true && isActiveAndEnabled){

		}

	}


	void restartLevel(){

		int currentLevel = Application.loadedLevel;

		Application.LoadLevel(currentLevel);

	}
}
