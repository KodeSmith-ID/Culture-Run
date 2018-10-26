using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Skor : MonoBehaviour {

	public Player player;
	public Text skor;
	public float hitunganSkor;
	public float highSkor;

	void Start(){
		if(PlayerPrefs.HasKey("Highscore")){
			highSkor = PlayerPrefs.GetFloat("Highscore");
		}
		//PlayerPrefs.SetFloat("Highscore", 0);
	}

	void Update(){
		hitunganSkor = hitunganSkor + Time.deltaTime * 10;
		skor.text = "" + Mathf.Round(hitunganSkor);
		if(hitunganSkor > highSkor){
			highSkor = hitunganSkor;
			PlayerPrefs.SetFloat("Highscore", highSkor);
		}
	}
}
