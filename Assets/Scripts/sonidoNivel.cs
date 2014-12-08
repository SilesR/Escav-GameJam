using UnityEngine;
using System.Collections;

public class sonidoNivel : MonoBehaviour {

	public AudioClip nivelTrans;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerEnter2D(Collider2D target){

		AudioSource.PlayClipAtPoint(nivelTrans,transform.position);


		}
}
