using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    void Awake()
    {
        BlockManager.instance = gameObject.AddComponent<BlockManager>();
    }

    void Update()
    {
        
    }
}
