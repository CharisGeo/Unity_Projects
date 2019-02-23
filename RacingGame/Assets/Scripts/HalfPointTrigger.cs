using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HalfPointTrigger : MonoBehaviour
{
    public GameObject LapComepleteTrig;
    public GameObject HalfLapTrig;

    private void OnTriggerEnter(Collider other)
    {
        LapComepleteTrig.SetActive(true);
        HalfLapTrig.SetActive(false);
    }
}
