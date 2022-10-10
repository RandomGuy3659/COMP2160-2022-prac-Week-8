using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField] private Text scoreText1;
    [SerializeField] private Text scoreText2;
    [SerializeField] private Scorekeeper scorekeeper;
    private int score1;
    private int score2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        score1 = scorekeeper.CurrentPointsP1;
        score2 = scorekeeper.CurrentPointsP2;
        scoreText1.text = ("Player 1 Score: " + score1);
        scoreText2.text = ("Player 2 Score: " + score2);
    }
}
