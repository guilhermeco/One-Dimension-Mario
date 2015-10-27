using UnityEngine;
using System.Collections;

public class boxColor : MonoBehaviour {

	public float speed = 0.2f;

	public bool goUp = true;
	
	public bool goDown = true;

	
	// Use this for initialization
	void Start () {

		gameObject.GetComponent<Renderer> ().material.color = Color.white;

	}
	
	// Update is called once per frame
	void Update () {

		Debug.Log ("can it go down" + goDown);

		RaycastHit posHit;

		if (Physics.Raycast (transform.position + new Vector3 (0, .05f, 0),
		new Vector3 (.99f, 1f, .99f), out posHit)) {

			if(posHit.collider.tag == "Wall") {

				if(gameObject.GetComponent<Renderer> ().material.color == Color.blue) {

				goUp = false;
				goDown = true;
				gameObject.GetComponent<Renderer> ().material.color = Color.white;

				}
			}
		}

	    if (Physics.Raycast (transform.position + new Vector3 (0, -1.563f, 0),
		new Vector3 (.99f, 1f, .99f), out posHit)) {

			if(posHit.collider.tag == "Wall") {

				if(gameObject.GetComponent<Renderer> ().material.color == Color.red) {

				Debug.Log("cant go down");
				goDown = false;
				goUp = true;
				gameObject.GetComponent<Renderer> ().material.color = Color.white;

				}
			}
		}

		if (gameObject.GetComponent<Renderer> ().material.color == Color.blue) {
			gameObject.transform.position = transform.position + new Vector3 (0, speed, 0);
			Debug.Log("BLUE");
		}

		if (gameObject.GetComponent<Renderer> ().material.color == Color.red) {
			gameObject.transform.position = transform.position + new Vector3 (0, -speed, 0);
			Debug.Log ("RED");
		}

		if (gameObject.GetComponent<Renderer> ().material.color == Color.white) {
			gameObject.transform.position = transform.position;
			Debug.Log ("WHITE");
		}
	}

	void OnDrawGizmos () {
	

		Gizmos.DrawCube 
			(transform.position + new Vector3(0, .05f, 0),
			new Vector3(.99f, 1f, .99f));

				

		Gizmos.DrawCube 
			(transform.position + new Vector3 (0, -.05f, 0),
			 new Vector3 (.99f, 1f, .99f));		
				
	}
}
