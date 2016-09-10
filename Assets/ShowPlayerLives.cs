using UnityEngine;
using System.Collections;

public class ShowPlayerLives : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        GetComponent<UnityEngine.UI.Text>().text = PlayerStatus.main.lives.ToString();
    }
}
