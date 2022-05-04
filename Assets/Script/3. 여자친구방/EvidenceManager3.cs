using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EvidenceManager3 : MonoBehaviour
{
    private int total_Evidence = 3;

    public static int goNextScene = 0;  // �ش� ������ ���� ��ҷ� �̵��ϴ� ��ư ����
    public GameObject goNextPannel;     // ���̵��� ������ �־��ָ� �� 
    public GameObject goNextButton;     // ���� ��ҷ� �̵����ִ� ��ư 

    public GameObject talkObject;   //���â

    [Header("�ϱ���")]
    public GameObject diary; //�ϱ��� �����ư
    public GameObject diary_Pic; //�ϱ��� ����
    public GameObject diary_Talk; //�ϱ��� ��ȭ 

    [Header("�޷�")]
    public GameObject calendar; //�޷� ��ư 
    public GameObject calendar_Pic; //�޷� ����
    public GameObject calendar_Talk;

    [Header("������")]
    public GameObject trash;    //������ ������ ��ư
    public GameObject receipt_Pic;  //������ �̹���
    public GameObject receipt_Talk; //������ ��ȭ 


    void Update()
    {
        if (goNextScene == total_Evidence)    //���� �� ã���� 
        {
            goNextButton.SetActive(true);
            goNextPannel.SetActive(true);
        }
    }

    public void WhenClick_Diary()   //�ϱ��� �̺�Ʈ 
    {
        diary.SetActive(false);
        talkObject.SetActive(true);
        diary_Pic.SetActive(true);
        diary_Talk.SetActive(true);
    }

    public void WhenClick_Calendar()  //�޷� �̺�Ʈ 
    {
        calendar.SetActive(false);
        talkObject.SetActive(true);
        calendar_Pic.SetActive(true);
        calendar_Talk.SetActive(true);
    }

    public void WhenClick_Receipt() //������ �̺�Ʈ 
    {
        trash.SetActive(false);
        talkObject.SetActive(true);
        receipt_Pic.SetActive(true);
        receipt_Talk.SetActive(true);
    }
}



