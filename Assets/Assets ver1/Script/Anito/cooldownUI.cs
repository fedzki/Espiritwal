using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class cooldownUI : MonoBehaviour {
	
	public AnitoMovement onCooldown;
	public Image image;

	void Start(){
		onCooldown = GameObject.Find ("proto_anito").GetComponent<AnitoMovement> ();

		image = GetComponent<Image> ();

	}

	// Update is called once per frame
	void Update () {



		if (onCooldown.activated == true) {

			image.fillAmount = Mathf.Lerp (image.fillAmount,1.0f, Time.deltaTime * 1f);


		}
	
	}
}
