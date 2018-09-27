using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class NextScene : DialogueTrigger
{


    public override void FireTrigger()
    {
        if (triggerOnce && triggered)
        {
            return;
        }
        triggered = true;
        SceneManager.LoadScene("Scene2");
    }
}
