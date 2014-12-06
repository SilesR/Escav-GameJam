using UnityEngine;
using System.Collections;

public class jumpScript : MonoBehaviour {

	public int jumpForce=200;
	public bool standing;



	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		var absVelY = Mathf.Abs(rigidbody2D.velocity.y);
		if(absVelY <= .05f){
			standing = true;
		}else{
			standing = false;
		}

		if(Input.GetButtonDown ("Jump")&&standing) //Cuando pulsa espacio salta
			saltar ();//mas abajo esta la funcion explicada
	
	}
	void saltar(){

		rigidbody2D.AddForce (new Vector2 (0, jumpForce));
		}
}
