using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject esc_Pannel;   //Esc �г� 
    public GameObject note_Pannel;  //�����Ʈ �г�
    public GameObject tutorial_Pannel; //ó�� Ʃ�丮�� �г� 

    public GameObject all_UI;   //���� ��� UI
    public GameObject story1_1_Pannel;  //���丮 1-1 �г� 
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))    //esc ������ ��
        {
            UI_Off();   //���� ��� UI Off
            Time.timeScale = 0; //�Ͻ����� 
            esc_Pannel.SetActive(true); //esc �г� ���� 
        }
    }

    public void Continue_Btn()  //����ϱ� ������ 
    {
        Time.timeScale = 1; //�Ͻ����� ��ü 
        esc_Pannel.SetActive(false);    //esc �г� ����
        UI_On();    //���� ��� UI On
    }

    public void Exit_Btn()
    {
        Time.timeScale = 1; //�Ͻ����� ��ü (Ȥ�� ���� ���� Application.Quit()�� ���൵ �ɵ�?)
        Application.Quit(); //���� ���� 
    }

    public void SettingClick_Btn()  //���� ��� UI Off, Esc������ ������ �г� On
    {
        UI_Off();  
        esc_Pannel.SetActive(true);
    }

    public void End_tutorial()
    {
        tutorial_Pannel.SetActive(false);
        story1_1_Pannel.SetActive(true);
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
