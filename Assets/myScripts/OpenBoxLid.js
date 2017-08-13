/*#pragma strict


var treasureChest : GameObject;
var anim : Animator;

function Start () {
	anim = GetComponent<Animator>();
}
function OnTriggerEnter(col : Collider){

	

	if(col.gameObject.tag == " Player"){

		treasureChest.anim.Play();
		Destroy(gameObject);
	}
}
*/
