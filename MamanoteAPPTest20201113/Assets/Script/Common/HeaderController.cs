﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.U2D;
using UnityEditor;
using DG.Tweening;
using UnityEngine.SceneManagement;

namespace Common
{

    public class HeaderController : MonoBehaviour
    {
        [SerializeField] private Button _MainButton = null;
        [SerializeField] private Button _PresentButton = null;
        [SerializeField] private Button _GuideButton = null;
        [SerializeField] private Button _SettingButton = null;

        [SerializeField] private SlideController _SlideController = null; 

        
        
         public void Start()
        {
            _MainButton.onClick.AddListener(OnClickMainButton);
            _PresentButton.onClick.AddListener(OnClickPresentButton);
            _GuideButton.onClick.AddListener(OnClickGuideButton);
            _SettingButton.onClick.AddListener(OnClickSettingButton);
            
        }

        void OnClickMainButton()
        {
            _SlideController.PlaySlide(1);
            Debug.Log("OnClickMainButton");
            SceneManager.LoadScene("HomeScene");
        }
        void OnClickPresentButton()
        {
            _SlideController.PlaySlide(2);
            Debug.Log("OnClickPresentButton");
            SceneManager.LoadScene("PresentScene");
        }

        void OnClickGuideButton()
        {
            _SlideController.PlaySlide(3);
            Debug.Log("OnClickGuideButton");
            SceneManager.LoadScene("GuideScene");
            
        }

        void OnClickSettingButton()
        {
            
            Debug.Log("OnClickGuideButton");
            // SceneManager.LoadScene("SettingScene");
            
        }
        
    }

}
