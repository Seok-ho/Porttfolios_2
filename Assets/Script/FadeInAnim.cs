using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class FadeInAnim : MonoBehaviour
{
    public Image image;     // 검은화면
    public GameObject button;
    public GameObject end_Animaition;
    public int whatNextScene;   //다음으로 이동할 씬 적어주기

    public static FadeInAnim Instance;

    public GameObject canvas_story; // Esc_Canvas 넣어주면 됨 

    void Awake()
    {
        Instance = this;
    }
    public void FadeButton()
    {
        button.SetActive(false);
        StartCoroutine(FadeCoroutine());
        Invoke("End_Seeking", 2f);
        end_Animaition.SetActive(true);
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

        while(fadeCount < 1.0f)
        {
            fadeCount += 0.005f;
            yield return new WaitForSeconds(0.01f); //0.01초마다 실행 
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
