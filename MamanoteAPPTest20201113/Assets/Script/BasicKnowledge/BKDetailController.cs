using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BKDetailController : MonoBehaviour
{
    public int id;

    [SerializeField] private Image _MainImage = null;
    [SerializeField] private Text _TitleText = null;
    [SerializeField] private Text _SubTitleText = null;
    [SerializeField] private Text _ExplanationText = null;
    [SerializeField] private Text _ImageText = null;

    [SerializeField] private GameObject _MainObject = null;
    [SerializeField] private Button _BuckButton = null;
    
    void Start()
    {
        this.gameObject.SetActive(false);
        _BuckButton.onClick.AddListener(OnClickBuckButton);

        
    }

    

    public void OnClickBuckButton()
    {
        Debug.Log("ButckButton");
        this.gameObject.SetActive(false);
        _MainObject.gameObject.SetActive(true);
    }

     public void SetDetail()
    { 
            int id = PlayerPrefs.GetInt("id");   

            string inputString = Resources.Load<TextAsset>("Json/Contents").ToString();
            Debug.Log(inputString);
            TestJsonParent inputJson = JsonUtility.FromJson<TestJsonParent>(inputString);

        
        
            Debug.Log(inputJson);

            for(int i = 0; i < inputJson.data.Length; i++)
            {
                if(inputJson.data[i].id != id) continue;

                this._TitleText.text = inputJson.data[i].title;
                this._SubTitleText.text = inputJson.data[i].subTitle;
                this._ExplanationText.text = inputJson.data[i].explanationText;
                this._ImageText.text = inputJson.data[i].imageText;
               
                
                Sprite MainSprite = Resources.Load<Sprite>("Image/Contents/" + inputJson.data[i].mainImage);
                _MainImage.sprite = MainSprite;

            
                break;
            }

            // Debug.Log(inputJson.data.Length); 
        
            // Debug.Log(PlayerPrefs.GetInt("id"));

            
            
    }



    
}
