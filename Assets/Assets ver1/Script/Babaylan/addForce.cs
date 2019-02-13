using UnityEngine;
using System.Collections;

public class addForce : MonoBehaviour {





	private float currentKS;
	private randomInst Spd;
	// Use this for initialization
	void Start () {
	
	
		Spd = GameObject.Find ("keys").GetComponent<randomInst> ();
	}
	
	// Update is called once per frame
	void Update () {


		this.GetComponent<Rigidbody>().AddForce(transform.right * Spd.keySpeed);
	}
}
