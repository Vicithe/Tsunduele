using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadGameScene : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        //If statement is placeholder for now.
        //Will determine once the Load screen is created what the trigger is to load the main game screen
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene("GameScene");
        }
    }
}
