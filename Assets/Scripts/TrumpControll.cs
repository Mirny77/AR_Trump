using UnityStandardAssets.CrossPlatformInput;
using UnityEngine;

public class TrumpControll : MonoBehaviour {
	private Animation anim;
	private Rigidbody tr;
	private float speed = 4f;

	// Use this for initialization
	void Start () {
		tr = GetComponent<Rigidbody>();
		anim = GetComponent <Animation>();
		
	}
	
	// Update is called once per frame
	void Update () {
		float x = CrossPlatformInputManager.GetAxis("Horizontal");
		float y = CrossPlatformInputManager.GetAxis("Vertical");

		Vector3 mov= new Vector3(x,0,y); 

		tr.velocity = mov * speed;

		if(x !=0 && y!=0){
			transform.eulerAngles = new Vector3(transform.eulerAngles.x,Mathf.Atan2(x,y) * Mathf.Rad2Deg ,transform.eulerAngles.z);
		}
		if(x !=0 && y!=0){
			anim.Play("woll");
		}
		else{
			anim.Play("Idle");
		}

		
	}
}
