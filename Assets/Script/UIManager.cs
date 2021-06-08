
  using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

[RequireComponent(typeof(RectTransform))]
public class UIManager : MonoBehaviour
{
    
    public RectTransform showBackground, showBottomOfShop, showTopOfShop, showLeftSide, showRightSide, slidingBox;
    float delay;

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
        SlidingBox(delay);
        ShowTopOfShop(delay);
        ShowLeftSide(delay);
        ShowRightSide(delay);
       
    }

    public void ShowBackground(float delay = 0f)
    {
        showBackground.DOAnchorPosX(0, 0f);
        showBackground.DOScale(new Vector3((float)1, (float)1, (float)1), 1.1f).SetDelay(delay);
    }

    public void ShowBottomOfShop(float delay = 0f)
    {
        showBottomOfShop.DOAnchorPosY(0, 0.5f).SetDelay(delay);
        //showBottomOfShop.DOLocalMove(new Vector3((float)0, (float)50, (float)0), 2.1f, true);//.SetDelay(delay);
    }

    public void ShowTopOfShop(float delay = 0f)
    {
        showTopOfShop.DOAnchorPosY(0, 0.5f).SetDelay(delay);
        //showTopOfShop.DOLocalMove(new Vector3((float)0, (float)50, (float)0), 2.1f, true);//.SetDelay(delay);
    }

    public void ShowLeftSide(float delay = 0f)
    {
        showLeftSide.DOAnchorPosX(28, 0.5f).SetDelay(delay);
        showLeftSide.DOAnchorPosX(0, 0.5f).SetDelay(delay+0.5f);
        //showTopOfShop.DOLocalMove(new Vector3((float)0, (float)50, (float)0), 2.1f, true);//.SetDelay(delay);
    }

    public void ShowRightSide(float delay = 0f)
    {
        showRightSide.DOAnchorPosX(-28, 0.5f).SetDelay(delay);
        showRightSide.DOAnchorPosX(0, 0.5f).SetDelay(delay+0.5f);
        //showTopOfShop.DOLocalMove(new Vector3((float)0, (float)50, (float)0), 2.1f, true);//.SetDelay(delay);
    }
    public void SlidingBox(float delay = 0f)
    {

        slidingBox.DOAnchorPosX(200, 0.5f).SetDelay(delay);
        slidingBox.DOAnchorPosX(303, 0.5f).SetDelay(delay+0.5f);

    }
}

