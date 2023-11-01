using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Hand_actions : MonoBehaviour
{


    [SerializeField] InputActionReference Grip_Action;
    [SerializeField] InputActionReference Trigger_Action;
    Animator HandAction;

    private void Start()
    {
        HandAction = GetComponent<Animator>();
    }

    private void OnEnable()
    {
        Grip_Action.action.performed += GripFuntion;
        Trigger_Action.action.performed += TriggerFuntion;
    }

    private void TriggerFuntion(InputAction.CallbackContext obj)
    {
        HandAction.SetFloat("Trigger", obj.ReadValue<float>());
    }

    private void GripFuntion(InputAction.CallbackContext obj)
    {
        HandAction.SetFloat("Grip", obj.ReadValue<float>());
    }

    private void OnDisable()
    {
        Grip_Action.action.performed -= GripFuntion;
        Trigger_Action.action.performed -= TriggerFuntion;
    }
}