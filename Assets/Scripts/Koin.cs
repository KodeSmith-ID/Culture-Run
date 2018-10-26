using UnityEngine;
using System.Collections;

public class Koin : MonoBehaviour {

	public GameObject cam;
	public Player player;
	public SoalFak soalfak;

	public LayerMask layerkoinA;
	public LayerMask layerkoinB;
	public LayerMask layerkoinC;
	public Transform cekKoin;
	public float cekRadiusKoin;

	public GameObject jawabA;
	public GameObject jawabB;
	public GameObject jawabC;
	public float jedaantarjawab;
	public float jedajawab;
	public int jawab;
	public bool loadjawab;

	private AudioSource soraKoin;

	void Start(){
		player = FindObjectOfType<Player>();
		soalfak = FindObjectOfType<SoalFak>();
		soraKoin = GameObject.Find ("sorakoin").GetComponent<AudioSource>();
		loadjawab = false;
	}

	void Update(){
		soalfak.jawabA = Physics2D.OverlapCircle(cekKoin.position, cekRadiusKoin, layerkoinA);
		if(soalfak.jawabA){
			//soalfak.jawabA = true;
			soraKoin.Play();
			jawabA.transform.position = new Vector2(-10, jawabA.transform.position.y);
			jawabB.transform.position = new Vector2(-10, jawabB.transform.position.y);
			jawabC.transform.position = new Vector2(-10, jawabC.transform.position.y);
		}

		soalfak.jawabB = Physics2D.OverlapCircle(cekKoin.position, cekRadiusKoin, layerkoinB);
		if(soalfak.jawabB){
			soraKoin.Play();
			jawabA.transform.position = new Vector2(-10, jawabA.transform.position.y);
			jawabB.transform.position = new Vector2(-10, jawabB.transform.position.y);
			jawabC.transform.position = new Vector2(-10, jawabC.transform.position.y);
		}

		soalfak.jawabC = Physics2D.OverlapCircle(cekKoin.position, cekRadiusKoin, layerkoinC);
		if(soalfak.jawabC){
			soraKoin.Play();
			jawabA.transform.position = new Vector2(-10, jawabA.transform.position.y);
			jawabB.transform.position = new Vector2(-10, jawabB.transform.position.y);
			jawabC.transform.position = new Vector2(-10, jawabC.transform.position.y);
		}

		if(!loadjawab){
			jedajawab = jedajawab + Time.deltaTime;
		}
		if(jedajawab >= 5){
			jawabA.transform.position = new Vector2((player.speed * 5) + cam.transform.position.x, jawabA.transform.position.y);
			jawabB.transform.position = new Vector2((player.speed * 5) + cam.transform.position.x + (player.speed * 2), jawabB.transform.position.y);
			jawabC.transform.position = new Vector2((player.speed * 5) + cam.transform.position.x + (player.speed * 4), jawabC.transform.position.y);
			jedajawab = 0f;
			loadjawab = true;
		}
		if(loadjawab){
			jedaantarjawab = jedaantarjawab + Time.deltaTime;
		}
		if(jedaantarjawab >= 12){
			loadjawab = false;
			jedaantarjawab = 0f;
		}
	}
}
