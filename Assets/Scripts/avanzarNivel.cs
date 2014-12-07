using UnityEngine;
using System.Collections;

public class avanzarNivel : MonoBehaviour {
	public string nextLevel;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnCollisionEnter2D(Collision2D col){
		Application.LoadLevel (nextLevel);
	}
}
