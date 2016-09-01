using UnityEngine;
using System.Collections;


public class UpdateHPTextBehaviour : MonoBehaviour {

	
	// Update is called once per frame
	void UpdateHP(int newHP) {
        GetComponent<UnityEngine.UI.Text>().text = newHP.ToString();
	}
}
