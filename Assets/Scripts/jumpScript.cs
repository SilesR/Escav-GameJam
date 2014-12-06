using UnityEngine;
using System.Collections;

public class jumpScript : MonoBehaviour {

	public int jumpForce=200;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetButtonDown ("Jump")) //Cuando pulsa espacio salta
			saltar ();//mas abajo esta la funcion explicada
	
	}
	void saltar(){

		rigidbody2D.AddForce (new Vector2 (0, jumpForce));
		}
}
