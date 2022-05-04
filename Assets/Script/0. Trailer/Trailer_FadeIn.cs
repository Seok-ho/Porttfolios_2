using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Trailer_FadeIn : MonoBehaviour
{

    public Image image;     // ����ȭ��
    public GameObject button;
    public int whatNextScene;   //�������� �̵��� �� �����ֱ�
    public void FadeButton()
    {
        button.SetActive(false);
        StartCoroutine(FadeCoroutine());
        Invoke("Go_NextScene", 2f);
    }

    public IEnumerator FadeCoroutine()
    {
        float fadeCount = 0;

        while (fadeCount < 1.0f)
        {
            fadeCount += 0.005f;
            yield return new WaitForSeconds(0.01f); //0.01�ʸ��� ���� 
            image.color = new Color(0, 0, 0, fadeCount);
        }
    }
    public void Go_NextScene()
    {
        SceneManager.LoadScene(whatNextScene);
    }
}
