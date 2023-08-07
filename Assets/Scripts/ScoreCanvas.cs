using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreCanvas : MonoBehaviour
{
    public static int score = 0;
    public static int bestScore = 0;

    [SerializeField]
    private TextMeshProUGUI textScore;

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        //GetComponent<Text>().text = score.ToString(); // str(score)
        //textScore.SetText(score.ToString());
    }
}
