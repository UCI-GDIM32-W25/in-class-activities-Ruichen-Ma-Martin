using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Locator : MonoBehaviour
{
    public static Locator Instance{get; private set;}
    public W4Pigeon player{get; private set;}
    private void Awake()
    {if(Instance !=null && Instance != this)
        {
            Destroy(this);
            return;
        }
    Instance = this;

    GameObject playerBject = GameObject.FindWithTag("Player");
    player = playerBject.GetComponent<W4Pigeon>();

    }
    

}