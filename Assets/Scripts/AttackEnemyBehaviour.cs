using UnityEngine;
using System.Collections;

public class AttackEnemyBehaviour : MonoBehaviour {
    public int damage = 1;

    /// <summary>
    /// Chamado por TowerBehaviourEditor
    /// </summary>
    /// <param name="enemy"></param>
	void Attack(Transform enemy) {
        enemy.SendMessage("ReceiveDamage", damage);
    }
}
