using UnityEditor;


[CustomEditor(typeof(FollowMouseBehaviour))]
public class FollowMouseBehaviourEditor : Editor {

    public override void OnInspectorGUI()
    {
        FollowMouseBehaviour t = (FollowMouseBehaviour)this.target;
        t.validLayer= EditorGUILayout.LayerField("ValidLayer", t.validLayer);
    }
}
