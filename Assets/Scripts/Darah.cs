using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Darah : MonoBehaviour {

	public Image barDarah;
	public GameObject cam;
	public float jarakTempuh;
	public Player player;
	public bool paused = false;

	void Start(){
		paused = false;
	}

	void Update(){
		jarakTempuh = cam.transform.position.x;

		if(!paused){
			barDarah.fillAmount = barDarah.fillAmount - 0.00023f;
		}

		if(barDarah.fillAmount <= 0){
			player.mati();
		}
	}
}
