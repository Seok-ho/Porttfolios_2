using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// 용의자 수첩 관련해서 적는 버튼 
public class Check_Suspect : MonoBehaviour
{
    //패널들
    public GameObject esc_Pannel;
    public GameObject note_Pannel;

    //그 외 
    public GameObject note; // 용의자 전체 수첩
    public GameObject note_Number1; //용의자1 수첩 확인
    public GameObject note_Number2; //용의자2 수첩 확인
    public GameObject note_Number3; //용의자3 수첩 확인
    public GameObject note_Number4; //용의자4 수첩 확인
    public GameObject note_Number5; //용의자5 수첩 확인 
    public GameObject all_UI;

    public void Click_Number1() //용의자1 버튼 클릭 
    {
        note.SetActive(false);  //버튼 클릭했으니 용의자 수첩 false
        note_Number1.SetActive(true);
    }
    public void Click_Number2() //용의자2 버튼 클릭 
    {
        note.SetActive(false);  //버튼 클릭했으니 용의자 수첩 false
        note_Number2.SetActive(true);
    }
    public void Click_Number3() //용의자3 버튼 클릭 
    {
        note.SetActive(false);  //버튼 클릭했으니 용의자 수첩 false
        note_Number3.SetActive(true);
    }
    public void Click_Number4() //용의자4 버튼 클릭 
    {
        note.SetActive(false);  //버튼 클릭했으니 용의자 수첩 false
        note_Number4.SetActive(true);
    }
    public void Click_Number5() //용의자5 버튼 클릭 
    {
        note.SetActive(false);  //버튼 클릭했으니 용의자 수첩 false
        note_Number5.SetActive(true);
    }

    public void CheckNote_Btn()
    {
        note_Pannel.SetActive(true);
        UI_Off();
    }

    public void Back_Go_note()  //용의자 특징 확인 창에서 뒤로가기 
    {
        note_Number1.SetActive(false);
        note_Number2.SetActive(false);
        note_Number3.SetActive(false);
        note_Number4.SetActive(false);
        note_Number5.SetActive(false);
        note.SetActive(true);
    }

    public void Back_EscPannel()
    {
        if (note.activeSelf == false) //note 비활성화 되있으면 용의자 확인중인거니까 
        {
            Back_Go_note(); //용의자 전체 note 활성화 
        }
        else    // 용의자 전체수첩 보고 있을 경우 패널 종료, 우측 상단 UI On
        {
            note_Pannel.SetActive(false);
            UI_On();
        }
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


