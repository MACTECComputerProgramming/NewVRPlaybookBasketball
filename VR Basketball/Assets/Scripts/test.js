var screen : GameObject;

function OnTriggerStay (col : Collider) {

	screen.SetActive(true);
}
function OnTriggerExit (col : Collider){
	screen.SetActive(false);
}