using UnityEngine;
using System.Collections;

public class AnitoMovement : MonoBehaviour {

	//movement
	public float movespeed = 10.0f;
	public float rotatespeed = 10.0f;
	public Transform weapRot;

	//attack
	public GameObject weapon;
	public GameObject aDmg;
	public float cooldown;
	public bool atk;
	public float atkTimer;
	public float atkSpd;


	//dash
	public float timer;
	public bool activated = false;
	public GameObject dashIcon;
	public cooldownUI fillAmt;
	// Use this for initialization
	void Start () {
		weapRot = GameObject.Find ("weapon").GetComponent<Transform> ();
		weapon = GameObject.Find ("Sphere");
		dashIcon = GameObject.Find ("dash_cd_group");
		fillAmt = GameObject.Find ("dash_cd").GetComponent<cooldownUI>();
	}
	
	// Update is called once per frame
	void Update () {

		//attack

	

		//start cooldown
		if (activated == true) {
			timer += 1 * Time.deltaTime;
			dashIcon.SetActive(true);

			if(timer >= cooldown){
				activated = false;
				timer = 0.0f;
				fillAmt.image.fillAmount = 0.0f;
				dashIcon.SetActive(false);
			}
		}
		//basic movement
		if (Input.GetKey ("w")) {
			transform.Translate ((Vector3.up) * movespeed * Time.deltaTime);
			weapRot.eulerAngles = new Vector3 (0, 0, 90);
			}
			if (Input.GetKey ("s")) {
			transform.Translate ((Vector3.down) * movespeed * Time.deltaTime);
			weapRot.eulerAngles = new Vector3 (0, 0, 270);
			}
			if (Input.GetKey ("a")) {
			transform.Translate ((Vector3.left) * movespeed * Time.deltaTime);
			weapRot.eulerAngles = new Vector3 (0, 0, 180);
			}
			if (Input.GetKey ("d")) {
			transform.Translate ((Vector3.right) * movespeed * Time.deltaTime);
			weapRot.eulerAngles = new Vector3 (0, 0, 0);
			}
			if (Input.GetKey ("w") && Input.GetKey ("a")) {
			weapRot.eulerAngles = new Vector3 (0,0,135);
			}
			if (Input.GetKey ("w") && Input.GetKey ("d")) {
			weapRot.eulerAngles = new Vector3 (0,0,45);
			}
			if (Input.GetKey ("s") && Input.GetKey ("a")) {
			weapRot.eulerAngles = new Vector3 (0,0,225);
			}
			if (Input.GetKey ("s") && Input.GetKey ("d")) {
			weapRot.eulerAngles = new Vector3 (0,0,315);
			}
			
			//attack
			if (Input.GetKey ("i") && atk == false) {
			Attack();
			atk = true;
			}
			if (atk == true){
			atkTimer += 0.5f * Time.deltaTime;	
				if (atkTimer >= atkSpd){
					atkTimer = 0;
					Debug.Log("false!");
					atk = false;
				}
			}
		//dash
			if (Input.GetKey ("u") && activated == false) {
				//oncooldown
				activated = true;

				//dashes
				if(weapRot.eulerAngles.z >= 0 && weapRot.eulerAngles.z < 45 ){
				transform.Translate(1f,0,0 * movespeed * Time.deltaTime);
				}
				if(weapRot.eulerAngles.z >= 45 && weapRot.eulerAngles.z < 90 ){
				transform.Translate(1f,1f,0 * movespeed * Time.deltaTime);
				}
				if(weapRot.eulerAngles.z >= 90 && weapRot.eulerAngles.z < 135 ){
				transform.Translate(0,1f,0 * movespeed * Time.deltaTime);
				}
				if(weapRot.eulerAngles.z >= 135 && weapRot.eulerAngles.z < 180 ){
				transform.Translate(-1f,1f,0 * movespeed * Time.deltaTime);
				}
				if(weapRot.eulerAngles.z >= 180 && weapRot.eulerAngles.z < 225 ){
				transform.Translate(-1f,0,0 * movespeed * Time.deltaTime);
				}
				if(weapRot.eulerAngles.z >= 225 && weapRot.eulerAngles.z < 270 ){
				transform.Translate(-1f,-1f,0 * movespeed * Time.deltaTime);
				}
				if(weapRot.eulerAngles.z >= 270 && weapRot.eulerAngles.z < 315 ){
				transform.Translate(0,-1f,0 * movespeed * Time.deltaTime);
				}
				if(weapRot.eulerAngles.z >= 315 && weapRot.eulerAngles.z < 360 ){
				transform.Translate(1f,-1f,0 * 1f * Time.deltaTime);
				}
			}

			//advance movement
		}
	void Attack(){

		Instantiate (aDmg, weapon.transform.position, weapon.transform.rotation);
		
	}


}

