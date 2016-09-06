using UnityEngine;
using System.Collections.Generic;

[CreateAssetMenu(fileName = "Wave", menuName = "Wave/New Wave", order = 1)]
public class Wave : ScriptableObject {

    public List<WaveStep> steps;
}
