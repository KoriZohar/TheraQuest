using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class AnimateHandOnInput : MonoBehaviour
{
    // create custom component - InputActionProperty variable, via marking as public it allows to use it in Unity. 
    public InputActionProperty pinchAnimationAction;
    public InputActionProperty gripAnimationAction;

    public Animator handAnimator;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame by Unity
    void Update()
    {
        // to know if the player is calling the action we shall set it in "update" function
        // the action for trigger is set as value, that indicates how much it is pressed so "float" shall be suitable
        // if we shall use an action that only tells yes \ no (pressed \ not) it is better to set as "bool"

        float triggerValue = pinchAnimationAction.action.ReadValue<float>();
        handAnimator.SetFloat("Trigger", triggerValue);
        
        //Debug.Log(triggerValue);

        float gripValue = gripAnimationAction.action.ReadValue<float>();
        handAnimator.SetFloat("Grip", gripValue);
    }
}
