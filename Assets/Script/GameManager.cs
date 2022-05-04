using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject esc_Pannel;   //Esc 패널 
    public GameObject note_Pannel;  //수사노트 패널
    public GameObject tutorial_Pannel; //처음 튜토리얼 패널 

    public GameObject all_UI;   //우측 상단 UI
    public GameObject story1_1_Pannel;  //스토리 1-1 패널 
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))    //esc 눌렀을 때
        {
            UI_Off();   //우측 상단 UI Off
            Time.timeScale = 0; //일시정지 
            esc_Pannel.SetActive(true); //esc 패널 열음 
        }
    }

    public void Continue_Btn()  //계속하기 누르면 
    {
        Time.timeScale = 1; //일시정지 해체 
        esc_Pannel.SetActive(false);    //esc 패널 닫음
        UI_On();    //우측 상단 UI On
    }

    public void Exit_Btn()
    {
        Time.timeScale = 1; //일시정지 해체 (혹시 몰라서 넣음 Application.Quit()만 해줘도 될듯?)
        Application.Quit(); //게임 종료 
    }

    public void SettingClick_Btn()  //우측 상단 UI Off, Esc누르면 나오는 패널 On
    {
        UI_Off();  
        esc_Pannel.SetActive(true);
    }

    public void End_tutorial()
    {
        tutorial_Pannel.SetActive(false);
        story1_1_Pannel.SetActive(true);
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
