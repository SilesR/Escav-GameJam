using UnityEngine;
using System.Collections;

public class MenuScript : MonoBehaviour {
	public string nivelcarga;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		if (GameControl.dead) {

		}
		
	}
	
	
	public  void start(){
		GameControl.dead = false;
		GameControl.score = 0;

		Application.LoadLevel(nivelcarga);
	}
	
	public  void quit(){
		
		Application.Quit();
	}
}
