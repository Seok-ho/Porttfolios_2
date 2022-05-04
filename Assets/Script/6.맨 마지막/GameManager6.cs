using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager6 : MonoBehaviour
{
    public void Return_Choice()   //배드 엔딩되서 되돌아가는거
    {
        //씬을 다시 재시작해서 로드함
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
