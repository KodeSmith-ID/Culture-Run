using UnityEngine;
using System.Collections;

public class GroundCheck : MonoBehaviour {

	private Player player;
	public LayerMask taneuh;
	public Transform cekTaneuh;
	public float cekRadiusTaneuh;

	//private Collider2D cod;

	void Start(){
		player = gameObject.GetComponentInParent<Player>();
		//cod = gameObject.GetComponent<Collider2D>();
	}

	void Update(){
		//player.grounded = Physics2D.IsTouchingLayers(cod, taneuh);
		player.grounded = Physics2D.OverlapCircle(cekTaneuh.position, cekRadiusTaneuh, taneuh);
	}
}
