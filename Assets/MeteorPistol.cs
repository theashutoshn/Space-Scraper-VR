using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;
public class MeteorPistol : MonoBehaviour
{
    public ParticleSystem particles;
    public LayerMask layerMask;
    public Transform shootSource;
    private float shootDistance = 10f;
    private bool isRayCastActive;

    public void Start()
    {
        XRGrabInteractable grabInteractable = GetComponent<XRGrabInteractable>();
        //grabInteractable.activated.AddListener(x => StartShoot());
        //grabInteractable.deactivated.AddListener(x => StopShoot());
    }

    void Update()
    {
        if(isRayCastActive)
        {
            RayCastCheck();
        }
    }

    public void StartShoot()
    {
        particles.Play();
        isRayCastActive = true;
    }

    public void StopShoot()
    {
        particles.Stop(true, ParticleSystemStopBehavior.StopEmittingAndClear);
        isRayCastActive = false;
    }

    void RayCastCheck()
    {
        RaycastHit hit;
        bool ishit = Physics.Raycast(shootSource.transform.position, shootSource.forward, out hit, shootDistance,layerMask);

        if(ishit)
        {
            hit.transform.gameObject.SendMessage("Break", SendMessageOptions.DontRequireReceiver);
        }

    }
}
