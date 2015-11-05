using UnityEngine;
using System.Collections;

public class moveDown : MonoBehaviour {
	
	float dropSpeed = 0.25f;
	public float timer = 0;
	
	// Use this for initialization
	void Start () {

		
	}
	
	// Update is called once per frame
	void Update () {

		timer++;

		if (timer >= 150) {

			Destroy(gameObject);

		}

		gameObject.transform.position = transform.position + new Vector3 (dropSpeed, 0, 0);

	}
}
