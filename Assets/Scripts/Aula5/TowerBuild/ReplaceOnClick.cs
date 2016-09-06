using UnityEngine;
using System.Collections;

public class ReplaceOnClick : MonoBehaviour {
    public GameObject prefab;
	
	
	void Update () {
	    if(Input.GetButton("Fire1"))
        {
            Vector3 pos = this.transform.position;
            Quaternion rot = this.transform.rotation;
            if(prefab != null)
            {
                GameObject inimigoCriado = (GameObject)Instantiate(prefab, pos, rot);
            }
            Destroy(this.gameObject);
        }
    }
}
