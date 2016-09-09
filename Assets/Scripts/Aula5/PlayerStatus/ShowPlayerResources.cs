using UnityEngine;
using System.Collections;

public class ShowPlayerResources : MonoBehaviour {

		// Update is called once per frame
	void Update () {
        GetComponent<UnityEngine.UI.Text>().text = PlayerStatus.main.resources.ToString();
    }
}
