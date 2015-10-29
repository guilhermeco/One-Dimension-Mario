using UnityEngine;
using System.Collections;

public class blinkLight : MonoBehaviour
{
	

	float timer;
	float blinkNow = 2f;
	float appearPoint;

	//public bool noMoreBlink = false;

	void Start ()
	{

		appearPoint = blinkNow * 2;
	}

	void Update ()
	{

		//if (noMoreBlink == false) {
			timer += Time.deltaTime;

			if (timer < blinkNow) {

				GetComponent<MeshRenderer> ().enabled = true;
			GetComponent<BoxCollider>().enabled = true;
				//gameObject.SetActive (true);

			}
		
			if (timer > blinkNow) {
			
				GetComponent<MeshRenderer> ().enabled = false;
			GetComponent<BoxCollider>().enabled = false;

				//gameObject.SetActive (false);

			}

			if (timer > appearPoint) {
				timer = 0;
			}
		//}
	}

}
