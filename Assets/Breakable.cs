using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.Events;

public class Breakable : MonoBehaviour
{
    public List<GameObject> breakableItems;
    private float timeToBreak = 2f;
    private float currentTime = 0;
    public UnityEvent OnBreak;
    void Start()
    {
        foreach(var item in breakableItems)
        {
            item.SetActive(false);

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Break()
    {
        currentTime += Time.deltaTime;
        if(currentTime > timeToBreak)
        {
            foreach(var item in breakableItems)
            {
                item.SetActive(true);
                item.transform.parent = null;
            }
            OnBreak.Invoke();

            gameObject.SetActive(false);

        }        
    }    
}
