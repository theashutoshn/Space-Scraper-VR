using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;
public class DisableHandGrabbingModel : MonoBehaviour
{
    public GameObject leftHandModel;
    public GameObject rightHandModel;

    void Start()
    {
        XRGrabInteractable grabinteractable = GetComponent<XRGrabInteractable>();
        grabinteractable.selectEntered.AddListener(HideGrabbingHand);
        grabinteractable.selectExited.AddListener(ShowGrabbingHand);
    }

    public void HideGrabbingHand(SelectEnterEventArgs  args)
    {
        if(args.interactorObject.transform.tag == "Left Hand")
        {
            leftHandModel.SetActive(false);
        }
        else if(args.interactorObject.transform.tag == "Right Hand")
        {
            rightHandModel.SetActive(false);
        }
    }

    public void ShowGrabbingHand(SelectExitEventArgs args)
    {
        if (args.interactorObject.transform.tag == "Left Hand")
        {
            leftHandModel.SetActive(true);
        }
        else if (args.interactorObject.transform.tag == "Right Hand")
        {
            rightHandModel.SetActive(true);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
