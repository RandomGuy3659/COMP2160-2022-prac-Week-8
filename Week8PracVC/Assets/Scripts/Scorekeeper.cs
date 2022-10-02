using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorekeeper : MonoBehaviour
{
    [SerializeField] private int coinPoints;
    private int currentPoints;
    public int CurrentPoints
    {
        get
        {
            return currentPoints;
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

    public void IncreaseScore()
    {
        currentPoints += coinPoints;
        Debug.Log("Current Points: " + currentPoints);
    }
}
