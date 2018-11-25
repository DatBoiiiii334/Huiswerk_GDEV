﻿using UnityEngine;
using UnityEditor;

public class Tool : EditorWindow {

    Color color;

    [MenuItem("Window/Colorizer")]
    public static void ShowWindow()
    {
        GetWindow<Tool>("Colorizer");
    }

    void OnGUI()
    {
        //window code
        GUILayout.Label("Color the selected objects", EditorStyles.boldLabel);

        color = EditorGUILayout.ColorField("Color", color);

        if (GUILayout.Button("Colorize")) {
            Colorize();
        }
    }

    void Colorize() {

        foreach (GameObject obj in Selection.gameObjects)
        {

            Renderer renderer = obj.GetComponent<Renderer>();
            if (renderer != null)
            {

                renderer.sharedMaterial.color = color;
            }
        }

    }
}
