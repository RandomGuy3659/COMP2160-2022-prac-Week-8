using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinBehaviour : MonoBehaviour
{

    [SerializeField] private GameObject player;

    private Collider playerCollider;
    private Scorekeeper scorekeeper;
    void Start()
    {
        playerCollider = player.GetComponent<Collider>();
        scorekeeper = FindObjectOfType<Scorekeeper>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter(Collider other)
    {
        Debug.Log("TriggerEnter" + other.name);
        if (other.Equals(playerCollider))
        {
            Destroy(gameObject);
            scorekeeper.IncreaseScore();
            
        }
    }
}
