using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	public float speed;

	public Rigidbody rb;

	public float jumpPower;

	float distToGround = 0.7f;

	float jumpTime = 0.5f;

	float jumpLimit = 0.5f;

	// Use this for initialization
	void Start () {
	
	}

	// Update is called once per frame
	void Update () {

		Movement ();
	
	}

	public void Movement () {
		if (Input.GetKey ("d")) {
			transform.Translate(Vector2.right * speed * Time.deltaTime);
		}
		else if (Input.GetKey ("a")) {
			transform.Translate(-Vector2.right * speed * Time.deltaTime);   
		}

		if (jumpTime > jumpLimit) {
			if (Input.GetKey ("space")) {
				if (Physics.Raycast (transform.position, -Vector2.up, distToGround + 0.01f) == true) {
					rb.AddForce (Vector2.up * jumpPower);
					jumpTime = 0;
				} 
			}
		} else {
			jumpTime += Time.deltaTime;
		}
	}

	public void OnCollisionEnter (Collision otherObject) {
		if (otherObject.gameObject.tag == "GoombaStomp") {
			rb.AddForce (Vector2.up * jumpPower);
			Destroy (otherObject.gameObject);
		} else if (otherObject.gameObject.tag == "GoombaHurt")
        {
            Destroy(this.gameObject);
        }
	}
}
