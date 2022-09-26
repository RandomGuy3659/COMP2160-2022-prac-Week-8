using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
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
        transform.Translate(Vector3.forward * speed * Time.deltaTime * Input.GetAxis(InputAxes.Vertical), Space.Self);
        transform.Translate(new Vector3(0, -1, 0) * speed * Time.deltaTime * Input.GetAxis(InputAxes.Horizontal), Space.Self);
    }
}
