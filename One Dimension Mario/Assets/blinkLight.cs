using UnityEngine;
using System.Collections;

public class blinkLight : MonoBehaviour {

	bool blinkNow = false;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		if(blinkNow == true){
			GetComponent<MeshRenderer>().enabled = false;
			blinkNow = false;

			Invoke ("makeItBlink", 2f);


		}else {

			GetComponent<MeshRenderer>().enabled = true;

		}
	}


	void makeItBlink(){

		blinkNow = true;

	}

//	void stopBlink(){
//
//		blinkNow = false;
//
//	}
}
