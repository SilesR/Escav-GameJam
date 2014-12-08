using UnityEngine;
using System.Collections;

public class Catapulta : MonoBehaviour {

	private Animator animator;


	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator>();

		animator.SetBool ("disparo", false);
	}
	
	// Update is called once per frame
	void Update () {
	}

	void OnTriggerEnter2D(Collider2D col){
		
		animator.SetBool("disparo", true);
		
	}
}
