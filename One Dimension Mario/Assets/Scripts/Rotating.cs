using UnityEngine;
using System.Collections;

public class Rotating : MonoBehaviour {

	float rotationAmount = 15f;
	float direction;


	// Use this for initialization
	void Start () {

	
	}
	
	// Update is called once per frame
	void Update () {

		direction = gameObject.GetComponentInParent<rotatingDirection> ().rotationDirection;

		transform.Rotate(Vector3.forward * rotationAmount * Time.deltaTime * direction);

	}
}
