using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Glass1_1 : MonoBehaviour
{
    public GameObject select1_2;    //������ �濡�� ������ �������� �� 
    public GameObject all_UI; //������ �� UI ������ ������ �ݾƾߵǴϱ� ���� 
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
