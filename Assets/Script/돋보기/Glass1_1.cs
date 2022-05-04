using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Glass1_1 : MonoBehaviour
{
    public GameObject select1_2;    //피해자 방에서 돋보기 선택했을 때 
    public GameObject all_UI; //오른쪽 위 UI 돋보기 누르면 닫아야되니까 선언 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Open_Galss()
    {
        select1_2.SetActive(true);
        all_UI.SetActive(false);
    }
}
