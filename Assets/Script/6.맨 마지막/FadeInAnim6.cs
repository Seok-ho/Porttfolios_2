using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class FadeInAnim6 : MonoBehaviour
{
    public Image image;     // ����ȭ��
    public GameObject canvas_story; // ���丮 ���� �־��ָ� ��

    [Header("���Ǽҵ�� �ֱ� ")]
    public GameObject[] episode;    //��ƿ�,�ŵ���,������ �ֱ� 
   


    public static FadeInAnim6 Instance;

    void Awake()
    {
        Instance = this;
    }
    public void End_episode(int i)  // ���Ǽҵ� Ŭ���� ���;� �Ұ� 
    {
        StartCoroutine(FadeCoroutine());    //���̵���
        Invoke("Not_Use", 2f);   //�׳� 2�� �ѱ���� �־�� 
        canvas_story.SetActive(false);
        episode[i].SetActive(true);  //�ش� ���Ǽҵ� �ѱ�
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


    public void Not_Use()
    {
        Debug.Log("�� �۵��ϳ׿�");
    }
}
