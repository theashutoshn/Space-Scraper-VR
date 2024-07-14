using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class TrashCan : MonoBehaviour
{
    public void Start()
    {
        GetComponent<TriggerZone>().OnEnterEvent.AddListener(InsideTrash);
    }
    public void InsideTrash(GameObject go)
    {
        go.SetActive(false);
    }
}
