using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class FadeInAnim4 : MonoBehaviour
{
    public Image image;     // ����ȭ��
    public GameObject button;
    public GameObject end_Animaition;
    public int whatNextScene;   //�������� �̵��� �� �����ֱ�

    public static FadeInAnim4 Instance;

    public GameObject canvas_story; // Esc_Canvas �־��ָ� �� 

    void Awake()
    {
        Instance = this;
    }
    public void FadeButton()
    {
        button.SetActive(false);
        StartCoroutine(FadeCoroutine());
        Invoke("Go_NextScene", 2f);
        //end_Animaition.SetActive(true);
    }
    public void FadeButton_EndAnimation()
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
    public void End_Seeking()
    {
        canvas_story.SetActive(false);
    }
    public void Go_NextScene()
    {
        SceneManager.LoadScene(whatNextScene);
    }
}
