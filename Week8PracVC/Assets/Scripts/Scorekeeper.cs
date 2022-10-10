using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorekeeper : MonoBehaviour
{
    [SerializeField] private int coinPoints;
    private int currentPointsP1;
    public int CurrentPointsP1
    {
        get
        {
            return currentPointsP1;
        }
    }
    private int currentPointsP2;
    public int CurrentPointsP2
    {
        get
        {
            return currentPointsP2;
        }
    }

    static private Scorekeeper instance;
    static public Scorekeeper Instance
    {
        get
        {
            if(instance == null)
            {
                Debug.LogError("The instance is missing");
            }
            return instance;
        }
    }

    void OnAwake()
    {
        if(instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void IncreaseScore(int player)
    {
        if (player == 1)
        {
            currentPointsP1 += coinPoints;
        }
        else if (player == 2)
        {
            currentPointsP2 += coinPoints;
        }
        else
        {
            Debug.LogError("Player ID invalid: Who grabbed that coin?");
        }

    }
}
