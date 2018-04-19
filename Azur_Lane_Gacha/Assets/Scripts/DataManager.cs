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
    public Sprite image;
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
public class Heavy_Cruiser{
//
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
public class Aircraft_Carrier{
//
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
public class Battleship{
//
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
    public Image img;
    //
    public Text text;
    //
    public void SettindBg()
    {
        img.sprite = destoyer[0].image;
        text.text = destoyer[0].Name;
    }
}

