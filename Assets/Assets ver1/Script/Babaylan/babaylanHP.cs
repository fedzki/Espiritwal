using UnityEngine;
using System.Collections;

public class babaylanHP : MonoBehaviour {

	public int HP;
	public int dmg = 10;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		if (HP <= 0) {
			Debug.Log ("death!");
		}
	}

	void OnTriggerEnter (Collider other){

		if (other.tag == "dmg") {
			HP -= dmg;
		}
	}
}
