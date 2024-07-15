using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class ButtonPushOpenDoor : MonoBehaviour
{
    public Animator _animator;
    public string boolName = "Poke_Open";
    void Start()
    {
        GetComponent<XRSimpleInteractable>().selectEntered.AddListener(x => DoorOpen()); // this basically means that when we select(press button), DoorOpen method will be called.
        // this is similar to manually adding events on click
    }

    public void DoorOpen()
    {
        bool isOpen =  _animator.GetBool(boolName); // assgining the Poke_Open bool to a new bool isOpen
        _animator.SetBool(boolName, !isOpen); // changing the assigned bool to not isOpen 
    }
}
