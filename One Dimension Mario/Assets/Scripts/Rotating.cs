using UnityEngine;
using System.Collections;

public class Rotating : MonoBehaviour {

	float rotationAmount = 15f;
	public float rotationDirection = 1;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		transform.Rotate(Vector3.forward * rotationAmount * Time.deltaTime * rotationDirection);

	}
}
