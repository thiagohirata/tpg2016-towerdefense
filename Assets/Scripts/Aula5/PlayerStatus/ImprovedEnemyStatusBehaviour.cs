using UnityEngine;
using System.Collections;

public class ImprovedEnemyStatusBehaviour : MonoBehaviour {
    public int hitPoints = 10;
    public int resourcesWhenDestroyed = 1;


    void Start()
    {
        BroadcastMessage("UpdateHP", this.hitPoints);
        GameOverController.main.enemyCount++;
    }

    void OnDestroy()
    {
        GameOverController.main.enemyCount--;
    }

    /// <summary>
    /// Veja AttackEnemyBehaviour
    /// </summary>
    /// <param name="damage"></param>
    public void ReceiveDamage(int damage)
    {
        hitPoints -= damage;
        BroadcastMessage("UpdateHP", this.hitPoints); //para atualizar a GUI
        if (hitPoints <= 0)
        {
            PlayerStatus.main.GiveResources(resourcesWhenDestroyed);

            Destroy(this.gameObject);
        }
    }
}
