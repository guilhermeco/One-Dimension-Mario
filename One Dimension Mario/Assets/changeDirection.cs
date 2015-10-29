using UnityEngine;
using System.Collections;

public class changeDirection : MonoBehaviour {

void OnTriggerEnter(Collider other){

		//if (col.gameObject.tag == "Flashlight") {

		GameObject.Find ("Point").GetComponent<Rotating>().rotationDirection *= -1;

		//}

	}
}
