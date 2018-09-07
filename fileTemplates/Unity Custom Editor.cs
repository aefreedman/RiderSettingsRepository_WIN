using UnityEditor;


    [CustomEditor(typeof($TargetClassName))]
    public class $ClassName : UnityEditor.Editor
    {
        public override void OnInspectorGUI()
        {
            DrawDefaultInspector();
            var tgt = target as $TargetClassName;

            // Some stuff to use
            //EditorGUILayout.Space();
            //EditorGUILayout.Separator();
            //GUILayout.Label("label", new GUIStyle() { alignment = TextAnchor.MiddleCenter, fontSize = 20, fontStyle = FontStyle.Bold });
            //GUILayout.Button("string")
            //GUILayout.BeginHorizontal();
            //GUILayout.EndHorizontal();
            //var loopStyle = new GUIStyle { normal = new GUIStyleState { textColor = Color.cyan } };
        }
    }
