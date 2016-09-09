using UnityEngine;
using System.Collections;

[CreateAssetMenu(fileName = "TowerBuildingMetadata", menuName = "TowerBuildingMetadata/New TowerBuildingMetadata", order = 1)]
public class TowerBuildingMetadata : ScriptableObject {
    public int buildingCost;
    public GameObject towerConstructorPrefab;
    public string towerName;

}
