using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Events;

public class timer : MonoBehaviour
{
    public TMP_Text displayTimeText;

    private float currentTime = 75;
    private float displayTime;

    public UnityEvent gameOverEvent;

    private void Update()
    {
        currentTime -= Time.deltaTime;
        displayTime = Mathf.Round(currentTime);
        displayTimeText.text = displayTime.ToString() + "s";

        if (currentTime < 0)
        {
            Time.timeScale = 0;
            Debug.Log("Game Over");

            gameOverEvent.Invoke();
            displayTimeText.text = "GAME OVER";
        }
    }
}
