using UnityEngine;
using System.Collections;

public class Attack : MonoBehaviour {

	void Update () {
		if (Input.GetButtonDown ("Fire1")) {
			Instantiate (Resources.Load ("Projectile"), transform.position, transform.rotation);
		}
	}
}
