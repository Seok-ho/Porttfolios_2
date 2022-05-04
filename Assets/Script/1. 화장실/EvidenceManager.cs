using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EvidenceManager : MonoBehaviour
{
    private int total_Evidence = 3; //찾아야할 총 증거 

    public static int goNextScene = 0;  // 해당 변수로 다음 장소로 이동하는 버튼 생성
    public GameObject goNextPannel;     // 페이드인 프리팹 넣어주면 됨 
    public GameObject goNextButton;     // 다음 장소로 이동해주는 버튼 
    public GameObject end_Talk; //화장실 입장시 넣어주면 됨 

    public GameObject talkObject;   //대사창

    public GameObject blood_Pond;   //피웅덩이;
    public GameObject blood_Pond2;  //칼에 있는 피웅덩이 

    [Header("발자국 증거")]
    public GameObject feetPrint_Pic; // 발자국 프린트 
    public GameObject feetPrint;    //발자국
    public GameObject feetPinrt_Talk;   //발자국 눌렀을 때 나올 대사 

    [Header("손수건 증거")]
    public GameObject handTower_Pic;   
    public GameObject handTower;
    public GameObject handTower_Talk;

    [Header("칼 증거")]
    public GameObject knife_Pic;
    public GameObject knife;
    public GameObject knife_Talk;



    public void Disappear_Blood()    // 피웅덩이 눌렀을 때
    {
        blood_Pond.SetActive(false);
    }
    public void Disappear_Blood2()    // 피웅덩이2 눌렀을 때
    {
        blood_Pond2.SetActive(false);
    }

    public void WhenClick_feetPrint()   //신발 눌렀을 때 대사도 함께 나와야 함 
    {
        feetPrint.SetActive(false);
        feetPrint_Pic.SetActive(true);
        talkObject.SetActive(true);
        feetPinrt_Talk.SetActive(true);
    }

    public void WhenClick_handTower()
    {
        handTower.SetActive(false);
        handTower_Pic.SetActive(true);
        talkObject.SetActive(true);
        handTower_Talk.SetActive(true);
    }
    
    public void WhenClick_knife()
    {
        knife.SetActive(false);
        knife_Pic.SetActive(true);
        talkObject.SetActive(true);
        knife_Talk.SetActive(true);
    }

    // 여기에 FadeOut 넣어주기 

    private void Update()
    {
        if(goNextScene == total_Evidence)    //증거 3개 다 찾으면 
        {
            end_Talk.SetActive(true);
            /*
            goNextButton.SetActive(true);
            goNextPannel.SetActive(true);
            */
        }
    }
}
