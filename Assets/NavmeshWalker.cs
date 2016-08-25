using UnityEngine;
using System.Collections;

[RequireComponent(typeof(NavMeshAgent))]
public class NavmeshWalker : MonoBehaviour {
    public Transform goal;

	// Use this for initialization
	void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {
        NavMeshAgent agent = GetComponent<NavMeshAgent>();
        if(goal != null)
        {
            agent.destination = goal.transform.position;
        }
    }
}
