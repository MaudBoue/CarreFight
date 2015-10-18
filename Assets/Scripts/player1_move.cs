using UnityEngine;
using System.Collections;

public class player1_move : MonoBehaviour {

	private Rigidbody2D rigid;
	public float speed = 10;
	public Animation animObj;
	public bool touche = false;







	void Start () {
	rigid = gameObject.GetComponent<Rigidbody2D>();
	}







	void Update () {


 
	}
			
	
	void FixedUpdate(){

	if(Input.GetKey(KeyCode.Q)){
    rigid.AddRelativeForce(new Vector2(-speed,0), ForceMode2D.Force);
			transform.localScale = new Vector3(0.224f,transform.localScale.y,transform.localScale.z);
	}
     if(Input.GetKey(KeyCode.D)){
     rigid.AddRelativeForce(new Vector2(speed,0), ForceMode2D.Force);
			transform.localScale = new Vector3(-0.22f,transform.localScale.y,transform.localScale.z);
	}
	if(Input.GetKeyDown(KeyCode.Z) && touche == true){
    rigid.AddForce(new Vector2(0,speed), ForceMode2D.Impulse);
	}
	 if(Input.GetKey(KeyCode.S)){
     animObj.Play("poing");
	}
	}




	void OnCollisionStay2D(Collision2D other){

	//if (other.gameObject.tag == "Ground") {
    touche = true;
	//}
		/*if (other.gameObject.tag == "Player") {
	
	if ((transform.position.x - other.transform.position.x) >= 1) {
    other.gameObject.GetComponent<Rigidbody2D> ().AddRelativeForce (transform.forward * -speed, ForceMode2D.Impulse);
	}
	if ((transform.position.x - other.transform.position.x) < 1) {
    other.gameObject.GetComponent<Rigidbody2D> ().AddRelativeForce (transform.forward * speed, ForceMode2D.Impulse);
	}
	}*/

	}
	void OnCollisionExit2D(Collision2D other){
	touche = false;
	}


	}

