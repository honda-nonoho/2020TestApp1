using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BKScrollViewController : MonoBehaviour
{
    [SerializeField] private GameObject _ScrollViewContent = null; //scrollViewContent
    private BKPrefabController _BKPrefab = null;  

    private Dictionary<int, string> dic = new Dictionary<int, string>();

    [SerializeField] private BKDetailController _BKDetailObject = null;


    int _Loop = 0;
    const string _FromPrefab = "Prefab/Guide/BKPrefab";
    
    void Start()
    {
        Load();

        dic.Add(0,"発達について");
        dic.Add(1,"食事について");
        dic.Add(2,"生活の流れ");
        dic.Add(3,"遊びについて");
        dic.Add(4,"集団生活について");
        dic.Add(5,"行事について");
        dic.Add(6,"散歩について");
        dic.Add(7,"服装について");
        dic.Add(8,"教室について");
        
    
        for(int i = 0; i < 9; i++)
        {
                _Loop++;

                var index = i + 1;
                Debug.Log(index);

                var TitleSprite = Resources.Load<Sprite>("Image/BKImages/Contents" + index.ToString());  
                

                var Prefab = Instantiate<BKPrefabController>(_BKPrefab, Vector3.zero, Quaternion.identity, _ScrollViewContent.transform); 

                Prefab.SetPrefab(dic[i],TitleSprite);
                Prefab.SetId(_Loop);
                Prefab.CallBuckButton += Test;
               
              
               
        }        
        
    }

     void Load()    
    {
        Debug.Log("Load");
        _BKPrefab = Resources.Load<BKPrefabController>(_FromPrefab);
      
    }

    public void Test()
    {
        Debug.Log("Test");
             
        _BKDetailObject.SetDetail();    
         _BKDetailObject.gameObject.SetActive(true); 

    }


    
}
