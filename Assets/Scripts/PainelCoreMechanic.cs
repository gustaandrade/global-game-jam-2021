using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PainelCoreMechanic : MonoBehaviour
{
    [Header("Sprite a Modificar")]
    public SpriteRenderer eyes;

    [Header("Ciclo de Sprites")]
    public List<Sprite> options = new List<Sprite>();

    private int currentOption = 0;

    public void NextOption()
    {
        currentOption++;
        if(currentOption >= options.Count)
        {
            currentOption = 0; //Resetar a lista
        }
        eyes.sprite = options[currentOption];
    }
}
