using UnityEngine;
using System.Collections;

public class ExtrasVolver : MonoBehaviour {
	public string vuelve;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void volver(){
		
				Application.LoadLevel (vuelve);
		}
}
