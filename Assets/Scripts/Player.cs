using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour {

	//floats
	public float speed;
	public float pengaliSpeed;
	public float speedIncreaseMilestone;
	public float speedMilestoneCount;

	public float jumpPower;
	public float downPower;

	//booleans
	public bool grounded;
	public float waktuRoll;
	public bool roll;
	public bool Jump;
	public bool doubleJump;
	public bool GameJalan;

	//references
	public Rigidbody2D bodi;
	public BoxCollider2D cold;
	public BoxCollider2D cold2;
	private Animator tor;
	private AudioSource soraBGM;
	private AudioSource soraNgajol;
	private AudioSource soraRoll;
	//private AudioSource soraMati;
	private PauseMenu pausemenu;

	void Start(){
		GameJalan = true;
		bodi = gameObject.GetComponent<Rigidbody2D>();
		tor = gameObject.GetComponent<Animator>();
		cold = gameObject.GetComponent<BoxCollider2D>();
		soraBGM = GameObject.Find ("bgm").GetComponent<AudioSource>();
		soraNgajol = GameObject.Find ("jump").GetComponent<AudioSource>();
		soraRoll = GameObject.Find ("roll").GetComponent<AudioSource>();
		//soraMati = GameObject.Find ("mati").GetComponent<AudioSource>();
		pausemenu = FindObjectOfType<PauseMenu>();
		soraBGM.Play();
		speed = 5f;
		jumpPower = 6.5f;
		downPower = 10f;
		speedMilestoneCount = speedIncreaseMilestone;
	}

	void Update(){
		if(GameJalan && !pausemenu.pauseUI){
			tor.SetBool("grounded", grounded);
			tor.SetBool("roll", roll);
			tor.SetBool("jump", Jump);
			tor.SetFloat("waktuRoll", waktuRoll);
			tor.SetFloat("speed", Mathf.Abs(bodi.velocity.x));

			if(transform.position.x > speedMilestoneCount){
				speedMilestoneCount += speedIncreaseMilestone;
				speedIncreaseMilestone = speedIncreaseMilestone * pengaliSpeed;
				speed = speed * pengaliSpeed;
			}

			bodi.velocity = new Vector2(speed, bodi.velocity.y);

			if(grounded){
				Jump = false;
				if(Input.GetButton("Down")){
					soraRoll.Play();
					Jump = false;
					doubleJump = false;
					roll = true;
					grounded = false;
					bodi.velocity = new Vector2(bodi.velocity.x, -downPower);
					cold.offset = new Vector2(-0.124012f, -0.03089869f);
					cold.size = new Vector2(1.28321f, 1.244637f);
				}
			}

			if(Input.GetButtonDown("Up") || Input.GetButtonDown("Jump")){
				if(grounded){
					transform.position = new Vector2(transform.position.x, -1.55f);
					bodi.velocity = new Vector2(bodi.velocity.x, jumpPower);
					Jump = true;
					roll = false;
					//doubleJump = true;
					soraNgajol.Play();
				}
				/*else{
					if(doubleJump){
						roll = false;
						Jump = true;
						doubleJump = false;
						soraNgajol.Play();
						bodi.velocity = new Vector2(bodi.velocity.x, jumpPower);
					}
				}*/
			}

			if(roll){
				waktuRoll = waktuRoll + Time.deltaTime;
			}
			if(!roll){
				waktuRoll = 0f;
				cold.offset = new Vector2(cold2.offset.x, cold2.offset.y);
				cold.size = new Vector2(cold2.size.x, cold2.size.y);
			}
			if(waktuRoll >= 0.5f){
				roll = false;
				waktuRoll = 0f;
			}

			//amun ngahandapan platform
			//if(bodi.transform.position.y < -2.1532f){
			//	bodi.velocity = new Vector2(bodi.velocity.x, -2.1532f);
			//}
		}
	}

	public void mati(){
		GameJalan = false;
		soraBGM.Stop();
		pausemenu.statusmati = true;
	}
}
