using UnityEngine;
using System.Collections;

public class movimientoEscenario : MonoBehaviour {

	public int vhorizontal=-3;

	Vector3 movimiento;

	
	// Update is called once per frame
	void Update () {
		if(!GameControl.dead){
						movimiento = new Vector3 (vhorizontal, 0, 0);//Movimiento del escenario Fondo
						transform.Translate (movimiento * Time.deltaTime);
				}
	}
}
