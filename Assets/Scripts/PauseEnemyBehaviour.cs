using UnityEngine;
using System.Collections;

public class PauseEnemyBehaviour : MonoBehaviour {
    /// <summary>
    /// Chamado por TowerBehaviourEditor
    /// </summary>
    /// <param name="enemy"></param>
	void Attack(Transform enemy)
    {
        //ver https://docs.unity3d.com/ScriptReference/NavMeshAgent.html
        NavMeshAgent agent = enemy.GetComponent<NavMeshAgent>();
        agent.velocity = Vector3.zero;
        

    }
}
