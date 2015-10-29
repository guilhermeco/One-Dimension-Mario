using UnityEngine;
using System.Collections;

public class blinkLight : MonoBehaviour {

	bool blinkNow = true;

	void Start () {
	
	}
	
	void Update () {
	
		if(blinkNow == true){
			GetComponent<MeshRenderer>().enabled = false;
			blinkNow = false;

			Invoke ("makeItBlink", 2f);

		}else if(blinkNow == false){

			GetComponent<MeshRenderer>().enabled = true;

			Invoke ("stopBlink", 2f);

		}
	}


	void makeItBlink(){

		blinkNow = true;

	}

	void stopBlink(){

		blinkNow = false;

	}
}
