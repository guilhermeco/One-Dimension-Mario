using UnityEngine;
using System.Collections;

public class dropSpikes : MonoBehaviour {
	
	bool canDrop = false;
	public float dropY;
    float dropSpeed = -0.25f;
	public float posY;

	// Use this for initialization
	void Start () {
	
		dropY = transform.position.y - 15;

	}

	// Update is called once per frame
	void Update () {

		posY = transform.position.y;

		if(canDrop == true){
			
			gameObject.transform.position = transform.position + new Vector3 (0, dropSpeed, 0);

			Debug.Log("DROP THE BASS");
			
		}

		if(posY < dropY) {

			gameObject.transform.position = transform.position + new Vector3 (0, 15, 0);

			Debug.Log("I SET ONE CARD");

			canDrop = false;

		}

	}

	void OnTriggerEnter (Collider col) {

		if (col.gameObject.name == "Player") {

			canDrop = true;

			Debug.Log("I ACTIVATE MY TRAP CARD");

		}
	}
}
