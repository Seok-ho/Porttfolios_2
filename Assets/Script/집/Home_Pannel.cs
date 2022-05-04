using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Home_Pannel : MonoBehaviour
{
    public GameObject home_Pannel;  // 집 이동 패널
    public GameObject all_UI;       // 우측 상단 UI

    public void ClickHome_Btn()  //집 모양 UI 클릭하면 집 패널 true,UI Off
    {
        home_Pannel.SetActive(true);
        UI_Off();
    }

    public void Back_Btn()  //뒤로가기 누르면 홈패널 꺼주고 UI 다시 켜줌 
    {
        home_Pannel.SetActive(false);
        UI_On();
    }

    public void UI_On()     //우측 상단 UI 열어주는 함수 
    {
        all_UI.SetActive(true);
    }

    public void UI_Off()    //우측 상단에 있는 UI닫는 함수 
    {
        all_UI.SetActive(false);
    }
}
