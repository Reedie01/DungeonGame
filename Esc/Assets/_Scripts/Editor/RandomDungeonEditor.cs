using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(AbstractGenerator), true)]

public class RandomDungeonEditor : Editor
{
    AbstractGenerator generator;

    private void Awake()
    {
        generator = (AbstractGenerator)target;
    }

    public overrride void OnInspectorGUI()
    {
        base.OnInspectorGUI();
        if(GUILayout.Button("Create Dungeon"))
        {
            generator.GenerateDungeon();
        }
    }
}
