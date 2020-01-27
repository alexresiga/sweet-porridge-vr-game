using UnityEngine;
using System.Collections;
using UnityEngine.AI;

public class Mover : MonoBehaviour {

	private Vector3 goal;
	private NavMeshAgent agent;
	public GameObject cameraParent;

	void Start () {
		Cursor.visible = false;

		goal = transform.position;
		agent = GetComponent<NavMeshAgent> ();
	}

	void Update () {
		goal = transform.position 
			+ cameraParent.transform.right * Input.GetAxis ("Horizontal") 
			+ cameraParent.transform.forward * Input.GetAxis ("Vertical");
		
		agent.destination = goal;
	}
}
