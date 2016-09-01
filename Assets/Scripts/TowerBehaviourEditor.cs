using UnityEngine;
using UnityEditor;
using System.Collections;

[CustomEditor(typeof(TowerBehaviour))]
public class TowerBehaviourEditor : Editor
{
    public override void OnInspectorGUI()
    {
        TowerBehaviour target = (TowerBehaviour)this.target;
        target.enemyLayer = EditorGUILayout.LayerField("Enemy Layer", target.enemyLayer);
        target.reach = EditorGUILayout.IntSlider("Reach", target.reach, 0, 10);
        target.cooldownTime = EditorGUILayout.IntSlider("Cooldown Time (s)", target.cooldownTime, 1, 10);
        EditorGUILayout.LabelField("Current Cooldown", target.currentCooldown.ToString());
    }
}
