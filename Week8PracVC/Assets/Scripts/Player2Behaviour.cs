using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2Behaviour : MonoBehaviour
{
    [SerializeField] private int movementSpeed;

    private int speed;
    // Start is called before the first frame update
    void Start()
    {
        speed = movementSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime * Input.GetAxis(InputAxes.Vertical2), Space.Self);
        transform.Translate(Vector3.right * speed * Time.deltaTime * Input.GetAxis(InputAxes.Horizontal2), Space.Self);
    }
}
