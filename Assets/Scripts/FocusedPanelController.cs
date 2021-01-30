using System;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class FocusedPanelController : MonoBehaviour
{
  [Header("Public References")]
  public List<FocusedPanelType> PanelStates;

  private void Awake()
  {
    PanelStates = new List<FocusedPanelType>();
  }

  private void ChangeToState(FocusedPanel nextPanel)
  {
    PanelStates.ForEach(ps => ps.gameObject.SetActive(false));

    if (nextPanel != FocusedPanel.Off)
      PanelStates.FirstOrDefault(ps => ps.PanelType == nextPanel).gameObject.SetActive(true);
  }
}

[Serializable]
public enum FocusedPanel
{
  Computer,
  Printer,
  Person,
  Off
}
