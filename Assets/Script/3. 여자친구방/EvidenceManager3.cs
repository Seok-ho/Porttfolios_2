using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EvidenceManager3 : MonoBehaviour
{
    private int total_Evidence = 3;

    public static int goNextScene = 0;  // 해당 변수로 다음 장소로 이동하는 버튼 생성
    public GameObject goNextPannel;     // 페이드인 프리팹 넣어주면 됨 
    public GameObject goNextButton;     // 다음 장소로 이동해주는 버튼 

    public GameObject talkObject;   //대사창

    [Header("일기장")]
    public GameObject diary; //일기장 투명버튼
    public GameObject diary_Pic; //일기장 사진
    public GameObject diary_Talk; //일기장 대화 

    [Header("달력")]
    public GameObject calendar; //달력 버튼 
    public GameObject calendar_Pic; //달력 사진
    public GameObject calendar_Talk;

    [Header("영수증")]
    public GameObject trash;    //영수증 쓰래기 버튼
    public GameObject receipt_Pic;  //영수증 이미지
    public GameObject receipt_Talk; //영수증 대화 


    void Update()
    {
        if (goNextScene == total_Evidence)    //증거 다 찾으면 
        {
            goNextButton.SetActive(true);
            goNextPannel.SetActive(true);
        }
    }

    public void WhenClick_Diary()   //일기장 이벤트 
    {
        diary.SetActive(false);
        talkObject.SetActive(true);
        diary_Pic.SetActive(true);
        diary_Talk.SetActive(true);
    }

    public void WhenClick_Calendar()  //달력 이벤트 
    {
        calendar.SetActive(false);
        talkObject.SetActive(true);
        calendar_Pic.SetActive(true);
        calendar_Talk.SetActive(true);
    }

    public void WhenClick_Receipt() //영수증 이벤트 
    {
        trash.SetActive(false);
        talkObject.SetActive(true);
        receipt_Pic.SetActive(true);
        receipt_Talk.SetActive(true);
    }
}



