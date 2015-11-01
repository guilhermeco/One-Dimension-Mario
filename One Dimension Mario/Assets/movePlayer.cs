using UnityEngine;
using System.Collections;

public class movePlayer : MonoBehaviour {

	public float xSpeed = 0.5f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		transform.position = transform.position + new Vector3 (0.2f, 0, 0);

	}
}
