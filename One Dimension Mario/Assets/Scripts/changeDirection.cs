using UnityEngine;
using System.Collections;

public class changeDirection : MonoBehaviour {

void OnTriggerEnter(Collider col){

		if (col.gameObject.name == "Flashlight") {

		gameObject.GetComponentInParent<rotatingDirection>().rotationDirection *= -1;

		}

	}
}
