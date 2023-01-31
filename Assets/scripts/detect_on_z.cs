using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class detect_on_z : MonoBehaviour
{
    public GameObject left_door;
    public GameObject right_door;

    public float maximumOpening = 0.01152f;
    public float maximumClosing = 0f;

    public float movementSpeed = 1f;

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
            if (left_door.transform.localPosition.z > -maximumOpening)
            {

                left_door.transform.Translate(0, 0f, -movementSpeed * Time.deltaTime);
                right_door.transform.Translate(0, 0f, movementSpeed * Time.deltaTime);
            }

        }
        else
        {
            if (left_door.transform.localPosition.z < 0)
            {
                right_door.transform.Translate(0, 0f, -movementSpeed * Time.deltaTime);
                left_door.transform.Translate(0, 0f, movementSpeed * Time.deltaTime);
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
