
  using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

[RequireComponent(typeof(RectTransform))]
public class UIManager : MonoBehaviour
{
    
    public RectTransform showBackground, showBottomOfShop, showTopOfShop, showLeftSide, showRightSide, slidingBox;
    float delay;
    float position;
    #region Getter
    static UIManager instance;
    public static UIManager Instance
    {
        get
        {
            if (instance != null)
                instance = FindObjectOfType<UIManager>();
            if (instance == null)
                Debug.LogError("UIManager not found");
            return instance;
        }
    }
    #endregion Getter

    void Start()
    {
        delay = (float)0.9;

        ShowBackground();
        ShowBottomOfShop(delay);
        ShowTopOfShop(delay);
        SlidingBox(delay);
        
        ShowLeftSide(delay);
        ShowRightSide(delay);
       
    }

    public void ShowBackground(float delay = 0f)
    {
        showBackground.DOAnchorPosX(0, 0f);
        showBackground.DOScale(new Vector3((float)1, (float)1, (float)1), 0.5f).SetDelay(delay);
    }

    public void ShowBottomOfShop(float delay = 0f)
    {
        position = showBottomOfShop.position.y * -1;
        showBottomOfShop.DOAnchorPosY(position, 0.0f);
        showBottomOfShop.DOAnchorPosY(position*-1, 0.5f).SetDelay(delay+0.5f);

    }

    public void ShowTopOfShop(float delay = 0f)
    {
        position = showTopOfShop.anchoredPosition.y;

        Debug.Log("Top side " + position);

        showTopOfShop.DOAnchorPosY(position*-1, 0.0f);
        showTopOfShop.DOAnchorPosY(position, 0.5f).SetDelay(delay+0.5f);

    }

    public void ShowLeftSide(float delay = 0f)
    {
        position = showLeftSide.anchoredPosition.x;

        showLeftSide.DOAnchorPosX(position*-1, 0.0f);
        showLeftSide.DOAnchorPosX(position-30, 0.5f).SetDelay(delay);
        showLeftSide.DOAnchorPosX(position, 0.5f).SetDelay(delay+0.5f);
       
    }

    public void ShowRightSide(float delay = 0f)
    {
        position = showRightSide.anchoredPosition.x;
        Debug.Log("Right side "+position);

        showRightSide.DOAnchorPosX(position *-1, 0.0f);
        showRightSide.DOAnchorPosX(position-30, 0.5f).SetDelay(delay);
        showRightSide.DOAnchorPosX(position, 0.5f).SetDelay(delay+0.5f);
        
    }
    public void SlidingBox(float delay = 0f)
    {
        position=slidingBox.anchoredPosition.x;
        slidingBox.DOAnchorPosX(position*1500, 0.0f);
        slidingBox.DOAnchorPosX(position+10, 0.5f).SetDelay(delay);
        slidingBox.DOAnchorPosX(position, 0.5f).SetDelay(delay+0.5f);
       

    }
}

