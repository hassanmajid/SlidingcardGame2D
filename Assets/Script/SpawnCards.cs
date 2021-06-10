using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpawnCards : MonoBehaviour
{
   
    [SerializeField] ScriptableObjects script;
    [SerializeField] Transform pos;
    public GameObject Cardprefab;
    CardPrefabController cardPrefabController;

    void Start (){
        SpawnCard();
        
    }

    public void SpawnCard (){

        for (int k = 0; k < 3; k++){
            cardPrefabController = Instantiate(Cardprefab, pos).GetComponent<CardPrefabController>();
            cardPrefabController.AccessingItems(script,k);
            cardPrefabController.AddMouseEventListner(script.CArdDecks[0].VerifyImage, script.CArdDecks[k].Containers[1]);
        }
    }
   
}
