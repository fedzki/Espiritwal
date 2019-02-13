using UnityEngine;
using System.Collections;

public class atkDestroy : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Destroy (this.gameObject, 0.25f);


	}

	void OnTriggerEnter(Collider other){

		if (other.tag == "enemy") {

			Destroy(other.gameObject);
			Debug.Log("Destroy!");

		
		}

	}
}
