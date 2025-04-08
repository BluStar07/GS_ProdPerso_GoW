using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;


public class PlayTimeline : MonoBehaviour
{
    public PlayableDirector playableDirector;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        { 
        playableDirector.Play();
        }
    }
}
