#pragma strict

var hide : GameObject;

function Start () {
	hide = GameObject.Find("Painting3");
}

function Update () {
	
	if(Input.GetKeyDown(KeyCode.Z)){
		
		print("Pressed Z : " +hide.name);
		//hide.GetComponent.<Renderer>().enabled =false ;
		hide.SetActive(!hide.activeSelf);
		//hide.gameObject.GetComponent().enabled;
	}
	if(Input.GetKeyDown((KeyCode.X))){
		//hide = GameObject.Find("Painting3");
		print("Pressed X");
		//hide.SetActive(true);
	}
}
