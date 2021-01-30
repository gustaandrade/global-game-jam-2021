using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Client : MonoBehaviour
{
    public Request request;
    public GameObject game;
    public GameObject dialogWindow;
    public Text dialogText;
    public int[] faceCod;
    public Text requestText; //Apenas teste

    public void OpenDialog()
    {
        request.isActive = true;
        dialogWindow.SetActive(true);
        dialogText.text = request.dialog;
        requestText.text = string.Join("", request.faceCharacteristics);
    }

    public bool CheckFace()
    {
        faceCod = game.GetComponent<GameController>().faceCod;
        return (string.Join("", request.faceCharacteristics) == string.Join("", faceCod));
    }

    public void GivePortrait()
    {
        if (request.isActive)
        {
            if (CheckFace())
            {
                print("Congratulations!");
            }
            else
            {
                print("You Lost!");
                print(string.Join("", request.faceCharacteristics));
                print(string.Join("", faceCod));
            }
        }
        else
        {
            print("Innactive Quest!");
        }
    }

}
