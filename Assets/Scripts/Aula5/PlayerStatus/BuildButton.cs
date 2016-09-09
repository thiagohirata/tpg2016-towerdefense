using UnityEngine;
using System.Collections;

public class BuildButton : MonoBehaviour {
    public TowerBuildingMetadata towerBuildingMetadata;

    private UnityEngine.UI.Button button;
	
    void Start()
    {
        button = GetComponent<UnityEngine.UI.Button>();

        //atualiza o texto do botão
        GetComponentInChildren<UnityEngine.UI.Text>().text = towerBuildingMetadata.towerName;
    }
	
	void Update () {
        PlayerStatus player = PlayerStatus.main;
        //controla se o jogador possui recursos suficientes para construir a torre
        if(player.resources >= towerBuildingMetadata.buildingCost)
        {
            //HABILITADO
            button.interactable = true;
        } else
        {
            //DESABILITADO
            button.interactable = false;
        }
    }

    void Build()
    {
        if (PlayerStatus.main.resources >= towerBuildingMetadata.buildingCost)
        {
            PlayerStatus.main.SpendResources(towerBuildingMetadata.buildingCost);
            Instantiate(towerBuildingMetadata.towerConstructorPrefab);
        }
    }
}
