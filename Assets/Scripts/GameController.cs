using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject printFeedback;

    public GameObject eye;
    public GameObject nose;
    public GameObject mouth;
    public bool isPrinted = false;

    public int[] faceCod = {0,0,0};

    public void Print()
    {
        faceCod[0] = eye.GetComponent<PainelCoreMechanic>().currentOption;
        faceCod[1] = nose.GetComponent<PainelCoreMechanic>().currentOption;
        faceCod[2] = mouth.GetComponent<PainelCoreMechanic>().currentOption;
        isPrinted = true;
    }

    private void Update()
    {
        if (isPrinted)
        {
            printFeedback.SetActive(true);
        }
        else
        {
            printFeedback.SetActive(false);
        }
    }
}
