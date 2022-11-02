using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
   // public GameObject Player;
    public Rigidbody Player;
    private Vector3 mover;

    [SerializeField] float speed = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.A))
        {
            Player.velocity = new Vector3(-1 * speed, 0, 0);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            Player.velocity = new Vector3(1 * speed, 0, 0);
        }
    }
}
