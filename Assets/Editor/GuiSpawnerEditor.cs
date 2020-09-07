
using UnityEngine;
using UnityEditor;

[CustomPropertyDrawer (typeof (ObstacleSpawner))]
public class GuiSpawnerEditor : PropertyDrawer
{
    public override void OnGUI(Rect position, SerializedProperty property, GUIContent label) {
        EditorGUI.BeginProperty(position, label, property);
        bool spawnPosition = property.FindPropertyRelative("position").boolValue;

        position = EditorGUI.PrefixLabel(position, GUIUtility.GetControlID(FocusType.Passive), label);

        var rect = new Rect(position.position, Vector2.one * 20);
    }
}
