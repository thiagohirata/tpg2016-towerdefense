using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GameOverController : MonoBehaviour {
    public static GameOverController main;
    public List<GameObject> activeOnGameOver;
    public List<GameObject> inactiveOnGameOver;
    public GameObject victoryPanel;

    public bool gameOver;
    public bool waveFinished;
    public int enemyCount = 0;
    public bool victory;
    private bool lastFrameGameOver;
    
    void Start()
    {
        GameOverController.main = this;
        lastFrameGameOver = !gameOver;
    }
	
	// Update is called once per frame
	void Update () {
        //verifica a vitória
        victory = enemyCount == 0 && waveFinished;

        if(victory)
        {
            Time.timeScale = 0;
            victoryPanel.SetActive(true);
        }

	    if(gameOver)
        {
            Time.timeScale = 0;
        } else
        {
            Time.timeScale = 1;
        }

        if(gameOver != lastFrameGameOver)
        {
            foreach(GameObject a in activeOnGameOver) {
                a.SetActive(gameOver);
            }
            foreach (GameObject a in inactiveOnGameOver)
            {
                a.SetActive(!gameOver);
            }
        }

        lastFrameGameOver = gameOver;

    }


}
