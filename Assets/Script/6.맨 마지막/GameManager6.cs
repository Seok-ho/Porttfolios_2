using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager6 : MonoBehaviour
{
    public void Return_Choice()   //��� �����Ǽ� �ǵ��ư��°�
    {
        //���� �ٽ� ������ؼ� �ε���
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
