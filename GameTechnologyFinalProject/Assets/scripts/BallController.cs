using UnityEngine;
using System.Collections;

public class BallController : MonoBehaviour {

	// Use this for initialization
	public Rigidbody rb;
	private int doubleJump = 0;
	void Start () {
//		rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
		
		Vector3 position = this.transform.position;
		position.z = 0.0f;
		/* TODO */
		/* transformation not real */
		if (Input.GetKey(KeyCode.LeftArrow)) {
			rb.AddForce(Vector3.left/20, ForceMode.Impulse);
			position.x -= 0.08f;
		}
		
		if (Input.GetKey(KeyCode.RightArrow)) {
			rb.AddForce(Vector3.right/20, ForceMode.Impulse);
			position.x += 0.08f;
		}
		transform.position = position;
		this.transform.position = position;
		if (Input.GetKeyDown(KeyCode.UpArrow)) {
			if (doubleJump < 2) {
				doubleJump++;
				rb.AddForce(Vector3.up * 5, ForceMode.Impulse);
			}
			
		}
	}
	
	void OnTriggerEnter(Collider collide) {
		//if (collide.CompareTag("ground")) {
			doubleJump = 0;
		//}
	}

}
