using UnityEditor;
using UnityEngine;
using System.Collections;

[CustomEditor(typeof(DestroyOnGoalBehaviour))]
public class DestroyOnGoalBehaviourEditor : Editor {
    public override void OnInspectorGUI()
    {
        DestroyOnGoalBehaviour target = (DestroyOnGoalBehaviour) this.target;
        target.goalLayer = EditorGUILayout.LayerField("Goal Layer", target.goalLayer);
    }
}
