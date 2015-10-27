using UnityEngine;
using System.Collections;

public class Rotating : MonoBehaviour {

	float rotationAmount = 1.5f;
	//public float rotationDirection = 1;

	public bool rotationDirection = false;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		transform.Rotate(Vector3.forward * rotationAmount);

		if(rotationDirection == true){

			rotationAmount *= -1;
		}

	}
}
