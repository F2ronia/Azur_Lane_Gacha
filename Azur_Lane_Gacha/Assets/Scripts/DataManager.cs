using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using LitJson;

public class DataManager : MonoBehaviour {

    [SerializeField]
    protected TextAsset jsonData;
    //읽어올 Json 텍스트 파일

    private void OnGUI()
    {
        
        if(GUILayout.Button("Sdfsdf"))
        {
            JsonData getData =  JsonMapper.ToObject(jsonData.text);
            //----------------------텍스트 파일을 JsonData 파일로 변환-----------------------
            //------------------------------텍스트 파일의 구조-------------------------------
            //--------------------[건조분류]-[함선종류]-<이름>,<시간>,<등급>-----------------
            //------호출 시 [건조분류][건조분류번호][함선종류][함선종류번호][세부사항]-------

            ICollection<string> i;

            if (getData["Light"][0].ToString().Equals("Destroyer"))
            {
                Debug.Log("sdfsdfsdf");
            }
            else
            {
                i = getData["Light"][0].Keys;
                  //키 값만 불러오고 싶다 시부럴..


            }


            Debug.Log(getData["Light"][0]["Destroyer"][0]["Name"].ToString());
            Debug.Log(getData["Light"][0]["Destroyer"][0]["Time"].ToString());
            Debug.Log(getData["Light"][1]["Light_Cruiser"][0]["Name"].ToString());
            Debug.Log(getData["Light"][1]["Light_Cruiser"][0]["Time"].ToString());
        }
    }
}
