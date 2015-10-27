using UnityEngine;
using System.Collections;

public class playerControl : MonoBehaviour {

	float xSpeed;
	float speed = 10;

	bool colorChanged = false;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		xSpeed = Input.GetAxis("Horizontal") * speed * Time.deltaTime;

	
		transform.Translate (Vector3.right * xSpeed);


		if(colorChanged == false && Input.GetKey(KeyCode.R)){

			GetComponent<Material>().color = Color.red;
			colorChanged = true;

			Invoke ("allowColorChanging", 4f);

		}

	}

	void allowColorChanging(){

		colorChanged = false;

	}
}
