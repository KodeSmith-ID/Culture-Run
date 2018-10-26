using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour {

	public GameObject pause;
	public bool pauseUI = false;
	private BelakangTanah bg;
	private Awan awan;
	private Darah darah;
	public Text highscore;
	public Text score;
	public GameObject mati;
	private Skor skor;
	public bool statusmati = false;
	public GameObject caramain;
	public bool gameMulai = false;

	void Start(){
		pause.SetActive(false);
		mati.SetActive(false);
		caramain.SetActive(true);
		pauseUI = false;
		statusmati = false;
		gameMulai = false;
		bg = FindObjectOfType<BelakangTanah>();
		awan = FindObjectOfType<Awan>();
		darah = FindObjectOfType<Darah>();
		skor = FindObjectOfType<Skor>();
		highscore.text = "" + Mathf.Round(PlayerPrefs.GetFloat("Highscore"));
	}

	void Update(){
		if(Input.GetButtonDown("Cancel")){
			pauseUI = !pauseUI;
		}

		if(pauseUI || statusmati || !gameMulai){
			if(!gameMulai){
				Time.timeScale = 0;
				bg.paused = true;
				awan.paused = true;
				darah.paused = true;
				if(Input.GetButtonDown("Jump")){
					gameMulai = true;
					caramain.SetActive(false);
				}
			}
			if(statusmati){
				pauseUI = false;
			}
			if(pauseUI){
				pause.SetActive(true);
				Time.timeScale = 0;
				bg.paused = true;
				awan.paused = true;
				darah.paused = true;
			}
			else{
				if(statusmati){
					pause.SetActive(false);
					mati.SetActive(true);
					Time.timeScale = 0;
					bg.paused = true;
					awan.paused = true;
					darah.paused = true;
					SkorAkhir();
				}
			}
		}
		else{
			pause.SetActive(false);
			Time.timeScale = 1;
			bg.paused = false;
			awan.paused = false;
			darah.paused = false;
		}
	}

	public void Restart(){
		SceneManager.LoadScene("main_scene");
	}

	public void Resume(){
		pauseUI = false;
	}

	public void Close(){
		SceneManager.LoadScene("Main_Menu");
	}

	public void Pause(){
		pauseUI = true;
	}

	public void Mainkan(){
		gameMulai = true;
		caramain.SetActive(false);
	}

	public void SkorAkhir(){
		highscore.text = "" + Mathf.Round(PlayerPrefs.GetFloat("Highscore"));
		score.text = "" + Mathf.Round(skor.hitunganSkor);
	}
}