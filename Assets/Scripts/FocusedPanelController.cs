using System;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.UI;

public class FocusedPanelController : MonoBehaviour
{
  private List<FocusedPanelType> _panelStates;

  private void Awake()
  {
    _panelStates = new List<FocusedPanelType>();
    _panelStates = GetComponentsInChildren<FocusedPanelType>().ToList();
  }

  public void ChangeToState(FocusedPanel nextPanel)
  {
    _panelStates.ForEach
        (ps => ps.transform.GetComponentInChildren<Image>().enabled = false);

    if (nextPanel != FocusedPanel.Off)
      _panelStates.FirstOrDefault(ps => ps.PanelType == nextPanel)
        .transform.GetComponentInChildren<Image>().enabled = true;
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
