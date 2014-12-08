using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class jumpScript : MonoBehaviour {



	public float jumpForce=200f; //fuerza para el salto, se puede modificar desde interfaz
	public bool standing;

	public float jumpForce1=200f;


	public float superJump = 2;

	public string menu;

	public AudioClip jumpSound;//Clips de Audio Necesarios.
	public AudioClip deadSound;

	private Animator animator; 

	public float tiempoEspera=2f;//tiempo para reiniciar el nivel

	public Text texto;

	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator> (); 
		texto = GameObject.Find ("Textvidas").GetComponent<Text> ();

		texto.text = GameControl.vidas.ToString();
	}

	
	// Update is called once per frame
	void Update () {



		var absVelY = Mathf.Abs(rigidbody2D.velocity.y); 
		if(absVelY <= .05f){
			standing = true; //si la velocidad en Y es menor que --- se activa la animacion de andar
		}else{
			standing = false;
		}

		if (Input.GetButtonDown ("Jump") && standing && !GameControl.dead) { //Cuando pulsa espacio salta
						saltar ();//mas abajo esta la funcion explicada
				}

		var VelY = (rigidbody2D.velocity.y);
		if (VelY > 0f) {
			animator.SetBool ("salto", true); //cuando la velocidad en el eje Y es mayor que --- se activa la anim. salto
			
		} else {
			animator.SetBool("salto",false);
		}

	}
	void saltar(){ //el objeto se empuja en el eje Y con una fierza = jumpForce

		rigidbody2D.AddForce (new Vector2 (0, jumpForce));
		AudioSource.PlayClipAtPoint(jumpSound,transform.position);

	

	}
	void OnCollisionEnter2D(Collision2D col){ //cuando choca con objeto tag "Enemigo" se activa anim. muerte y se reinicia el nivel

		if (col.gameObject.tag == "Enemigo") {
						animator.SetBool ("muerto", true);
			AudioSource.PlayClipAtPoint(deadSound, transform.position);
						GameControl.vidas = GameControl.vidas - 1;
		


			GameControl.dead=true;
				
			muerteTotal();
			StartCoroutine (restart ());
				}

		}
	void OnTriggerEnter2D(Collider2D target){
		if (target.transform.tag == "SuperJump") {
			jumpForce = jumpForce * superJump;
		}
	}

	void OnTriggerExit2D(Collider2D target){
		if (target.transform.tag == "SuperJump") {
			jumpForce = jumpForce/superJump;
		}
	}

	IEnumerator restart() {
		Debug.Log("Before Waiting 2 seconds");
		yield return new WaitForSeconds(tiempoEspera); // Esperamos el tiempo definido
		GameControl.dead = false;

		Application.LoadLevel (Application.loadedLevel);
	}

	void muerteTotal(){
				if (GameControl.vidas <= 0) {

						GameControl.score = 0;
						GameControl.dead = false;
						GameControl.vidas = 3;

						Application.LoadLevel (menu);
				}
		}



}