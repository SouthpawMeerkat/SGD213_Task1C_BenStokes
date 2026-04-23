using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInputs : MonoBehaviour
{
    private PlayerMovementScript playermovementscript;
    private ShootingScript shootingscript;

    // Start is called before the first frame update
    void Start()
    {
        playermovementscript = GetComponent<PlayerMovementScript>();
        shootingscript = GetComponent<ShootingScript>();
    }

    // Update is called once per frame
    void Update()
    {
        float input = Input.GetAxis("Horizontal");
        // Shooting Input is fist mouse button
        if (Input.GetButton("Fire1"))
        {
            shootingscript.Shoot();
        }
        // Movement input A,D,Left Arrow key, Right Arrow key
        if (input != 0.0f) 
        {
            playermovementscript.Move(input);
        }
    }
}
