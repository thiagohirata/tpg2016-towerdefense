using UnityEngine;
using System.Collections;

public class GeradorDeInimigosBehaviour : MonoBehaviour {

    public Transform prefab;
    public int periodo = 10;
    public Transform goal;
    private float ultimoInimigoGerado = 0;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
       if (Time.time - ultimoInimigoGerado > periodo) {
            Transform inimigoCriado = Instantiate(prefab);
            ultimoInimigoGerado = Time.time;
            inimigoCriado.GetComponent<NavmeshWalker>().goal = this.goal;

       }
    }
}
