using UnityEngine;
using System.Collections;

public class PlayerStatus : MonoBehaviour {

    public static PlayerStatus main;

    public int resources = 0;
    public int lives = 3;

    void Start ()
    {
        //ao iniciar, coloca esta instância na 
        //variável estática main
        PlayerStatus.main = this;
    }

    void Update()
    {
        GameOverController.main.gameOver = (lives == 0);
    }

    public void GiveResources(int r)
    {
        this.resources += r;
    }

    public void SpendResources(int cost)
    {
        this.resources -= cost;
    }


}
