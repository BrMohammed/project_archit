using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatMish : MonoBehaviour
{
    public GameObject new_player;
    // Start is called before the first frame update
    void Start()
    {
        
        GameObject[] msh = FindObjectsOfType<GameObject>();
        foreach (GameObject childObject in msh)
        {
            if (childObject.transform.GetComponent<MeshRenderer>() != null)
            {
               childObject.AddComponent<MeshCollider>();
            }
        }
    }

}
