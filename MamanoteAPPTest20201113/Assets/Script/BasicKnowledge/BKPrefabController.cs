using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class BKPrefabController : MonoBehaviour
{
    public int id;
    [SerializeField] private Text _TitleText = null;    
    [SerializeField] private Image _TitleImage = null;  

    [SerializeField] private Button _ContentsButton = null;  

     public Action CallBuckButton = null;  //コールバック


    

    
    void Start()
    {
         _ContentsButton.onClick.AddListener(OnClickContentsButton);
         IdSet();
        
    }

    void OnClickContentsButton()
    {
        Debug.Log(id);

        PlayerPrefs.SetInt("id", id);
        Debug.Log("GetInt: " + PlayerPrefs.GetInt("id"));
        if(CallBuckButton != null)
        {
          CallBuckButton.Invoke();
        }
        Debug.Log("OnStoryContentButton");

    }

    void IdSet()
    {
        Debug.Log(id);

        PlayerPrefs.SetInt("id", id);
        Debug.Log("SetInt: " + PlayerPrefs.GetInt("id"));
    }



    public void SetId(int dataId)
    {
        id = dataId;  
    }

    public void SetPrefab(string text,Sprite sprite)
    {
        _TitleText.text = text;
        _TitleImage.sprite = sprite;
    }

   

    
    
}
