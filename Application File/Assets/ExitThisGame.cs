using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitThisGame : MonoBehaviour
{
    public void ExitGame()
    {
    	//Just to make sure its Working

    	UnityEngine.Debug.LogError("Exit Game");
    	Application.Quit();
    	
    }
}
