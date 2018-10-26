using UnityEngine;
using System.Collections;

public class PlatformGenerator : MonoBehaviour {

	public GameObject platform;
	public Transform titikGenerasi;
	public float jarakAntara;
	public float lebarPlatform;

	void Start(){
		//lebarPlatform = platform.GetComponent<PolygonCollider2D>();
	}

	void Update(){
		if(transform.position.x < titikGenerasi.position.x){
			transform.position = new Vector3(transform.position.x + jarakAntara, transform.position.y, transform.position.z);
			Instantiate(platform, transform.position, transform.rotation);
		}
	}
}
