using UnityEngine;
using System.Collections.Generic;
using System.Collections;

public class BoxScare : MonoBehaviour
{
    public GameObject boxHolder;

    void OnTriggerEnter(Collider other)
    {
        boxHolder.SetActive(false);
    }


}
