using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

	public GameObject play;
	public Text hiSkor;

	void Start(){
		play.SetActive(true);
		hiSkor.text = "" + Mathf.Round(PlayerPrefs.GetFloat("Highscore"));
	}

	void Update(){
		/*if(Input.GetButtonDown("Jump")){
			SceneManager.LoadScene("main_scene");
		}*/
	}

	public void Play(){
		SceneManager.LoadScene("main_scene");
	}

	public void Close(){
		Application.Quit();
	}
}
