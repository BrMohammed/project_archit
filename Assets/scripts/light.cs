using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class light : MonoBehaviour
{
    public GameObject _light;
    

    bool playerIsHere;
    public float secsToNext = 0.1f;

    // Start is called before the first frame update
    void Start()
    {
        playerIsHere = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (playerIsHere && Input.GetKeyUp("l") )
        {
            FindObjectOfType<AudioManager>().Play("light");
            _light.SetActive(!_light.activeSelf);
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
