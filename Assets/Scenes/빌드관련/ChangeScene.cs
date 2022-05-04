using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{

    public void MoveRoom(int i)
    {
        SceneManager.LoadScene(i);
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex); 
    }
    //��ư ������ �г� ONOFF�Ϸ��� ����
    public void OnOFF_Button(GameObject gameobject)
    {
        //�г��� �̹� Ȱ��ȭ �������� OFF
        if(gameobject.activeSelf == true)
        {
            gameobject.SetActive(false);
        }
        //�г��� ��Ȱ��ȭ �������� ON
        else
        {
            gameobject.SetActive(true);
        }
    }
}
