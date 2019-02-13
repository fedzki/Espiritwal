using UnityEngine;
using System.Collections;

public class summonLS : MonoBehaviour {



	public float lifeSpan = 15.0f;
	public int Combo = 0;

	private randomInst Inter;
	private addForce Spd;

	// Use this for initialization
	void Start () {
		Inter = GameObject.Find ("keys").GetComponent<randomInst> ();

	}
	
	// Update is called once per frame
	void Update () {

		lifeSpan -= 0.5f * Time.deltaTime;


		if (lifeSpan <= 0) {
		
			Debug.Log ("death");
		
		}
	
	}

	void OnTriggerEnter(Collider other)
	{
			Inter.keySpeed = 2.0f;
			Inter.interval = 2.5f;
			Combo = 0;
			lifeSpan -= 5.0f;
			Destroy (other.gameObject);
			Debug.Log ("collide");
	
	}
	
}

