using UnityEngine;
using System.Collections;

public class player2_move : MonoBehaviour {

	private Rigidbody2D rigid;
	public float speed = 10;
	public Animation animObj;
	public bool touche = false;







	void Start () {
	rigid = gameObject.GetComponent<Rigidbody2D>();
	}







	void Update () {


	
	}






	void FixedUpdate()
	{
	if(Input.GetKey(KeyCode.LeftArrow)){
    	rigid.AddRelativeForce(new Vector2(-speed,0), ForceMode2D.Force);
		transform.localScale = new Vector3(0.224f,transform.localScale.y,transform.localScale.z);
		}
    if(Input.GetKey(KeyCode.RightArrow)){
    	rigid.AddRelativeForce(new Vector2(speed,0), ForceMode2D.Force);
		transform.localScale = new Vector3(-0.224f,transform.localScale.y,transform.localScale.z);
		}
	if(Input.GetKeyDown(KeyCode.UpArrow) && touche == true){
    	rigid.AddRelativeForce(new Vector2(0,speed), ForceMode2D.Impulse);
		}

    if(Input.GetKey(KeyCode.DownArrow)){
    	animObj.Play("poing");
		}
	}


	void OnCollisionStay2D(Collision2D other){
	touche = true;
	}

	void OnCollisionExit2D(Collision2D other){
	touche = false;
	}
	}

