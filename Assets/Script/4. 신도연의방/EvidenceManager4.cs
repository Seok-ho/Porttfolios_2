using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EvidenceManager4 : MonoBehaviour
{
    private int total_Evidence = 4;

    public static int goNextScene = 0;  // �ش� ������ ���� ��ҷ� �̵��ϴ� ��ư ����
    public GameObject goNextPannel;     // ���̵��� ������ �־��ָ� �� 
    public GameObject goNextButton;     // ���� ��ҷ� �̵����ִ� ��ư 

    public GameObject talkObject;   //���â

    [Header("�� ������ ����")]
    public GameObject feetPrint; // ���ڱ� ����Ʈ 
    public GameObject feetPrint_Pic;    //���ڱ�
    public GameObject feetSize_Talk;   //���ڱ� ������ �� ���� ��� 

    [Header("�� ���� �� ����")]
    public GameObject blood_clothes;
    public GameObject blood_clothes_Pic;
    public GameObject blood_Talk;

    [Header("�ܹ��� ������ ����")]
    public GameObject trash;    //������ ������ ��ư
    public GameObject receipt_Pic;  //������ �̹���
    public GameObject receipt_Talk; //������ ��ȭ 

    [Header("���� �� ã���� �� ���")]
    public GameObject allFindEvidence_Talk;


    void Update()
    {
        if (goNextScene == total_Evidence - 1)    //���� 3�� �� ã���� 
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

    public void WhenClick_Shoes()   //�Ź� ������ �� ��絵 �Բ� ���;� �� 
    {
        feetPrint.SetActive(false);
        talkObject.SetActive(true);
        feetPrint_Pic.SetActive(true);
        feetSize_Talk.SetActive(true); //��� 
    }
    public void WhenClick_Receipt() //������ �̺�Ʈ 
    {
        trash.SetActive(false);
        talkObject.SetActive(true);
        receipt_Pic.SetActive(true);
        receipt_Talk.SetActive(true);
    }

    public void WhenClick_BloodClothes() //�� ���� ��  �̺�Ʈ 
    {
        blood_clothes.SetActive(false);
        talkObject.SetActive(true);
        blood_clothes_Pic.SetActive(true);
        blood_Talk.SetActive(true);
    }

}
