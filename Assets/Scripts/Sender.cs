/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sender : MonoBehaviour
{
    public delegate void PlayerDied();
    public static event PlayerDied PlayerDiedInfo;

    private bool isAlive;

    void Start()
    {
        Invoke("ExecuteEvent", 3f);
    }
    void ExecuteEvent()
    {
      //  if(isAlive == false)
        if(PlayerDiedInfo != null)
        {
            PlayerDiedInfo();
        }
    }



}
*/