using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
[CreateAssetMenu(fileName = "SpritesData")]

public class ScriptableObjects : ScriptableObject
{
    [SerializeField]List<CardDeck> cardDecks;
    public List<CardDeck> CArdDecks
    {
        get
        {
            return cardDecks;
        }
    }





    //static ScriptableObjects instance;
    //public static ScriptableObjects Instance
    //{
    //    get
    //    {
    //        if (instance != null)
    //            instance = FindObjectOfType<ScriptableObjects>();
    //        if (instance == null)
    //            Debug.LogError("Scriptable object not found");
    //        return instance;
    //    }
    //}

   
  
}
[System.Serializable]
public class CardDeck
{

    [SerializeField] Sprite[] itemSprites;
    public Sprite[] ItemSprites
    {
        get { return itemSprites; }
    }

    [SerializeField]
    private Sprite cardSet;
    public Sprite CardSet
    {
        get { return cardSet; }
        //set { cardSet = value; }
    }

    [SerializeField]
    private Sprite[] containers;
    public Sprite[] Containers
    {
        get { return containers; }
        set { containers = value; }
    }

    [SerializeField]
    private Sprite backGround;
    public Sprite BackGround
    {
        get { return backGround; }
        set { backGround = value; }
    }

    [SerializeField]
    private Sprite verifyImage;
    public Sprite VerifyImage
    {
        get { return verifyImage; }
        set { verifyImage = value; }
    }

    [SerializeField]
    private string texts;
    public string Texts
    {
        get { return texts; }
        set { texts = "6/20"; }
    }



}