using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class SlideController : MonoBehaviour
{
    [SerializeField] private RectTransform _SlidebarImage = null; 

    private int _SetId = 1;
    private Vector3 position = Vector3.zero;
    const int SLIDE_NUMBER = 250;
   
    void Start()
    {
        position = _SlidebarImage.localPosition;
        Debug.Log("start  :  " + _SlidebarImage.localPosition);
    }
        

    public void PlaySlide(int id)
    {
        // 同じidは通さない
            if(id == _SetId) return;

            var num = id - _SetId;

            if(id > _SetId){
                // 右にスライド
                Debug.Log("右にスライド");
                position.x += (SLIDE_NUMBER * num);
            }else{
                // 左にスライド
                Debug.Log("左にスライド");
                position.x -= (SLIDE_NUMBER * -num);
            }
            
            Debug.Log("position  ::  " + position);
            _SetId = id;
            
            _SlidebarImage.DOLocalMove(position, 0.3f);

    }

}
