using UnityEngine;
using System.Collections;

public class blinkLight : MonoBehaviour
{

	float timer;
	float blinkNow = 2f;
	float appearPoint;
	
	void Start ()
	{

		appearPoint = blinkNow * 2;
	}

	void Update ()
	{

			timer += Time.deltaTime;

			if (timer < blinkNow) {

				GetComponent<MeshRenderer> ().enabled = true;
			GetComponent<BoxCollider>().enabled = true;

			}
		
			if (timer > blinkNow) {
			
				GetComponent<MeshRenderer> ().enabled = false;
			GetComponent<BoxCollider>().enabled = false;

			}

			if (timer > appearPoint) {
				timer = 0;
			}
	}

}
