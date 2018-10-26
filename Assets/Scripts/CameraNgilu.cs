using UnityEngine;
using System.Collections;

public class CameraNgilu : MonoBehaviour {

	public Player player;

	private Vector3 posisiTerakhirPlayer;
	private float distanceToMove;

	void Start(){
		player = FindObjectOfType<Player>();
		posisiTerakhirPlayer = player.transform.position;
	}
		
	void Update(){
		distanceToMove = player.transform.position.x - posisiTerakhirPlayer.x;
		transform.position = new Vector3(transform.position.x + distanceToMove, transform.position.y, transform.position.z);
		posisiTerakhirPlayer = player.transform.position;
	}
}
