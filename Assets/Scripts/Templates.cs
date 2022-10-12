using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Templates : MonoBehaviour
{
    public GameObject player;
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }
}
