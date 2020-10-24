using System;
using UnityEngine;
using System.Reflection;
using System.Text.RegularExpressions;

[AttributeUsage(AttributeTargets.Field, Inherited = true)]


public class ReadOnlyAttribute : PropertyAttribute {  }

#if UNITY_EDITOR
public class ReadOnlyAttributeDrawer : UnityEditor.PropertyDrawer
  {
	
	public override void OnGUI(Rect rect, UnityEditor.SerializedProperty prop, GUIContent label)
		{
			bool wasEnabled = GUI.enabled;
			GUI.enabled = false;
			UnityEditor.EditorGUI.PropertyField(rect, prop);
			GUI.enabled = wasEnabled;
			
		}
}
#endif
