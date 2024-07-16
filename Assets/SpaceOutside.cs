using System.Collections;
using System.Collections.Generic;
using Unity.XR.CoreUtils.GUI;
using UnityEngine;
using UnityEngine.XR.Content.Interaction;

public class SpaceOutside : MonoBehaviour
{
    public XRLever lever;
    public XRKnob knob;

    public float forwardSpeed;
    public float sideSpeed;

    private bool wasOn = false;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float forwardVelocity = forwardSpeed * (lever.value ? 0 : 1); // (lever.value ? 1 : 0) I swapped the value based on my lever position on my model
        float sideVelocity = sideSpeed * (lever.value ? 0 : 1) * Mathf.Lerp(-1, 1, knob.value);

        Vector3 velocity = new Vector3(sideVelocity, 0, forwardVelocity);
        transform.position += velocity * Time.deltaTime;

        if(lever.value != wasOn)
        {

            if(lever.value)
            {
                AudioManager.instance.Play("Spaceship Engine");
            }
            else
            {
                AudioManager.instance.Stop("Spaceship Engine");
            }
        }

        wasOn = lever.value;


    }
}
