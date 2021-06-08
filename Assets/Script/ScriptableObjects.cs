using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "SpritesData")]
public class ScriptableObjects : ScriptableObject
{

    
    [SerializeField] Sprite[] itemSprites;
    public Sprite[]ItemSprites
    {
        get { return itemSprites; }
    }

    [SerializeField]
    private Sprite[] cardSet;
    public Sprite[] CardSet
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
    private GameObject checkItembox;
    public GameObject CheckItemBox
    {
        get { return checkItembox; }
        set { checkItembox = value; }
    }

    static ScriptableObject instance;
    public static ScriptableObject Instance
    {
        get
        {
            if (instance != null)
                instance = FindObjectOfType<ScriptableObject>();
            if (instance == null)
                Debug.LogError("Scriptable object not found");
            return instance;
        }
    }

   
  
}