
using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Animation2 : MonoBehaviour
{
    //������ ����
    public float delay;
    public float Skip_delay;
    public int cnt;  //21.11.04 �������ذ� 

    //Ÿ����ȿ�� ����
    public string[] fulltext;
    public int dialog_cnt;
    string currentText;

    //Ÿ����Ȯ�� ����
    public bool text_exit;
    public bool text_full;
    public bool text_cut;

    /*���� ������ ������ �Ⱦ��°� �ּ��س� (1_1����) --------------------------------------------------*/
    public GameObject talk_Object;
    public GameObject[] arrayImage; //�̹��� �迭
    public GameObject animation_GameObject; // ó������ �ִϸ��̼� �־��ָ� �� 
    public GameObject story_GameObject; //���丮 ����(������ ��) ĵ���� �־��ָ� �� 

    private int count;   //�� ��� ����
                         // public GameObject talk_Object;  //ex)��� 1-1 ������� -> �̷� �������� ���� �������� 

    /*---------------------------------------------------------------------*/
    //���۰� ���ÿ� Ÿ���ν���
    void Start()
    {
        Get_Typing(dialog_cnt, fulltext);
        count = fulltext.Length - 1;    //���;� �� �� ��� ������ (-1 ���Ѱ� ��� ������ Ŭ���ϸ� �������� �������� �Ѿ�� �Ϸ���)
    }


    //��� �ؽ�Ʈ ȣ��Ϸ�� Ż��
    void Update()
    {
        if (text_exit == true)
        {
            gameObject.SetActive(false);
        }
        /*�߰���Ų�� =========================================================================*/
        if (Input.GetMouseButtonDown(0))    //��Ŭ������ ��� �ѱ�°� �����ϰ� 
        {
            End_Typing();
            if (cnt == count) //��ȭ �� �������� ���â ���� 
            {
                End_Talk();         //��ȭ ���� 
            }
        }
        /*=========================================================================*/
    }
    /*�߰� ��Ų��==================================================================================*/
    public void End_Talk()
    {
        //��ȭ ������ UI �������ִ� �г� �����ְ� ó�����۾ִϸ��̼� ���ӿ�����Ʈ OFF
        talk_Object.SetActive(false);
        animation_GameObject.SetActive(false);
        story_GameObject.SetActive(true); 
    }
    
    // �����ڹ� ������ ���;��� �ִϸ��̼�
    public void Start_Animation()
    {

    }

    //�ִϸ��̼� ���� �Լ� ============================================================================
    public void Image_Next(int i)   //�̹��� ���鼭 �Ҹ� �ڵ�����Ǵ°Ŵϱ� ���� ���� ������ �Ѵ� ��?
    {
        arrayImage[i].SetActive(false);
        arrayImage[i + 1].SetActive(true);
    }
    // cnt (��翡 ���� �̹��� �ݰ� ��������ִ°�)
    public void ImageClse() //
    {
        if (cnt == 2)
        {
            Image_Next(0);
            Debug.Log("cnt1 ����");
        }
        else if (cnt == 3)
        {
            Image_Next(1);
            Debug.Log("cnt3 ����");
        }
        else if (cnt == 5)
        {
            Image_Next(2);
            Debug.Log("cnt5 ����");
        }
    }
    /*=========================================================================================*/

    //������ư�Լ�
    public void End_Typing()
    {
        //���� �ؽ�Ʈ ȣ��
        if (text_full == true)
        {
            cnt++;
            text_full = false;
            text_cut = false;
            StartCoroutine(ShowText(fulltext));
        }
        //�ؽ�Ʈ Ÿ���� ����
        else
        {
            text_cut = true;
        }
    }

    //�ؽ�Ʈ ����ȣ��
    public void Get_Typing(int _dialog_cnt, string[] _fullText)
    {
        //������ ���� �����ʱ�ȭ
        text_exit = false;
        text_full = false;
        text_cut = false;
        cnt = 0;

        //���� �ҷ�����
        dialog_cnt = _dialog_cnt;
        fulltext = new string[dialog_cnt];
        fulltext = _fullText;

        //Ÿ���� �ڷ�ƾ����
        StartCoroutine(ShowText(fulltext));
    }

    IEnumerator ShowText(string[] _fullText)
    {
        //����ؽ�Ʈ ����
        if (cnt >= dialog_cnt)
        {
            text_exit = true;
            StopCoroutine("showText");
        }
        else
        {
            //��������clear
            currentText = "";
            //Ÿ���� ����
            for (int i = 0; i < _fullText[cnt].Length; i++)
            {
                //Ÿ�����ߵ�Ż��
                if (text_cut == true)
                {
                    break;
                }
                //�ܾ��ϳ������
                currentText = _fullText[cnt].Substring(0, i + 1);
                this.GetComponent<Text>().text = currentText;
                yield return new WaitForSeconds(delay);
            }
            //Ż��� ��� �������
            Debug.Log("Typing ����");
            this.GetComponent<Text>().text = _fullText[cnt];
            yield return new WaitForSeconds(Skip_delay);

            //��ŵ_������ ����
            Debug.Log("Enter ���");
            text_full = true;
        }
    }
}
