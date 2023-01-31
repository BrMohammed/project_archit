using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class detect : MonoBehaviour
{
    public GameObject left_door;
    public GameObject right_door;

    public float maximumOpening = 0.0077f;
    public float maximumClosing = 0f;

    public float movementSpeed = 0.001f;

    bool playerIsHere;

    // Start is called before the first frame update
    void Start()
    {
        playerIsHere = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (playerIsHere)
        {
            if (left_door.transform.localPosition.x > -maximumOpening)
            {
                left_door.transform.Translate(-movementSpeed * Time.deltaTime, 0f, 0f);
                right_door.transform.Translate(movementSpeed * Time.deltaTime, 0f, 0f);
            }
                
        }
        else
        {
            if (left_door.transform.localPosition.x < 0)
            {
                right_door.transform.Translate(-movementSpeed * Time.deltaTime, 0f, 0f);
                left_door.transform.Translate(movementSpeed * Time.deltaTime, 0f, 0f);
            }
                
        }


    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "PlayerArmature")
            playerIsHere = true;
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name == "PlayerArmature")
            playerIsHere = false;
    }
}
