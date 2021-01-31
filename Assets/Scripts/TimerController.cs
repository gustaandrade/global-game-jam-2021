using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class TimerController : MonoBehaviour
{
  [Header("Singleton Instance")]

  public static TimerController Instance;

  [Header("Public Variables")]
  public float CurrentGlobalTimer;
  public float CurrentPrinterTimer;
  public float TimeForPrinterToPrint = 5f;
  public bool IsPrinterPrinting = false;
  public bool IsFaceTellerAvailable = false;
  public int NumberOfLeftCorrectMatches = 0;
  public int NumberOfRightCorrectMatches = 0;


  [Range(4, 9)]
  public int FeaturesToShuffle = 4;

  [Header("Requested Crushes")]
  public List<FaceFeature> LeftRequestFaceFeatures;
  public List<FaceFeature> RightRequestFaceFeatures;

  public List<string> LeftRequestFaceFeaturesDetailed;
  public List<string> RightRequestFaceFeaturesDetailed;

  private void Awake()
  {
    if (Instance == null)
      Instance = this;

    LeftRequestFaceFeatures = new List<FaceFeature>();
    RightRequestFaceFeatures = new List<FaceFeature>();
  }

  private void Update()
  {
    CurrentGlobalTimer += Time.deltaTime;

    if (IsPrinterPrinting && !IsFaceTellerAvailable)
    {
      Debug.Log($"printing... {CurrentPrinterTimer}");
      CurrentPrinterTimer += Time.deltaTime;

      if (CurrentPrinterTimer >= TimeForPrinterToPrint)
      {
        Debug.Log($"done... {CurrentPrinterTimer}");

        IsPrinterPrinting = false;
        CurrentPrinterTimer = 0f;
        IsFaceTellerAvailable = true;
      }
    }
  }

  public List<FaceFeature> RequestNextCrushFeatures(PersonPosition position)
  {
    ResetCorrectNumbers();

    var tempList = Constants.AllFaceFeatures;
    if (position == PersonPosition.Left)
    {
      LeftRequestFaceFeatures = tempList.Shuffle().Take(FeaturesToShuffle).OrderBy(ff => (int)ff).ToList();
      return LeftRequestFaceFeatures;
    }
    else
    {
      RightRequestFaceFeatures = tempList.Shuffle().Take(FeaturesToShuffle).OrderBy(ff => (int)ff).ToList();
      return RightRequestFaceFeatures;
    }
  }

  public void RecordCrushFeaturesDetailed(List<string> detailsList, PersonPosition position)
  {
    if (position == PersonPosition.Left)
    {
      LeftRequestFaceFeaturesDetailed = detailsList;
    }
    else
    {
      RightRequestFaceFeaturesDetailed = detailsList;
    }
  }

  public void ResetCorrectNumbers()
  {
    NumberOfLeftCorrectMatches = 0;
    NumberOfRightCorrectMatches = 0;
  }

  public void StartPrinting()
  {
    IsPrinterPrinting = true;
  }

  public void GrabFaceTellerFromPrinter()
  {
    IsFaceTellerAvailable = false;
  }
}

public enum PersonPosition
{
  Left,
  Right
}