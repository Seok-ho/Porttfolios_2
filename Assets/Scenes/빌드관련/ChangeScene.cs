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
    //버튼 누르면 패널 ONOFF하려고 만듬
    public void OnOFF_Button(GameObject gameobject)
    {
        //패널이 이미 활성화 되있으면 OFF
        if(gameobject.activeSelf == true)
        {
            gameobject.SetActive(false);
        }
        //패널이 비활성화 되있으면 ON
        else
        {
            gameobject.SetActive(true);
        }
    }
}
