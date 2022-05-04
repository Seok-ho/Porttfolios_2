using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    private AudioSource audio;

    private void Start()
    {
        audio = GetComponent<AudioSource>();
    }
    public void GameStart()
    {
        audio.Play();
        StartCoroutine(DealyTime());
        SceneManager.LoadScene(1);
    }
    public void Exit_Btn()   //게임 종료 버튼 
    {
        Application.Quit(); //어플리케이션 종료 
    }
    IEnumerator DealyTime()
    {
        yield return new WaitForSeconds(2f);
    }
}
