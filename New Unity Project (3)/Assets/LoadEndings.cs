using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadGameScene : MonoBehaviour
{
    private int my_pride;
    private int my_love;
    private int npc_pride;
    private int npc_love;

    private void Start()
    {
        //this is all placeholder for now
        //I think what the script will end up having to be is that in Fungus, whichever ending scene you get sets some flag to determine which ending your receive
        my_pride = 0;
        my_love = 0;
        npc_pride = 0;
        npc_love = 0;
    }

    // Update is called once per frame
    void Update()
    {
        //If statements are placeholder for now.
        //Will determine once the Ending scenes are created what the trigger is to load each one
        if (my_pride >= my_love && npc_pride >= npc_love)
        {
            SceneManager.LoadScene("NeutralEnding");
        }

        if (my_pride >= my_love && npc_pride < npc_love)
        {
            SceneManager.LoadScene("GoodEnding");
        }

        if (my_pride < my_love && npc_pride >= npc_love)
        {
            SceneManager.LoadScene("BadEnding");
        }
    }
}
