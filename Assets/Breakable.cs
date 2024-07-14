using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class Breakable : MonoBehaviour
{
    public List<GameObject> breakableItems;
    private float timeToBreak = 2f;
    private float currentTime = 0;
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
        currentTime = Time.deltaTime;
        if(currentTime > timeToBreak)
        {
            foreach(var item in breakableItems)
            {
                item.SetActive(true);
                item.transform.parent = null;
            }
            gameObject.SetActive(false);

        }        
    }    
}
