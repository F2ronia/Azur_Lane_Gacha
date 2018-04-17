using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine.UI;
using UnityEngine;

[System.Serializable]
public class Destroyer {
//
    public string Name;
    //
    public  string Rare;
    //
    public int Time;
    //
    public Image image;
    //
}

[System.Serializable]
public class Light_Cruiser{
//
    public string Name;
    //
    public string Rare;
    //
    public int Time;
    //
    public Image image;
    //
}

[System.Serializable]
public class test
{
    //
    public string Name;
    //
    public string Rare;
    //
    public int Time;
    //
    public Image image;
    //
}

[System.Serializable]
public class test2
{
    //
    public string Name;
    //
    public string Rare;
    //
    public int Time;
    //
    public Image image;
    //
}

public class DataManager : MonoBehaviour {

    public Destroyer[] destoyer;
    //
    public Light_Cruiser[] light_cruiser;
    //


}
