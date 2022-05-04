using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class FadeInAnim6 : MonoBehaviour
{
    public Image image;     // 검은화면
    public GameObject canvas_story; // 스토리 진행 넣어주면 됨

    [Header("에피소드들 넣기 ")]
    public GameObject[] episode;    //김아영,신도연,원광성 넣기 
   


    public static FadeInAnim6 Instance;

    void Awake()
    {
        Instance = this;
    }
    public void End_episode(int i)  // 에피소드 클릭시 나와야 할것 
    {
        StartCoroutine(FadeCoroutine());    //페이드인
        Invoke("Not_Use", 2f);   //그냥 2초 넘길려고 넣어놈 
        canvas_story.SetActive(false);
        episode[i].SetActive(true);  //해당 에피소드 켜기
    }
    public IEnumerator FadeCoroutine()
    {
        float fadeCount = 0;

        while (fadeCount < 1.0f)
        {
            fadeCount += 0.005f;
            yield return new WaitForSeconds(0.01f); //0.01초마다 실행 
            image.color = new Color(0, 0, 0, fadeCount);
        }
    }


    public void Not_Use()
    {
        Debug.Log("잘 작동하네요");
    }
}
