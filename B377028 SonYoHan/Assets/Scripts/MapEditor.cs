using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(GridEditor))]
public class MapEditor : Editor {

    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();
        GridEditor map = target as GridEditor;
        map.GridMap();
    }



    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
