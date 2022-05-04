
using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EndAnimation3 : MonoBehaviour
{
    //변경할 변수
    public float delay;
    public float Skip_delay;
    public int cnt;  //21.11.04 변경해준거 

    //타이핑효과 변수
    public string[] fulltext;
    public int dialog_cnt;
    string currentText;

    //타이핑확인 변수
    public bool text_exit;
    public bool text_full;
    public bool text_cut;

    /*내가 선언한 변수들 안쓰는건 주석해놈 (1_1기준) --------------------------------------------------*/
    //public GameObject[] arrayImage; //이미지 배열
    public GameObject animation_GameObject; // 끝 애니메이션 넣어주면 됨 
    public GameObject[] nameText; //이름 변경할때 쓰일 변수 (주인공, 경찰)
    public GameObject fadeIn_Story_End;
    public GameObject talk_Object;
    public GameObject address;
    public GameObject address2;


    private int count;   //총 대사 갯수
                         // public GameObject talk_Object;  //ex)대사 1-1 넣으면됨 -> 이런 형식으로 게임 제작하자 

    /*---------------------------------------------------------------------*/
    //시작과 동시에 타이핑시작
    void Start()
    {
        Get_Typing(dialog_cnt, fulltext);
        count = fulltext.Length - 1;    //나와야 할 총 대사 가져옴 (-1 안한건 대사 끝나고 클릭하면 다음으로 동작으로 넘어가게 하려고)
    }


    //모든 텍스트 호출완료시 탈출
    void Update()
    {
        if (text_exit == true)
        {
            gameObject.SetActive(false);
        }
        /*추가시킨거 =========================================================================*/
        if (Input.GetMouseButtonDown(0))    //좌클릭으로 대사 넘기는거 가능하게 
        {
            End_Typing();
            ChangeName();
            if (cnt == count) //대화 다 끝났으면 대사창 종료 
            {
                End_Talk();         //대화 종료 
            }
            if (cnt == 3)
            {
                address.SetActive(true);
                address2.SetActive(true);
            }
            if (cnt == 4)
            {
                address.SetActive(false);
                address2.SetActive(false);
            }
        }
        /*=========================================================================*/
    }
    /*추가 시킨거==================================================================================*/
    public void End_Talk()
    {
        talk_Object.SetActive(false);
        fadeIn_Story_End.SetActive(true);
        //animation_GameObject.SetActive(false);  //처음시작 애니메이션 게임오브젝트 닫음            
    }

    //애니메이션 쓰일 함수 ============================================================================

    // cnt (대사에 따라서 이미지 닫고 실행시켜주는거)
    public void ChangeName() //
    {
        if (cnt == 4)   //경찰에서 주인공으로 이름 변경 
        {
            nameText[0].SetActive(false);
            nameText[1].SetActive(true);
        }

    }
    /*=========================================================================================*/

    //다음버튼함수
    public void End_Typing()
    {
        //다음 텍스트 호출
        if (text_full == true)
        {
            cnt++;
            text_full = false;
            text_cut = false;
            StartCoroutine(ShowText(fulltext));
        }
        //텍스트 타이핑 생략
        else
        {
            text_cut = true;
        }
    }

    //텍스트 시작호출
    public void Get_Typing(int _dialog_cnt, string[] _fullText)
    {
        //재사용을 위한 변수초기화
        text_exit = false;
        text_full = false;
        text_cut = false;
        cnt = 0;

        //변수 불러오기
        dialog_cnt = _dialog_cnt;
        fulltext = new string[dialog_cnt];
        fulltext = _fullText;

        //타이핑 코루틴시작
        StartCoroutine(ShowText(fulltext));
    }

    IEnumerator ShowText(string[] _fullText)
    {
        //모든텍스트 종료
        if (cnt >= dialog_cnt)
        {
            text_exit = true;
            StopCoroutine("showText");
        }
        else
        {
            //기존문구clear
            currentText = "";
            //타이핑 시작
            for (int i = 0; i < _fullText[cnt].Length; i++)
            {
                //타이핑중도탈출
                if (text_cut == true)
                {
                    break;
                }
                //단어하나씩출력
                currentText = _fullText[cnt].Substring(0, i + 1);
                this.GetComponent<Text>().text = currentText;
                yield return new WaitForSeconds(delay);
            }
            //탈출시 모든 문자출력
            Debug.Log("Typing 종료");
            this.GetComponent<Text>().text = _fullText[cnt];
            yield return new WaitForSeconds(Skip_delay);

            //스킵_지연후 종료
            Debug.Log("Enter 대기");
            text_full = true;
        }
    }
}
