using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EvidenceManager5 : MonoBehaviour
{
    private int total_Evidence = 6;

    public static int goNextScene = 0;  // 해당 변수로 다음 장소로 이동하는 버튼 생성
    public GameObject goNextPannel;     // 페이드인 프리팹 넣어주면 됨 
    public GameObject goNextButton;     // 다음 장소로 이동해주는 버튼 

    public GameObject talkObject;   //대사창

    [Header("발 사이즈 증거")]
    public GameObject feetPrint; // 발자국 프린트 
    public GameObject feetPrint_Pic;    //발자국
    public GameObject feetSize_Talk;   //발자국 눌렀을 때 나올 대사 

    [Header("피 묻은 옷 증거")]
    public GameObject blood_clothes;
    public GameObject blood_clothes_Pic;
    public GameObject blood_Talk;

    [Header("햄버거 영수증 증거")]
    public GameObject trash;    //영수증 쓰래기 버튼
    public GameObject receipt_Pic;  //영수증 이미지
    public GameObject receipt_Talk; //영수증 대화 

    [Header("열쇠 증거")]
    public GameObject key;      //키 버튼
    public GameObject key_Pic;  //키 이미지
    public GameObject key_Talk; //키 대화

    [Header("열쇠 증거")]
    public GameObject draw; //서랍 버튼
    public GameObject draw_Pic; //서랍 이미지
    public GameObject draw_Talk;    //서랍 대화 



    [Header("증거 다 찾았을 때 대사")]
    public GameObject allFindEvidence_Talk;


    void Update()
    {
        if (goNextScene == total_Evidence - 1)    //증거 3개 다 찾으면 
        {
            talkObject.SetActive(true);
            allFindEvidence_Talk.SetActive(true);
        }
        else if (goNextScene == total_Evidence)
        {
            goNextButton.SetActive(true);
            goNextPannel.SetActive(true);
        }
    }

    public void WhenClick_Shoes()   //신발 눌렀을 때 대사도 함께 나와야 함 
    {
        feetPrint.SetActive(false);
        talkObject.SetActive(true);
        feetPrint_Pic.SetActive(true);
        feetSize_Talk.SetActive(true); //대사 
    }
    public void WhenClick_Receipt() //영수증 이벤트 
    {
        trash.SetActive(false);
        talkObject.SetActive(true);
        receipt_Pic.SetActive(true);
        receipt_Talk.SetActive(true);
    }

    public void WhenClick_BloodClothes() //피 묻은 옷  이벤트 
    {
        blood_clothes.SetActive(false);
        talkObject.SetActive(true);
        blood_clothes_Pic.SetActive(true);
        blood_Talk.SetActive(true);
    }

    public void WhenClick_Key()
    {
        key.SetActive(false);
        talkObject.SetActive(true);
        key_Pic.SetActive(true);
        key_Talk.SetActive(true);
        draw.SetActive(true);   //서랍 이제 클릭할 수 있게 해줌 
    }

    public void WhenClick_Draw()    //서랍 눌렀을때 이벤트
    {
        draw.SetActive(false);  //버튼 비활성화
        talkObject.SetActive(true); //대사창 UI ON
        draw_Pic.SetActive(true);   // 앞에 나올 사진 ON
        draw_Talk.SetActive(true);  //대사 ON
    }
}
