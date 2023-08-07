using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{    
    public static GameManager instance = null;
    private int score = 0;
    private int bestScore = 0;

    [SerializeField] 
    private TextMeshProUGUI text;

    private void Awake() {
        if (instance == null){
            instance = this;
        }        
    }

    public void IncreaseScore(){
        score += 1;
        Debug.Log($"IncreaseScore():{score}");
        text.SetText(score.ToString());
        RefreshBestScore();
    }

    public void ResetScore(){
        score = 0;
        Debug.Log($"ResetScore():{score}");
        text.SetText(score.ToString());
    }

    private void RefreshBestScore(){
        if (score > bestScore){
            bestScore = score;
        }
    }

}
