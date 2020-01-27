using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Collection : MonoBehaviour {

	public int gold;
	private bool hasKey;
	public Text goldCount;
	public Text keysCount;	

	void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Coin") {
			gold++;
			goldCount.text = "Porridge: " + gold;
			Instantiate (Resources.Load ("PickupEffect"), other.transform.position, Quaternion.Euler(90, 0 , 0));
			Destroy (other.gameObject);
		}

		if (other.tag == "Key") {
			hasKey = true;
			keysCount.text = "Keys: 1";
			Instantiate (Resources.Load ("PickupEffect"), other.transform.position, Quaternion.Euler (90, 0, 0));
			Destroy (other.gameObject);
		}

		if (other.tag == "Chest") {
			if (hasKey) {
				gold += 10;
				goldCount.text = "Porridge: " + gold;
				keysCount.text = "Keys: 0";
				Instantiate (Resources.Load ("PickupEffect"), other.transform.position, Quaternion.Euler (90, 0, 0));
				Destroy (other.gameObject);
				hasKey = false;
			}
		}
	}
}
