using UnityEngine;
using UnityEngine.UI;

public class PlayerActionController : MonoBehaviour
{
  [Header("Player Action Buttons")]
  public Button LeftPersonQuest;
  public Button RightPersonQuest;
  public Button ComputerAction;
  public Button PrinterAction;

  [Header("Public References")]
  public FocusedPanelController PanelController;

  private void Awake()
  {
    LeftPersonQuest.onClick.AddListener(
        () => PanelController.ChangeToState(FocusedPanel.Person));
    RightPersonQuest.onClick.AddListener(
        () => PanelController.ChangeToState(FocusedPanel.Person));
    ComputerAction.onClick.AddListener(
        () => PanelController.ChangeToState(FocusedPanel.Computer));
    PrinterAction.onClick.AddListener(
        () => PanelController.ChangeToState(FocusedPanel.Printer));
  }
}
