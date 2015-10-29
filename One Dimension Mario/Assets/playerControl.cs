using UnityEngine;
using System.Collections;

public class playerControl : MonoBehaviour {

	float xSpeed;
	float speed = 10;
	float colorChangeSpeed = 4f;

	bool colorChanged = false;

	public string bckColor;


	// Use this for initialization
	void Start () {	

	}
	
	// Update is called once per frame
	void Update () {

		xSpeed = Input.GetAxis("Horizontal") * speed * Time.deltaTime;

		transform.Translate (Vector3.right * xSpeed);

		//Debug.Log(bckColor);
		//Debug.Log(gameObject.tag);


		if(colorChanged == false){

			if(Input.GetKey(KeyCode.Q)){
				
				GetComponent<Renderer>().material.color = Color.cyan;
				colorChanged = true;
				
<<<<<<< HEAD
				Invoke ("allowColorChanging", colorChangeSpeed);
				
=======
				Invoke ("allowColorChanging", 4f);

				gameObject.tag = "Cyan";
>>>>>>> e5abfdd0a918d95d4a7f75f00c99027c3c0bad74
			}


			if(Input.GetKey(KeyCode.W)){
				
				GetComponent<Renderer>().material.color = Color.blue;
				colorChanged = true;
<<<<<<< HEAD
				
				Invoke ("allowColorChanging", colorChangeSpeed);
				
=======

				Invoke ("allowColorChanging", 4f);

				gameObject.tag = "Blue";
>>>>>>> e5abfdd0a918d95d4a7f75f00c99027c3c0bad74
			}


			if(Input.GetKey(KeyCode.E)){
				
				GetComponent<Renderer>().material.color = Color.magenta;
				colorChanged = true;
				
<<<<<<< HEAD
				Invoke ("allowColorChanging", colorChangeSpeed);
				
=======
				Invoke ("allowColorChanging", 4f);

				gameObject.tag = "Magenta";
>>>>>>> e5abfdd0a918d95d4a7f75f00c99027c3c0bad74
			}


			if(Input.GetKey(KeyCode.R)){

			    GetComponent<Renderer>().material.color = Color.red;
			    colorChanged = true;

<<<<<<< HEAD
			Invoke ("allowColorChanging", colorChangeSpeed);
=======
			    Invoke ("allowColorChanging", 4f);
>>>>>>> e5abfdd0a918d95d4a7f75f00c99027c3c0bad74

				gameObject.tag = "Red";
			}

		}

		RaycastHit rayColor;

		if (Physics.Raycast (transform.position, transform.forward, out rayColor)) {

			bckColor = rayColor.collider.tag;

		}

	}

	void allowColorChanging(){
		
		colorChanged = false;
		
	}

	void OnDrawGizmos (){

		Gizmos.DrawRay (transform.position, new Vector3 (0, 0, 2));

	}

}
