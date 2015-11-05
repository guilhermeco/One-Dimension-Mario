using UnityEngine;
using System.Collections;

public class spawnPanel : MonoBehaviour {

	public GameObject projectile;
	public bool canShoot = false;
	public float timer = 0;
	
	// Use this for initialization
	void Start () {
	}
	
	void Update () {
		Debug.Log("Spawner ONLINE");
		
		timer++;
		
		if (timer >= 90) {
			Debug.Log("Loaded");
			canShoot = true;
		}
		
		if (canShoot == true) {
			Instantiate(projectile, transform.position, transform.rotation);
			canShoot = false;
			Debug.Log("SHOOT");
			timer = 0;
		}
	}
}
