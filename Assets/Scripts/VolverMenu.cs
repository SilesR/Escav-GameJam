using UnityEngine;
using System.Collections;

public class VolverMenu : MonoBehaviour {

	public string menuse;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void volverMenu(){

		Application.LoadLevel (menuse);
	}

}
