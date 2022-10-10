using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinBehaviour : MonoBehaviour
{
    private Scorekeeper scorekeeper;
    void Start()
    {
        scorekeeper = FindObjectOfType<Scorekeeper>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter(Collider other)
    {
        int playerNum = 0;
        if(other.gameObject.name == "Player 1")
        {
            playerNum = 1;
        }
        else if(other.gameObject.name == "Player 2")
        {
            playerNum = 2;
        }
        else
        {
            Debug.Log("unknown collider");
        }
            Destroy(gameObject);
            scorekeeper.IncreaseScore(playerNum);
            
    }
}
