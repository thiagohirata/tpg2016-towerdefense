using UnityEditor;
using UnityEngine;
using System.Collections;

[CustomEditor(typeof(EnemyStatusBehaviour))]
public class EnemyStatusBehaviourEditor : Editor {
    public override void OnInspectorGUI()
    {
        EnemyStatusBehaviour enemyStatusBehaviour = (EnemyStatusBehaviour) this.target;
        enemyStatusBehaviour.hitPoints = EditorGUILayout.IntSlider("HP", enemyStatusBehaviour.hitPoints, 1, 100);
    }

}
