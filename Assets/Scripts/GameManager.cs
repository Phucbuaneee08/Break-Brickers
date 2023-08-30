using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    public int scores;
    public bool gameOver;
    public int blockCount;
    
    public static GameManager Instance;
    public GameObject popUpScreen;
    public TextMeshPro scoresText;

    private void Awake(){
       if(Instance == null){
        Instance =this;
        DontDestroyOnLoad(gameObject);
       }
       else{
        Destroy(gameObject);
       }
    }
    // public void UpdatePlays(int changeInPlays){
    //     plays += changeInPlays;
    //     Debug.Log(plays);
    //     if(plays == 0){
    //         GameOver();
    //     }
    // }
    public void UpdateScores(int changeInScores){
        scores += changeInScores;
        scoresText.text = scores + "";
    }
    public void UpdateBlockCount(int changeInBlocks){
        blockCount -=changeInBlocks;
        if(blockCount == 0){
            GameOver();
        }
    }
    void Start()
    {
        
    }
    public void GameOver(){
        gameOver = true;
        popUpScreen.SetActive(true);
    }
    // Update is called once per frame
    
}
