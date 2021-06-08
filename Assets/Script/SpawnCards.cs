using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpawnCards : MonoBehaviour
{
   
    [SerializeField] ScriptableObjects script;
    [SerializeField] Transform pos;
    //[SerializeField] GameObject spawnee;

     //Sprite cards;

    //[SerializeField] GameObject cardStack;
    
    //Sprite[] CardSets;

    public GameObject CardSet1;
    

    // Update is called once per frame
    void Update()
    {
        
    }

    void Start()
    {
        SpawnCard();
        
    }
  
    public void SpawnCard()
    {
        ////Background = script.BackGround;
        //Sprite temp = cardStack.transform.GetChild(0).GetComponent<Sprite>();
        //temp = script.CardSet[0];

        CardPrefabController cardPrefabController = Instantiate(CardSet1, pos).GetComponent<CardPrefabController>();

        cardPrefabController.cards.sprite = script.CardSet[0];
        

        Instantiate(cardPrefabController.cards.sprite, pos);
        for (int i = 0; i <= 3; i++)
        {

            cardPrefabController.imageItems[i].sprite = script.ItemSprites[i];
            Instantiate(cardPrefabController.imageItems[i].sprite, pos);

        }




    }
   

   
}
