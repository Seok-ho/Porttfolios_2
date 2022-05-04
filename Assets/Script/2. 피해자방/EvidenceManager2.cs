using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EvidenceManager2 : MonoBehaviour
{
    private int total_Evidence = 2;

    public static int goNextScene = 0;  // �ش� ������ ���� ��ҷ� �̵��ϴ� ��ư ����
    public GameObject goNextPannel;     // ���̵��� ������ �־��ָ� �� 
    public GameObject goNextButton;     // ���� ��ҷ� �̵����ִ� ��ư 

    public GameObject talkObject;   //���â

    [Header("�Ź� ������ ����")]
    public GameObject box_shoes; //  �������� ��ư
    public GameObject boxshoes_Pic;    //���ڱ� ����
    public GameObject feetSize_Talk;   //���ڱ� ������ �� ���� ��� 

    [Header("������ ����")]
    public GameObject drawerBtn;    //���� ��ư(�����Ѱ�)
    public GameObject drawer_Pic;   // ������ Ŭ������ �� ���� �̹���
    public GameObject gf_Pic;   //����ģ�� ����
    public GameObject gf_talk;  //����ģ�� ���� Ŭ���ϸ� ���� ��� 
    void Update()
    {
        if (goNextScene == total_Evidence)    //���� 2�� �� ã���� 
        {
            goNextButton.SetActive(true);
            goNextPannel.SetActive(true);
        }
    }

    public void WhenClick_Shoes()   //�Ź� ������ �� ��絵 �Բ� ���;� �� 
    {
        box_shoes.SetActive(false);
        talkObject.SetActive(true); //���â 
        feetSize_Talk.SetActive(true); //��� 
        boxshoes_Pic.SetActive(true);
        drawerBtn.SetActive(true);
    }

    public void WhenClick_Drawer()  //������ Ŭ��
    {
        drawerBtn.SetActive(false);
        drawer_Pic.SetActive(true);
    }

    public void WhenClick_DrawerPic() // ������ �ȼ� �̹��� Ŭ�� 
    {
        drawer_Pic.SetActive(false);
        talkObject.SetActive(true);
        gf_Pic.SetActive(true);
        gf_talk.SetActive(true);
    }
}



