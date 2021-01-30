using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject eye;
    public GameObject nose;
    public GameObject mouth;

    public int[] faceCod = {0,0,0};

    public void Complete()
    {
        faceCod[0] = eye.GetComponent<PainelCoreMechanic>().currentOption;
        faceCod[1] = nose.GetComponent<PainelCoreMechanic>().currentOption;
        faceCod[2] = mouth.GetComponent<PainelCoreMechanic>().currentOption;
        print(faceCod[0]);
        print(faceCod[1]);
        print(faceCod[2]);
    }
}
