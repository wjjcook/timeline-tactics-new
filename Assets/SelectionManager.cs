using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class SelectionManager : MonoBehaviour
{
    
    public UnitDatabase unitDB;
    public Text nameText;
    public Text infoText;
    public Text statText;
    public SpriteRenderer selectedSprite;

    public GameObject playerA;

    public GameObject playerB;

    private int playerTurn = 1;

    // private int pageNum = 0;

    [Header("Unit Selections")]
    public List<GameObject> selectionsAll;
    public readonly List<GameObject> selectionsA = new List<GameObject>();
    public readonly List<GameObject> selectionsB = new List<GameObject>();

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void unitClicked(int unitIndex){
        SelectableUnits unit = unitDB.GetUnit(unitIndex);
        nameText.text = unit.name;
        selectedSprite.sprite = unit.sprite;
        infoText.text = unit.info;
        statText.text = unit.stats;
    }

    public void unitSelected(){
        GameObject selectedUnit = GameObject.Find(nameText.text);
        string unitObjectName = "";
        if (playerTurn == 1){
            if (selectionsA.Contains(selectedUnit)){
                Debug.Log(selectedUnit + " has already been selected!");
                return;
            }
            selectionsA.Add(selectedUnit);
            unitObjectName = "UnitA" + (selectionsA.Count).ToString();
            playerTurn = 2;

        } else {
            if (selectionsB.Contains(selectedUnit)){
                Debug.Log(nameText.text + " has already been selected!");
                return;
            }
            selectionsB.Add(selectedUnit);
            unitObjectName = "UnitB" + (selectionsB.Count).ToString();
            playerTurn = 1;
        }

        GameObject unitObject = GameObject.Find(unitObjectName);
        
        SpriteRenderer unitSprite = unitObject.GetComponent<SpriteRenderer>();
        unitSprite.sprite = selectedSprite.sprite;

        selectionsAll.Add(selectedUnit);
        
        if (selectionsAll.Count == 8){
            Debug.Log("All units selected!");


            // Switch selections list to only hold names to carry over to next scene?

            // foreach(GameObject aUnit in selectionsA){
            //     DontDestroyOnLoad(aUnit);
            // }

            // foreach(GameObject bUnit in selectionsB){
            //     DontDestroyOnLoad(bUnit);
            // }
            
            SceneManager.LoadScene("Battle");
        }
    }

    // public void NextPage(){
    //     pageNum++;

    //     // if (pageNum >= unitDB.unitCount)
    // }
    
}
