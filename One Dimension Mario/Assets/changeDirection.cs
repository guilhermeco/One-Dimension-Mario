using UnityEngine;
using System.Collections;

public class changeDirection : MonoBehaviour {

void OnTriggerEnter(Collider other){

		GameObject.Find ("Point").GetComponent<Rotating>().rotationDirection *= -1;

	}
}
