using UnityEngine;
using System.Collections;

public class mobAi : MonoBehaviour {

	//health
	public int mobHealth = 50;

	//target && attack
	public GameObject atkDmg;
	public Transform target;
	public float dir;

	//getting dist
	public Transform mobLoc;
	public float dist;
	public float maxDistance = 2.0f;
	public float movespeed = 2.0f;


	private float Timer = 0;

	// Use this for initialization
	void Start () {
	
		target = GameObject.FindGameObjectWithTag ("Babaylan").GetComponent<Transform>();
		mobLoc = GetComponent<Transform> ();
	}
	
	// Update is called once per frame
	void Update () {

		dist = Vector3.Distance (target.position, mobLoc.position);
		if (Vector3.Distance (target.position, mobLoc.position) > maxDistance) {
			Vector3 dir = target.position - mobLoc.position;
			dir.Normalize();
			mobLoc.position += dir * movespeed * Time.deltaTime;



		}
		if (dist <= maxDistance){
			Timer += 1.0f * Time.deltaTime;
			if (Timer >= 3){
			Atk();
			Debug.Log("atk!");
				Timer = 0;
			}
		}

		if (mobHealth <= 0) {
			Destroy(this.gameObject);
			Debug.Log ("death!");
		
		}



	}

	void Atk (){

		Instantiate (atkDmg, target.position, target.rotation);

	}
}
