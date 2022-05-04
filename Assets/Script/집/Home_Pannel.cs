using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Home_Pannel : MonoBehaviour
{
    public GameObject home_Pannel;  // �� �̵� �г�
    public GameObject all_UI;       // ���� ��� UI

    public void ClickHome_Btn()  //�� ��� UI Ŭ���ϸ� �� �г� true,UI Off
    {
        home_Pannel.SetActive(true);
        UI_Off();
    }

    public void Back_Btn()  //�ڷΰ��� ������ Ȩ�г� ���ְ� UI �ٽ� ���� 
    {
        home_Pannel.SetActive(false);
        UI_On();
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
