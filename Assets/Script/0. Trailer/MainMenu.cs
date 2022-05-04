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
    public void Exit_Btn()   //���� ���� ��ư 
    {
        Application.Quit(); //���ø����̼� ���� 
    }
    IEnumerator DealyTime()
    {
        yield return new WaitForSeconds(2f);
    }
}
