using UnityEngine;
using System.Collections;

public class playerControl : MonoBehaviour
{

	float xSpeed;
	float speed = 10;
	float colorChangeSpeed = 1f;
	bool colorChanged = false;
	public string bckColor;


	// Use this for initialization
	void Start ()
	{	

	}
	
	// Update is called once per frame
	void Update ()
	{

		xSpeed = Input.GetAxis ("Horizontal") * speed * Time.deltaTime;

		transform.Translate (Vector3.right * xSpeed);

		//Debug.Log(bckColor);
		//Debug.Log(gameObject.tag);


		if (colorChanged == false) {

			if (Input.GetKey (KeyCode.Q)) {
				
				GetComponent<Renderer> ().material.color = Color.cyan;
				colorChanged = true;
				
				Invoke ("allowColorChanging", colorChangeSpeed);

				gameObject.tag = "Cyan";
			}


			if (Input.GetKey (KeyCode.W)) {
				
				GetComponent<Renderer> ().material.color = Color.blue;
				colorChanged = true;

				Invoke ("allowColorChanging", colorChangeSpeed);

				gameObject.tag = "Blue";
			}


			if (Input.GetKey (KeyCode.E)) {
				
				GetComponent<Renderer> ().material.color = Color.magenta;
				colorChanged = true;
				
				Invoke ("allowColorChanging", colorChangeSpeed);

				gameObject.tag = "Magenta";
			}


			if (Input.GetKey (KeyCode.R)) {

				GetComponent<Renderer> ().material.color = Color.red;
				colorChanged = true;

				Invoke ("allowColorChanging", colorChangeSpeed);

				gameObject.tag = "Red";
			}

		}

		RaycastHit rayColor;

		if (Physics.Raycast (transform.position, transform.forward, out rayColor)) {

			bckColor = rayColor.collider.tag;

		}

	}

	void allowColorChanging ()
	{
		
		colorChanged = false;
		
	}

	void OnDrawGizmos ()
	{

		Gizmos.DrawRay (transform.position, new Vector3 (0, 0, 2));

	}

}
