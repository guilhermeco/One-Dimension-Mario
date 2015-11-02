using UnityEngine;
using System.Collections;

public class blinkLight : MonoBehaviour
{
	

	float timer;
	float waitTime = 1.5f;
	float resetPoint;

	void Start ()
	{

		resetPoint = waitTime * 3;
	}

	void Update ()
	{

		timer += Time.deltaTime;

		if (timer < waitTime) {

			GetComponent<MeshRenderer> ().enabled = true;

		}
		
		if (timer > waitTime) {
			
			GetComponent<MeshRenderer> ().enabled = false;
			
		}

		if (timer > resetPoint) {
			timer = 0;
		}
	}

}
