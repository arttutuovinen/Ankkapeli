using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;

    public TMP_Text player1Score;
    public TMP_Text player2Score;

    int scoreP1 = 0;
    int scoreP2 = 0;

    private void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        player1Score.text = "P1 - " + scoreP1.ToString() + " points";
        player2Score.text = scoreP2.ToString() + " points" + " - P2";
    }

    public void AddPointP1()
    {
        scoreP1 += 1;
        player1Score.text = "P1 - " + scoreP1.ToString() + " points";
    }
    public void AddPointP2()
    {
        scoreP2 += 1;
        player2Score.text = scoreP2.ToString() + " points" + " - P2";
    }
}
