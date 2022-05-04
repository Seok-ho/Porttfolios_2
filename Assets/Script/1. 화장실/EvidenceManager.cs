using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EvidenceManager : MonoBehaviour
{
    private int total_Evidence = 3; //ã�ƾ��� �� ���� 

    public static int goNextScene = 0;  // �ش� ������ ���� ��ҷ� �̵��ϴ� ��ư ����
    public GameObject goNextPannel;     // ���̵��� ������ �־��ָ� �� 
    public GameObject goNextButton;     // ���� ��ҷ� �̵����ִ� ��ư 
    public GameObject end_Talk; //ȭ��� ����� �־��ָ� �� 

    public GameObject talkObject;   //���â

    public GameObject blood_Pond;   //�ǿ�����;
    public GameObject blood_Pond2;  //Į�� �ִ� �ǿ����� 

    [Header("���ڱ� ����")]
    public GameObject feetPrint_Pic; // ���ڱ� ����Ʈ 
    public GameObject feetPrint;    //���ڱ�
    public GameObject feetPinrt_Talk;   //���ڱ� ������ �� ���� ��� 

    [Header("�ռ��� ����")]
    public GameObject handTower_Pic;   
    public GameObject handTower;
    public GameObject handTower_Talk;

    [Header("Į ����")]
    public GameObject knife_Pic;
    public GameObject knife;
    public GameObject knife_Talk;



    public void Disappear_Blood()    // �ǿ����� ������ ��
    {
        blood_Pond.SetActive(false);
    }
    public void Disappear_Blood2()    // �ǿ�����2 ������ ��
    {
        blood_Pond2.SetActive(false);
    }

    public void WhenClick_feetPrint()   //�Ź� ������ �� ��絵 �Բ� ���;� �� 
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

    // ���⿡ FadeOut �־��ֱ� 

    private void Update()
    {
        if(goNextScene == total_Evidence)    //���� 3�� �� ã���� 
        {
            end_Talk.SetActive(true);
            /*
            goNextButton.SetActive(true);
            goNextPannel.SetActive(true);
            */
        }
    }
}
