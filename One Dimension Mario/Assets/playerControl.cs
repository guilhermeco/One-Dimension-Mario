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


		if(colorChanged == false){

			if(Input.GetKey(KeyCode.Q)){
				
				GetComponent<Renderer>().material.color = Color.cyan;
				colorChanged = true;
				
				Invoke ("allowColorChanging", 4f);
				
			}


			if(Input.GetKey(KeyCode.W)){
				
				GetComponent<Renderer>().material.color = Color.blue;
				colorChanged = true;
				
				Invoke ("allowColorChanging", 4f);
				
			}


			if(Input.GetKey(KeyCode.E)){
				
				GetComponent<Renderer>().material.color = Color.magenta;
				colorChanged = true;
				
				Invoke ("allowColorChanging", 4f);
				
			}


			if(Input.GetKey(KeyCode.R)){

			GetComponent<Renderer>().material.color = Color.red;
			colorChanged = true;

			Invoke ("allowColorChanging", 4f);

			}

		}

	}
	void allowColorChanging(){
		
		colorChanged = false;
		
	}
}
