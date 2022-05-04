using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// ������ ��ø �����ؼ� ���� ��ư 
public class Check_Suspect : MonoBehaviour
{
    //�гε�
    public GameObject esc_Pannel;
    public GameObject note_Pannel;

    //�� �� 
    public GameObject note; // ������ ��ü ��ø
    public GameObject note_Number1; //������1 ��ø Ȯ��
    public GameObject note_Number2; //������2 ��ø Ȯ��
    public GameObject note_Number3; //������3 ��ø Ȯ��
    public GameObject note_Number4; //������4 ��ø Ȯ��
    public GameObject note_Number5; //������5 ��ø Ȯ�� 
    public GameObject all_UI;

    public void Click_Number1() //������1 ��ư Ŭ�� 
    {
        note.SetActive(false);  //��ư Ŭ�������� ������ ��ø false
        note_Number1.SetActive(true);
    }
    public void Click_Number2() //������2 ��ư Ŭ�� 
    {
        note.SetActive(false);  //��ư Ŭ�������� ������ ��ø false
        note_Number2.SetActive(true);
    }
    public void Click_Number3() //������3 ��ư Ŭ�� 
    {
        note.SetActive(false);  //��ư Ŭ�������� ������ ��ø false
        note_Number3.SetActive(true);
    }
    public void Click_Number4() //������4 ��ư Ŭ�� 
    {
        note.SetActive(false);  //��ư Ŭ�������� ������ ��ø false
        note_Number4.SetActive(true);
    }
    public void Click_Number5() //������5 ��ư Ŭ�� 
    {
        note.SetActive(false);  //��ư Ŭ�������� ������ ��ø false
        note_Number5.SetActive(true);
    }

    public void CheckNote_Btn()
    {
        note_Pannel.SetActive(true);
        UI_Off();
    }

    public void Back_Go_note()  //������ Ư¡ Ȯ�� â���� �ڷΰ��� 
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
        if (note.activeSelf == false) //note ��Ȱ��ȭ �������� ������ Ȯ�����ΰŴϱ� 
        {
            Back_Go_note(); //������ ��ü note Ȱ��ȭ 
        }
        else    // ������ ��ü��ø ���� ���� ��� �г� ����, ���� ��� UI On
        {
            note_Pannel.SetActive(false);
            UI_On();
        }
    }
    public void UI_On()     //���� ��� UI �����ִ� �Լ� 
    {
        all_UI.SetActive(true);
    }

    public void UI_Off()    //���� ��ܿ� �ִ� UI�ݴ� �Լ� 
    {
        all_UI.SetActive(false);
    }
}


