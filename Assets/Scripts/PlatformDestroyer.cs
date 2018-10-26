using UnityEngine;
using System.Collections;

public class PlatformDestroyer : MonoBehaviour {

	public GameObject platformHancur;

	void Start(){
		platformHancur = GameObject.Find("titik_penghancur_platform");
	}

	void Update(){
		if(transform.position.x < platformHancur.transform.position.x){
			Destroy(gameObject);
		}
	}
}
