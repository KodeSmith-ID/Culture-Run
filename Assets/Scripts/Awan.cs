using UnityEngine;
using System.Collections;

public class Awan : MonoBehaviour {

	public CameraNgilu cam;
	public float mundur;
	public float kamera;
	public float jarakKamera;
	public float i;
	public int bg;
	public bool paused = false;
	private GameObject awanA;
	private GameObject awanB;
	private GameObject awanC;
	private GameObject awanD;

	void Start(){
		cam = gameObject.GetComponentInParent<CameraNgilu>();
		paused = false;
		awanA = GameObject.Find("awan1");
		awanB = GameObject.Find("awan2");
		awanC = GameObject.Find("awan3");
		awanD = GameObject.Find("awan4");
		kamera = cam.transform.position.x;
		mundur = 0f;
		jarakKamera = 0f;
		i = 0.005f;
		bg = 0;
	}

	void Update(){
		if(paused){
			awanA.transform.position = new Vector3(awanA.transform.position.x, awanA.transform.position.y, awanA.transform.position.z);
			awanB.transform.position = new Vector3(awanB.transform.position.x, awanB.transform.position.y, awanB.transform.position.z);
			awanC.transform.position = new Vector3(awanC.transform.position.x, awanC.transform.position.y, awanC.transform.position.z);
			awanD.transform.position = new Vector3(awanD.transform.position.x, awanD.transform.position.y, awanD.transform.position.z);
		}
		if(!paused){
			if(bg == 0){
				kamera = cam.transform.position.x;
				jarakKamera = kamera - mundur - i;
				mundur = mundur - 0.02f + kamera;
				if(mundur > kamera){
					mundur = mundur - kamera + jarakKamera;
					i = i + 0.02f;
				}
				awanA.transform.position = new Vector3(mundur, awanA.transform.position.y, awanA.transform.position.z);
				awanB.transform.position = new Vector3(mundur + 15f, awanB.transform.position.y, awanB.transform.position.z);
				if(i > 32f){
					bg = 1;
					i = 0.02f - 17f;
					mundur = mundur - 17f;
				}
			}
			if(bg == 1){
				kamera = cam.transform.position.x;
				jarakKamera = kamera - mundur - i;
				mundur = mundur - 0.02f + kamera;
				if(mundur > kamera){
					mundur = mundur - kamera + jarakKamera;
					i = i + 0.02f;
				}
				awanC.transform.position = new Vector3(mundur, awanC.transform.position.y, awanC.transform.position.z);
				awanD.transform.position = new Vector3(mundur + 15f, awanD.transform.position.y, awanD.transform.position.z);
				if(i > 32f){
					bg = 2;
					i = 0.02f - 17f;
					mundur = mundur - 17f;
				}
			}
			if(bg == 2){
				kamera = cam.transform.position.x;
				jarakKamera = kamera - mundur - i;
				mundur = mundur - 0.02f + kamera;
				if(mundur > kamera){
					mundur = mundur - kamera + jarakKamera;
					i = i + 0.02f;
				}
				awanA.transform.position = new Vector3(mundur, awanA.transform.position.y, awanA.transform.position.z);
				awanB.transform.position = new Vector3(mundur + 15f, awanB.transform.position.y, awanB.transform.position.z);
				if(i > 32f){
					bg = 1;
					i = 0.02f - 17f;
					mundur = mundur - 17f;
				}
			}
		}
	}
}
