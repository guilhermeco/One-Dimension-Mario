using UnityEngine;
using System.Collections;

public class upAndDown : MonoBehaviour {


	float timer;
	float dropSpeed = -0.25f;

	// Use this for initialization
	void Start () {

		timer = 0;
		
	}
	
	// Update is called once per frame
	void Update () {

		timer++;
			
		gameObject.transform.position = transform.position + new Vector3 (0, dropSpeed, 0);
		
		if (timer >= 60) {
			
		    dropSpeed = -dropSpeed;

			timer = 0;
			
		}
    }
}