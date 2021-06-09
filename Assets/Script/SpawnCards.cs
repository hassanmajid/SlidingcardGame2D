using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpawnCards : MonoBehaviour
{
   
    [SerializeField] ScriptableObjects script;
    [SerializeField] Transform pos;
    public GameObject Cardprefab;
    

   
    
    
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



        for (int k = 0; k < 3; k++)
        {
            CardPrefabController cardPrefabController = Instantiate(Cardprefab, pos).GetComponent<CardPrefabController>();

            //Instantiating Cards
            cardPrefabController.cards.sprite = script.CArdDecks[k].CardSet;


            //Instantiating BackGround
            for (int i = 0; i <= 3; i++)
            {

                cardPrefabController.containers[i].sprite = script.CArdDecks[k].Containers[0];

            }

            //Instantiating Items

            for (int i = 0; i <= 3; i++)
            {
                cardPrefabController.imageItems[i].sprite = script.CArdDecks[k].ItemSprites[i];
            }

            //instantiating verifiedSprite and count

            cardPrefabController.AddMouseEventListner(script.CArdDecks[0].VerifyImage, script.CArdDecks[k].Containers[1]);
            cardPrefabController.StartTimer();

        }


    }



}
