using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using LitJson;

public class DataManager : MonoBehaviour {

    protected TextAsset jsonData;
    //

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnGUI()
    {
        if(GUILayout.Button("Sdfsdf"))
        {
            LitJson.JsonData getData = LitJson.JsonMapper.ToObject(jsonData.text);
        }
    }
}
