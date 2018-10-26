using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SoalFak : MonoBehaviour {

	public Player player;
	public GameObject panelSoal;
	public Darah darah;
	public Sprite[] SpriteSoal;
	public Image soaltampil;

	public GameObject panelBenar;
	public GameObject panelSalah;

	public float jedaantarsoal;
	public float jedasoal;
	public int kodesoal;
	public bool loadsoal;
	public bool jawabA;
	public bool jawabB;
	public bool jawabC;
	public int kodejawab;
	public bool terjawab;

	void Start(){
		player = FindObjectOfType<Player>();
		darah = FindObjectOfType<Darah>();
		panelSoal.SetActive(false);
		panelBenar.SetActive(false);
		panelSalah.SetActive(false);
		loadsoal = false;
		terjawab = false;
		jawabA = false;
		jawabB = false;
		jawabC = false;
	}

	void Update(){
		if(jawabA){
			kodejawab = 1;
			terjawab = true;
		}
		if(jawabB){
			kodejawab = 2;
			terjawab = true;
		}
		if(jawabC){
			kodejawab = 3;
			terjawab = true;
		}

		if(!loadsoal){
			jedasoal = jedasoal + Time.deltaTime;
		}
		if(jedasoal >= 5){
			kodesoal = Random.Range(0, 39);
			soaltampil.sprite = SpriteSoal[kodesoal];
			panelSoal.SetActive(true);
			jedasoal = 0f;
			loadsoal = true;
		}
		if(loadsoal){
			if(soaltampil.sprite == SpriteSoal[0]){
				if(kodejawab == 2){
					darah.barDarah.fillAmount = darah.barDarah.fillAmount + 0.25f;
					kodejawab = 0;
					terjawab = false;
					panelBenar.SetActive (true);
				}
			}
			if(soaltampil.sprite == SpriteSoal[1]){
				if(kodejawab == 1){
					darah.barDarah.fillAmount = darah.barDarah.fillAmount + 0.25f;
					kodejawab = 0;
					terjawab = false;
					panelBenar.SetActive (true);
				}
			}
			if(soaltampil.sprite == SpriteSoal[2]){
				if(kodejawab == 1){
					darah.barDarah.fillAmount = darah.barDarah.fillAmount + 0.25f;
					kodejawab = 0;
					terjawab = false;
					panelBenar.SetActive (true);
				}
			}
			if(soaltampil.sprite == SpriteSoal[3]){
				if(kodejawab == 3){
					darah.barDarah.fillAmount = darah.barDarah.fillAmount + 0.25f;
					kodejawab = 0;
					terjawab = false;
					panelBenar.SetActive (true);
				}
			}
			if(soaltampil.sprite == SpriteSoal[4]){
				if(kodejawab == 1){
					darah.barDarah.fillAmount = darah.barDarah.fillAmount + 0.25f;
					kodejawab = 0;
					terjawab = false;
					panelBenar.SetActive (true);
				}
			}
			if(soaltampil.sprite == SpriteSoal[5]){
				if(kodejawab == 2){
					darah.barDarah.fillAmount = darah.barDarah.fillAmount + 0.25f;
					kodejawab = 0;
					terjawab = false;
					panelBenar.SetActive (true);
				}
			}
			if(soaltampil.sprite == SpriteSoal[6]){
				if(kodejawab == 3){
					darah.barDarah.fillAmount = darah.barDarah.fillAmount + 0.25f;
					kodejawab = 0;
					terjawab = false;
					panelBenar.SetActive (true);
				}
			}
			if(soaltampil.sprite == SpriteSoal[7]){
				if(kodejawab == 1){
					darah.barDarah.fillAmount = darah.barDarah.fillAmount + 0.25f;
					kodejawab = 0;
					terjawab = false;
					panelBenar.SetActive (true);
				}
			}
			if(soaltampil.sprite == SpriteSoal[8]){
				if(kodejawab == 2){
					darah.barDarah.fillAmount = darah.barDarah.fillAmount + 0.25f;
					kodejawab = 0;
					terjawab = false;
					panelBenar.SetActive (true);
				}
			}
			if(soaltampil.sprite == SpriteSoal[9]){
				if(kodejawab == 3){
					darah.barDarah.fillAmount = darah.barDarah.fillAmount + 0.25f;
					kodejawab = 0;
					terjawab = false;
					panelBenar.SetActive (true);
				}
			}
			if(soaltampil.sprite == SpriteSoal[10]){
				if(kodejawab == 1){
					darah.barDarah.fillAmount = darah.barDarah.fillAmount + 0.25f;
					kodejawab = 0;
					terjawab = false;
					panelBenar.SetActive (true);
				}
			}
			if(soaltampil.sprite == SpriteSoal[11]){
				if(kodejawab == 1){
					darah.barDarah.fillAmount = darah.barDarah.fillAmount + 0.25f;
					kodejawab = 0;
					terjawab = false;
					panelBenar.SetActive (true);
				}
			}
			if(soaltampil.sprite == SpriteSoal[12]){
				if(kodejawab == 2){
					darah.barDarah.fillAmount = darah.barDarah.fillAmount + 0.25f;
					kodejawab = 0;
					terjawab = false;
					panelBenar.SetActive (true);
				}
			}
			if(soaltampil.sprite == SpriteSoal[13]){
				if(kodejawab == 1){
					darah.barDarah.fillAmount = darah.barDarah.fillAmount + 0.25f;
					kodejawab = 0;
					terjawab = false;
					panelBenar.SetActive (true);
				}
			}
			if(soaltampil.sprite == SpriteSoal[14]){
				if(kodejawab == 2){
					darah.barDarah.fillAmount = darah.barDarah.fillAmount + 0.25f;
					kodejawab = 0;
					terjawab = false;
					panelBenar.SetActive (true);
				}
			}
			if(soaltampil.sprite == SpriteSoal[15]){
				if(kodejawab == 3){
					darah.barDarah.fillAmount = darah.barDarah.fillAmount + 0.25f;
					kodejawab = 0;
					terjawab = false;
					panelBenar.SetActive (true);
				}
			}
			if(soaltampil.sprite == SpriteSoal[16]){
				if(kodejawab == 2){
					darah.barDarah.fillAmount = darah.barDarah.fillAmount + 0.25f;
					kodejawab = 0;
					terjawab = false;
					panelBenar.SetActive (true);
				}
			}
			if(soaltampil.sprite == SpriteSoal[17]){
				if(kodejawab == 3){
					darah.barDarah.fillAmount = darah.barDarah.fillAmount + 0.25f;
					kodejawab = 0;
					terjawab = false;
					panelBenar.SetActive (true);
				}
			}
			if(soaltampil.sprite == SpriteSoal[18]){
				if(kodejawab == 2){
					darah.barDarah.fillAmount = darah.barDarah.fillAmount + 0.25f;
					kodejawab = 0;
					terjawab = false;
					panelBenar.SetActive (true);
				}
			}
			if(soaltampil.sprite == SpriteSoal[19]){
				if(kodejawab == 2){
					darah.barDarah.fillAmount = darah.barDarah.fillAmount + 0.25f;
					kodejawab = 0;
					terjawab = false;
					panelBenar.SetActive (true);
				}
			}
			if(soaltampil.sprite == SpriteSoal[20]){
				if(kodejawab == 1){
					darah.barDarah.fillAmount = darah.barDarah.fillAmount + 0.25f;
					kodejawab = 0;
					terjawab = false;
					panelBenar.SetActive (true);
				}
			}
			if(soaltampil.sprite == SpriteSoal[21]){
				if(kodejawab == 3){
					darah.barDarah.fillAmount = darah.barDarah.fillAmount + 0.25f;
					kodejawab = 0;
					terjawab = false;
					panelBenar.SetActive (true);
				}
			}
			if(soaltampil.sprite == SpriteSoal[22]){
				if(kodejawab == 2){
					darah.barDarah.fillAmount = darah.barDarah.fillAmount + 0.25f;
					kodejawab = 0;
					terjawab = false;
					panelBenar.SetActive (true);
				}
			}
			if(soaltampil.sprite == SpriteSoal[23]){
				if(kodejawab == 1){
					darah.barDarah.fillAmount = darah.barDarah.fillAmount + 0.25f;
					kodejawab = 0;
					terjawab = false;
					panelBenar.SetActive (true);
				}
			}
			if(soaltampil.sprite == SpriteSoal[24]){
				if(kodejawab == 3){
					darah.barDarah.fillAmount = darah.barDarah.fillAmount + 0.25f;
					kodejawab = 0;
					terjawab = false;
					panelBenar.SetActive (true);
				}
			}
			if(soaltampil.sprite == SpriteSoal[25]){
				if(kodejawab == 1){
					darah.barDarah.fillAmount = darah.barDarah.fillAmount + 0.25f;
					kodejawab = 0;
					terjawab = false;
					panelBenar.SetActive (true);
				}
			}
			if(soaltampil.sprite == SpriteSoal[26]){
				if(kodejawab == 2){
					darah.barDarah.fillAmount = darah.barDarah.fillAmount + 0.25f;
					kodejawab = 0;
					terjawab = false;
					panelBenar.SetActive (true);
				}
			}
			if(soaltampil.sprite == SpriteSoal[27]){
				if(kodejawab == 1){
					darah.barDarah.fillAmount = darah.barDarah.fillAmount + 0.25f;
					kodejawab = 0;
					terjawab = false;
					panelBenar.SetActive (true);
				}
			}
			if(soaltampil.sprite == SpriteSoal[28]){
				if(kodejawab == 2){
					darah.barDarah.fillAmount = darah.barDarah.fillAmount + 0.25f;
					kodejawab = 0;
					terjawab = false;
					panelBenar.SetActive (true);
				}
			}
			if(soaltampil.sprite == SpriteSoal[29]){
				if(kodejawab == 3){
					darah.barDarah.fillAmount = darah.barDarah.fillAmount + 0.25f;
					kodejawab = 0;
					terjawab = false;
					panelBenar.SetActive (true);
				}
			}
			if(soaltampil.sprite == SpriteSoal[30]){
				if(kodejawab == 2){
					darah.barDarah.fillAmount = darah.barDarah.fillAmount + 0.25f;
					kodejawab = 0;
					terjawab = false;
					panelBenar.SetActive (true);
				}
			}
			if(soaltampil.sprite == SpriteSoal[31]){
				if(kodejawab == 3){
					darah.barDarah.fillAmount = darah.barDarah.fillAmount + 0.25f;
					kodejawab = 0;
					terjawab = false;
					panelBenar.SetActive (true);
				}
			}
			if(soaltampil.sprite == SpriteSoal[32]){
				if(kodejawab == 1){
					darah.barDarah.fillAmount = darah.barDarah.fillAmount + 0.25f;
					kodejawab = 0;
					terjawab = false;
					panelBenar.SetActive (true);
				}
			}
			if(soaltampil.sprite == SpriteSoal[33]){
				if(kodejawab == 1){
					darah.barDarah.fillAmount = darah.barDarah.fillAmount + 0.25f;
					kodejawab = 0;
					terjawab = false;
					panelBenar.SetActive (true);
				}
			}
			if(soaltampil.sprite == SpriteSoal[34]){
				if(kodejawab == 1){
					darah.barDarah.fillAmount = darah.barDarah.fillAmount + 0.25f;
					kodejawab = 0;
					terjawab = false;
					panelBenar.SetActive (true);
				}
			}
			if(soaltampil.sprite == SpriteSoal[35]){
				if(kodejawab == 1){
					darah.barDarah.fillAmount = darah.barDarah.fillAmount + 0.25f;
					kodejawab = 0;
					terjawab = false;
					panelBenar.SetActive (true);
				}
			}
			if(soaltampil.sprite == SpriteSoal[36]){
				if(kodejawab == 1){
					darah.barDarah.fillAmount = darah.barDarah.fillAmount + 0.25f;
					kodejawab = 0;
					terjawab = false;
					panelBenar.SetActive (true);
				}
			}
			if(soaltampil.sprite == SpriteSoal[37]){
				if(kodejawab == 2){
					darah.barDarah.fillAmount = darah.barDarah.fillAmount + 0.25f;
					kodejawab = 0;
					terjawab = false;
					panelBenar.SetActive (true);
				}
			}
			if(soaltampil.sprite == SpriteSoal[38]){
				if(kodejawab == 3){
					darah.barDarah.fillAmount = darah.barDarah.fillAmount + 0.25f;
					kodejawab = 0;
					terjawab = false;
					panelBenar.SetActive (true);
				}
			}
			if(soaltampil.sprite == SpriteSoal[39]){
				if(kodejawab == 2){
					darah.barDarah.fillAmount = darah.barDarah.fillAmount + 0.25f;
					kodejawab = 0;
					terjawab = false;
					panelBenar.SetActive (true);
				}
			}
			if(terjawab){
				panelSalah.SetActive(true);
				kodejawab = 0;
			}

			jedaantarsoal = jedaantarsoal + Time.deltaTime;
		}

		if(jedaantarsoal >= 5){
			panelSoal.SetActive(false);
		}

		if(jedaantarsoal >= 12){
			loadsoal = false;
			terjawab = false;
			jawabA = false;
			jawabB = false;
			jawabC = false;
			panelBenar.SetActive(false);
			panelSalah.SetActive(false);
			jedaantarsoal = 0f;
		}

	}
}
