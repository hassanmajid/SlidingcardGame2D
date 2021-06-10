using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CardPrefabController : MonoBehaviour
{

    public Image cards;

    public Image[] containers;
    public Image[] imageItems;
    public Text[] texts;
    public Button[] buttons;
    public static bool isverify = false;
    public Text expireTime;

    public void AddMouseEventListner (Sprite VerifiedSprite, Sprite VerifiedContainer){

        buttons[0].onClick.AddListener(() => IncreaseMiniItemCount(buttons[0], texts[0], VerifiedSprite, containers[0], VerifiedContainer));
        buttons[1].onClick.AddListener(() => IncreaseMiniItemCount(buttons[1], texts[1], VerifiedSprite, containers[1], VerifiedContainer));
        buttons[2].onClick.AddListener(() => IncreaseMiniItemCount(buttons[2], texts[2], VerifiedSprite, containers[2], VerifiedContainer));
        buttons[3].onClick.AddListener(() => IncreaseMiniItemCount(buttons[3], texts[3], VerifiedSprite, containers[3], VerifiedContainer));
    }

    public void AccessingItems (ScriptableObjects script,int k){
        //Instantiating Cards
        cards.sprite = script.CArdDecks[k].CardSet;


        //Instantiating BackGround
        for (int i = 0; i <= 3; i++){

            containers[i].sprite = script.CArdDecks[k].Containers[0];

        }

        //Instantiating Items

        for (int i = 0; i <= 3; i++){
            imageItems[i].sprite = script.CArdDecks[k].ItemSprites[i];
        }

        
        StartTimer();
    }
    

    public void IncreaseMiniItemCount (Button MiniItemButton, Text MiniItemCount, Sprite VerifiedSprite, Image container, Sprite VerifiedContainer){
        string str = MiniItemCount.text;
        if (str == ""){
            return;
        }


        int number = int.Parse(str.Split('/')[0]);
        int total = int.Parse(str.Split('/')[1]);


        if (number < total){
            number++;
        }

        string temp = number.ToString() + "/" + str.Split('/')[1];
        MiniItemCount.text = temp;

        if (number == total){
            isverify = true;
            container.sprite = VerifiedContainer;
            Image img = MiniItemButton.GetComponent<Image>();
            img.sprite = VerifiedSprite;

            RectTransform rt = MiniItemButton.GetComponent<RectTransform>();
            rt.sizeDelta = new Vector2(47, 49);

            MiniItemCount.text = null;
        }


    }

    Timer timeRemaining;
    bool startTimer = false;

    public void StartTimer (){
        string expireTimer = expireTime.text.ToString();
        timeRemaining = new Timer(expireTimer);
        timeRemaining.StartCountDown();
        startTimer = true;
        Debug.Log(expireTimer);
    }


    void Update (){
        if (startTimer)
        {
            timeRemaining.UpdateCountDown();
            expireTime.text = timeRemaining.timeRemainingInStr;
        }
    }
}
