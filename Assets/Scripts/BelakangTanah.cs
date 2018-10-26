using UnityEngine;
using System.Collections;

public class BelakangTanah : MonoBehaviour {

	public CameraNgilu cam;
	public float mundur;
	public float kamera;
	public float jarakKamera;
	public float i;
	public int bg;
	public bool paused = false;
	private GameObject gedungSate;
	private GameObject pasupati;

	void Start(){
		cam = gameObject.GetComponentInParent<CameraNgilu>();
		paused = false;
		gedungSate = GameObject.Find("gedung_sate");
		pasupati = GameObject.Find("pasupati");
		kamera = cam.transform.position.x;
		mundur = 0f;
		jarakKamera = 0f;
		i = 0.03f;
		bg = 0;
	}

	void Update(){
		if(paused){
			gedungSate.transform.position = new Vector3(gedungSate.transform.position.x, gedungSate.transform.position.y, gedungSate.transform.position.z);
			pasupati.transform.position = new Vector3(pasupati.transform.position.x, pasupati.transform.position.y, pasupati.transform.position.z);
		}
		if(!paused){
			if(bg == 0){
				kamera = cam.transform.position.x;
				jarakKamera = kamera - mundur - i;
				mundur = mundur - 0.03f + kamera;
				if(mundur > kamera){
					mundur = mundur - kamera + jarakKamera;
					i = i + 0.03f;
				}
				gedungSate.transform.position = new Vector3(mundur, gedungSate.transform.position.y, gedungSate.transform.position.z);
				if(i > 20f){
					bg = 1;
					i = 0.03f - 30f;
					mundur = mundur - 30f;
				}
			}
			if(bg == 1){
				kamera = cam.transform.position.x;
				jarakKamera = kamera - mundur - i;
				mundur = mundur - 0.03f + kamera;
				if(mundur > kamera){
					mundur = mundur - kamera + jarakKamera;
					i = i + 0.03f;
				}
				pasupati.transform.position = new Vector3(mundur, pasupati.transform.position.y, pasupati.transform.position.z);
				if(i > 30f){
					bg = 2;
					i = 0.03f - 20f;
					mundur = mundur - 20f;
				}
			}
			if(bg == 2){
				kamera = cam.transform.position.x;
				jarakKamera = kamera - mundur - i;
				mundur = mundur - 0.03f + kamera;
				if(mundur > kamera){
					mundur = mundur - kamera + jarakKamera;
					i = i + 0.03f;
				}
				gedungSate.transform.position = new Vector3(mundur, gedungSate.transform.position.y, gedungSate.transform.position.z);
				if(i > 20f){
					bg = 1;
					i = 0.03f - 30f;
					mundur = mundur - 30f;
				}
			}
		}
	}

}
