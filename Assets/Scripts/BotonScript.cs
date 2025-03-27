using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotonScript : MonoBehaviour
{
    public GameObject botonGO;
    public CoheteScript cohetescript;

    private void OnMouseDown()
    {
        botonGO.SetActive(false);
        cohetescript.despegue();
        
    }

    private void OnMouseUp()
    {
        botonGO.SetActive(true);
    }

}
