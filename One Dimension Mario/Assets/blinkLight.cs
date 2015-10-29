using UnityEngine;
using System.Collections;

public class blinkLight : MonoBehaviour
{
	

	float timer;
	float blinkNow = 1.5f;
	float appearPoint;

	void Start ()
	{

		appearPoint = blinkNow * 3;
	}

	void Update ()
	{

		timer += Time.deltaTime;

		if (timer < blinkNow) {

			GetComponent<MeshRenderer> ().enabled = true;

		}
		
		if (timer > blinkNow) {
			
			GetComponent<MeshRenderer> ().enabled = false;
			
		}

		if (timer > appearPoint) {
			timer = 0;
		}
	}

}
