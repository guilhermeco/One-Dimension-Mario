using UnityEngine;
using System.Collections;

public class changeDirection : MonoBehaviour {

void OnTriggerEnter(Collider col){

		if (col.gameObject.name == "Flashlight") {

		GameObject.Find ("Point").GetComponent<Rotating>().rotationDirection *= -1;

		}

	}
}
