using UnityEngine;
using System.Collections;

public class changeDirection : MonoBehaviour {

void OnTriggerEnter(Collider other){

		GameObject.Find ("RotationPoint").GetComponent<Rotating>().rotationDirection = true;

	}
}
