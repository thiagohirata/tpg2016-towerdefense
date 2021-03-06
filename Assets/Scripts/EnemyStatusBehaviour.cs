﻿using UnityEngine;
using System.Collections;

public class EnemyStatusBehaviour : MonoBehaviour {
    public int hitPoints = 10;

    void Start()
    {
        BroadcastMessage("UpdateHP", this.hitPoints);
    }

    /// <summary>
    /// Veja AttackEnemyBehaviour
    /// </summary>
    /// <param name="damage"></param>
    public void ReceiveDamage(int damage)
    {
        hitPoints -= damage;
        BroadcastMessage("UpdateHP", this.hitPoints); //para atualizar a GUI
        if(hitPoints <= 0)
        {
            Destroy(this.gameObject);
        }
    }
}
