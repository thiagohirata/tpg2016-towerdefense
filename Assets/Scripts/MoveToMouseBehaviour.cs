using UnityEngine;
using System.Collections;

public class MoveToMouseBehaviour : MonoBehaviour {
    

	// Use this for initialization
	void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {

        if(Input.GetButtonUp("Fire2")) {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit))
            {
                this.transform.position = hit.point;
                // Do something with the object that was hit by the raycast.
            }
        }

    }
}
