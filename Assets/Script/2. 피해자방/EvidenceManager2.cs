using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EvidenceManager2 : MonoBehaviour
{
    private int total_Evidence = 2;

    public static int goNextScene = 0;  // 해당 변수로 다음 장소로 이동하는 버튼 생성
    public GameObject goNextPannel;     // 페이드인 프리팹 넣어주면 됨 
    public GameObject goNextButton;     // 다음 장소로 이동해주는 버튼 

    public GameObject talkObject;   //대사창

    [Header("신발 사이즈 증거")]
    public GameObject box_shoes; //  선물상자 버튼
    public GameObject boxshoes_Pic;    //발자국 사진
    public GameObject feetSize_Talk;   //발자국 눌렀을 때 나올 대사 

    [Header("서랍장 증거")]
    public GameObject drawerBtn;    //서랍 버튼(투명한거)
    public GameObject drawer_Pic;   // 서랍장 클릭했을 때 나올 이미지
    public GameObject gf_Pic;   //여자친구 사진
    public GameObject gf_talk;  //여자친구 사진 클릭하면 나올 대사 
    void Update()
    {
        if (goNextScene == total_Evidence)    //증거 2개 다 찾으면 
        {
            goNextButton.SetActive(true);
            goNextPannel.SetActive(true);
        }
    }

    public void WhenClick_Shoes()   //신발 눌렀을 때 대사도 함께 나와야 함 
    {
        box_shoes.SetActive(false);
        talkObject.SetActive(true); //대사창 
        feetSize_Talk.SetActive(true); //대사 
        boxshoes_Pic.SetActive(true);
        drawerBtn.SetActive(true);
    }

    public void WhenClick_Drawer()  //서랍장 클릭
    {
        drawerBtn.SetActive(false);
        drawer_Pic.SetActive(true);
    }

    public void WhenClick_DrawerPic() // 서랍장 안속 이미지 클릭 
    {
        drawer_Pic.SetActive(false);
        talkObject.SetActive(true);
        gf_Pic.SetActive(true);
        gf_talk.SetActive(true);
    }
}



