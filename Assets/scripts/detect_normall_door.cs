using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class detect_normall_door : MonoBehaviour
{
    public GameObject door;
    public float smooth = 50f;

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
            if(door.transform.rotation.eulerAngles.y > 271 || door.transform.rotation.eulerAngles.y == 0)
                door.transform.Rotate(Vector3.down, smooth * Time.deltaTime, Space.World);
        }
        else
        {
            if (door.transform.rotation.eulerAngles.y < 359 && door.transform.rotation.eulerAngles.y > 269)
                door.transform.Rotate(Vector3.up, smooth * Time.deltaTime, Space.World);
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "PlayerArmature")
        {
            FindObjectOfType<AudioManager>().Play("open_normal");
        }
            playerIsHere = true;
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name == "PlayerArmature")
        {
            FindObjectOfType<AudioManager>().Play("open_normal");
            playerIsHere = false;
        }
            
    }
}
