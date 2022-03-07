using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class RoomStart : MonoBehaviour
{
    [SerializeField] private Text _countdown;
    [SerializeField] private float countdownDuration;
    [SerializeField] private GameManager gameManager;
    public float time
    {
        get
        {
            // Calculate how much time has passed
            return (float)(countdownDuration -= Time.deltaTime) ;
        }
    }

    private void Start()
    {
        StartCountdown();
    }


    public void StartCountdown()
    {
        StartCoroutine(UpdateTime());
    }
    IEnumerator UpdateTime()
    {
        TimeSpan timeSpan = TimeSpan.FromSeconds(time);
        while (timeSpan.Seconds > 0)
        {
            timeSpan = TimeSpan.FromSeconds(time);
            _countdown.text = "Game Starts In: " + timeSpan.Seconds ;
            yield return null;
        }
        gameManager.StartGame();
        gameObject.SetActive(false);

    }
}
