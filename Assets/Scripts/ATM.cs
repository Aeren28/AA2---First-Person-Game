using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ATM : MonoBehaviour
{
    public GameObject atmScreen;

    myContents inputActions;

    public UnityEvent myAction;

    private void Awake()
    {
        inputActions = new myContents();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("Entered Space");
            LeanTween.scale(atmScreen, Vector3.one, 2);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("Left the Space");
            LeanTween.scale(atmScreen, Vector3.zero, 2);
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            if (inputActions.Player.ActionKey.WasPerformedThisFrame())
            {
                Debug.Log("I pressed the button");
                myAction.Invoke();  
            }
        }
    }

    public void OnEnable()
    {
        inputActions.Player.Enable();
    }

    public void OnDisable()
    {
        inputActions.Player.Disable();
    }
}
