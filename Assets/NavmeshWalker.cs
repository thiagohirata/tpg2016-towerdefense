using UnityEngine;
using System.Collections;

[RequireComponent(typeof(NavMeshAgent))]
public class NavmeshWalker : MonoBehaviour {
    public Transform goal;
	private Vector3 destination;
	private NavMeshAgent agent;

	// Use this for initialization
	void Start () {
		agent = GetComponent<NavMeshAgent>();
		if(goal != null)
        {
			destination = goal.position;
            agent.destination = destination;
        }
    }

	// Update is called once per frame
	void Update () {

        if(goal != null)
        {
			// Update destination if the target moves one unit
			if (Vector3.Distance (destination, goal.position) > 1.0f) {
				destination = goal.position;
				agent.destination = destination;
			}
        }
    }
}
