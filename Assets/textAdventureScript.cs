using UnityEngine;
using System.Collections;

public class textAdventureScript : MonoBehaviour {

	string currentRoom = "entrance";
	int pass = 0;

	public Transform kylehead;

	// Use this for passialization
	void Start () {

	
	}
	
	// Update is called once per frame
	void Update () {

		
		// when you use an "if/else" structure, only ONE of those
		// blocks will ever run, it is an either/or scenario!

		if (currentRoom == "entrance") {

						if (Input.anyKeyDown) {
								pass += 1;
						}if (pass == 0) {
						GetComponent<GUIText> ().text = "Good Evening. Welcome to ShadowFake\n The last thing you remember is standing before the wizard [KYLE LI] as \nhe gestured wildly and chanted in an archaic tongue.";
						} else if(pass == 1) {
						GetComponent<GUIText> ().text = "The Castle is a Dark, damp place. At least the REAL castle is.\nBecause this is not the real castle.\nIt's the facade of a tribute of an old castle.";
						} else if (pass == 2) {
								GetComponent<GUIText> ().text = "Are you clicking like the instructions above are telling you? \nGood. Though you probably noticed you can click any key by now.";
						} else if (pass == 3) {
								GetComponent<GUIText> ().text = "This is a 3D room based on the original Macintosh Shadowgate.\nUnlike that game, you can't actually go anywhere here.\nIt's just a test, for homework.\nSeriously, nothing to see here.";
						} else if (pass == 4) {
								GetComponent<GUIText> ().text = "There is no wizard named [Kyle Li], don't ask about him.\nSeriously, he is not the lord of this fake castle. Go away, stop clicking.\t";
						} else if (pass == 5) {
								GetComponent<GUIText> ().text = "...";
						} else if (pass == 6) {
								GetComponent<GUIText> ().text = "......";
						} else if (pass == 7) {
								GetComponent<GUIText> ().text = "....................";
						} else if (pass >= 8) {
								currentRoom = "wizard";
						}
				
		} else if (currentRoom == "wizard" ) {
		GetComponent<GUIText>().text = "\nOKAY I WILL CALL THE WIZARD... DO YOU WANT TO MEET HIM? [Y/N]"; 
			if ( Input.GetKeyDown (KeyCode.Y) ) {
				kylehead.position=new Vector3(kylehead.position.x,kylehead.position.y,5);

				GetComponent<GUIText>().text = "\nSUFFER THE WRATH OF THE WIZARD!!!!"; 
				currentRoom = "KYLE";
			}
			else if ( Input.GetKeyDown (KeyCode.N) ) {
				currentRoom = "entrance";
				pass = 0;
			}

		}
		

	
	}
}
