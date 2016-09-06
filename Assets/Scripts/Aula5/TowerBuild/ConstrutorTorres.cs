using UnityEngine;
using System.Collections;

public class ConstrutorTorres : MonoBehaviour {
    public GameObject geradorTorreAtaquePrefab;


    public void NovaTorreAtaque () {
        Instantiate(geradorTorreAtaquePrefab);
	}
	
}
