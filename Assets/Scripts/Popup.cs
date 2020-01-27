using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Popup : MonoBehaviour {

	// public GameObject LosePopup;
	// public GameObject WinPopup;
	// public Text FinalGold;

	void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Goal") {
			Debug.Log("final");
			if (GetComponent<Collection> ().gold >= 10) {
				for (int i = 0; i < 3; ++i)
					Instantiate (Resources.Load ("FinalEffect"), other.transform.position, Quaternion.identity);
				float start = -30f;
				for (int i = 0; i < 60; i += 5)
					Instantiate (Resources.Load ("FinalEffect"), new Vector3((float) start - i, 3.907258f, -38.11912f), Quaternion.identity);
			}
			
			// WinPopup.SetActive (true);
			// Cursor.visible = true;
			// FinalGold.text = "You collected " +
			// GetComponent<Collection> ().gold +
			// " gold!";
			// Time.timeScale = 0;
		}
	}
}
