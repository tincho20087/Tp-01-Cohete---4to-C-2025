using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotonScript : MonoBehaviour
{
    public GameObject botonGO;


    private void OnMouseDown()
    {
        botonGO.SetActive(false);
        Debug.Log("Click");
    }

    private void OnMouseUp()
    {
        botonGO.SetActive(true);
    }

}
