using UnityEngine;
using System.Collections;

public class GeradorDeInimigosBehaviour : MonoBehaviour {

    public GameObject prefab;
    public int periodo = 10;
    public Transform goal;
    private float ultimoInimigoGerado = 0;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
       if (Time.time - ultimoInimigoGerado > periodo) {
            Vector3 pos = this.transform.position;
            Quaternion rot = this.transform.rotation;

            Component inimigoCriado = (Component) Instantiate(prefab, pos, rot);
            ultimoInimigoGerado = Time.time;
            
            inimigoCriado.GetComponent<NavmeshWalker>().goal = this.goal;
            

       }
    }
}
