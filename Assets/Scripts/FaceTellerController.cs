using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;

public class FaceTellerController : MonoBehaviour
{
  [Header("Head Buttons")]
  public Button HeadLeftButton;
  public Button HeadRightButton;
  private int _headIndex = 0;

  [Header("Hair Buttons")]
  public Button HairLeftButton;
  public Button HairRightButton;
  private int _hairIndex = 0;

  [Header("Eyebrows Buttons")]
  public Button EyebrowsLeftButton;
  public Button EyebrowsRightButton;
  private int _eyebrowsIndex = 0;

  [Header("Eyes Buttons")]
  public Button EyesLeftButton;
  public Button EyesRightButton;
  private int _eyesIndex = 0;

  [Header("Nose Buttons")]
  public Button NoseLeftButton;
  public Button NoseRightButton;
  private int _noseIndex = 0;

  [Header("Mouth Buttons")]
  public Button MouthLeftButton;
  public Button MouthRightButton;
  private int _mouthIndex = 0;

  [Header("Detail Buttons")]
  public Button DetailLeftButton;
  public Button DetailRightButton;
  private int _detailIndex = 0;

  [Header("Beard Buttons")]
  public Button BeardLeftButton;
  public Button BeardRightButton;
  private int _beardIndex = 0;

  [Header("SkinTone Buttons")]
  public Button SkinToneLeftButton;
  public Button SkinToneRightButton;
  private int _skinToneIndex = 0;

  [Header("Printer Objects")]
  public Button PrinterButton;
  public Button GrabPaperFromPrinterButton;
  public RectTransform PaperImage;
  public Vector3 PaperImageOriginalPosition;

  [Header("Public Variables")]
  public List<FaceFeature> MyCrushFeatures;

  private List<string> _shuffledHead;
  private List<string> _shuffledHair;
  private List<string> _shuffledEyebrows;
  private List<string> _shuffledEyes;
  private List<string> _shuffledNose;
  private List<string> _shuffledMouth;
  private List<string> _shuffledDetail;
  private List<string> _shuffledBeard;
  private List<string> _shuffledSkinTone;

  private void Awake()
  {
    MyCrushFeatures = new List<FaceFeature>();
    InitializeFaceTeller();

    PaperImageOriginalPosition = PaperImage.anchoredPosition;
  }

  private void Update()
  {
    PrinterButton.interactable =
        !TimerController.Instance.IsPrinterPrinting && !TimerController.Instance.IsFaceTellerAvailable;
    GrabPaperFromPrinterButton.interactable =
        TimerController.Instance.IsFaceTellerAvailable;

    if (TimerController.Instance.IsPrinterPrinting)
    {
      PaperImage.anchoredPosition =
          new Vector3(0, PaperImage.anchoredPosition.y + -TimerController.Instance.CurrentPrinterTimer / 1.5f, 0);
    }
    else if (!TimerController.Instance.IsPrinterPrinting &&
            !TimerController.Instance.IsFaceTellerAvailable)
    {
      PaperImage.anchoredPosition = PaperImageOriginalPosition;
    }
  }

  private void InitializeFaceTeller()
  {
    _shuffledHead = new List<string>();
    _shuffledHair = new List<string>();
    _shuffledEyebrows = new List<string>();
    _shuffledEyes = new List<string>();
    _shuffledNose = new List<string>();
    _shuffledMouth = new List<string>();
    _shuffledDetail = new List<string>();
    _shuffledBeard = new List<string>();
    _shuffledSkinTone = new List<string>();

    _shuffledHead = Constants.RequestHeadTexts;
    _shuffledHead = _shuffledHead.Shuffle().ToList();
    _shuffledHair = Constants.RequestHairTexts.Shuffle().ToList();
    _shuffledHair = _shuffledHair.Shuffle().ToList();
    _shuffledEyebrows = Constants.RequestEyebrowsTexts.Shuffle().ToList();
    _shuffledEyebrows = _shuffledEyebrows.Shuffle().ToList();
    _shuffledEyes = Constants.RequestEyesTexts.Shuffle().ToList();
    _shuffledEyes = _shuffledEyes.Shuffle().ToList();
    _shuffledNose = Constants.RequestNoseTexts.Shuffle().ToList();
    _shuffledNose = _shuffledNose.Shuffle().ToList();
    _shuffledMouth = Constants.RequestMouthTexts.Shuffle().ToList();
    _shuffledMouth = _shuffledMouth.Shuffle().ToList();
    _shuffledDetail = Constants.RequestDetailTexts.Shuffle().ToList();
    _shuffledDetail = _shuffledDetail.Shuffle().ToList();
    _shuffledBeard = Constants.RequestBeardTexts.Shuffle().ToList();
    _shuffledBeard = _shuffledBeard.Shuffle().ToList();
    _shuffledSkinTone = Constants.RequestSkinToneTexts.Shuffle().ToList();
    _shuffledSkinTone = _shuffledSkinTone.Shuffle().ToList();

    HeadLeftButton.onClick.AddListener
        (() => ChangeFaceFeatureIndex(FaceFeature.Head, false));
    HeadRightButton.onClick.AddListener
        (() => ChangeFaceFeatureIndex(FaceFeature.Head, true));

    HairLeftButton.onClick.AddListener
        (() => ChangeFaceFeatureIndex(FaceFeature.Hair, false));
    HairRightButton.onClick.AddListener
        (() => ChangeFaceFeatureIndex(FaceFeature.Hair, true));

    EyebrowsLeftButton.onClick.AddListener
        (() => ChangeFaceFeatureIndex(FaceFeature.Eyebrows, false));
    EyebrowsRightButton.onClick.AddListener
        (() => ChangeFaceFeatureIndex(FaceFeature.Eyebrows, true));

    EyesLeftButton.onClick.AddListener
        (() => ChangeFaceFeatureIndex(FaceFeature.Eyes, false));
    EyesRightButton.onClick.AddListener
        (() => ChangeFaceFeatureIndex(FaceFeature.Eyes, true));

    NoseLeftButton.onClick.AddListener
        (() => ChangeFaceFeatureIndex(FaceFeature.Nose, false));
    NoseRightButton.onClick.AddListener
        (() => ChangeFaceFeatureIndex(FaceFeature.Nose, true));

    MouthLeftButton.onClick.AddListener
        (() => ChangeFaceFeatureIndex(FaceFeature.Mouth, false));
    MouthRightButton.onClick.AddListener
        (() => ChangeFaceFeatureIndex(FaceFeature.Mouth, true));

    DetailLeftButton.onClick.AddListener
        (() => ChangeFaceFeatureIndex(FaceFeature.Detail, false));
    DetailRightButton.onClick.AddListener
        (() => ChangeFaceFeatureIndex(FaceFeature.Detail, true));

    BeardLeftButton.onClick.AddListener
        (() => ChangeFaceFeatureIndex(FaceFeature.Beard, false));
    BeardRightButton.onClick.AddListener
        (() => ChangeFaceFeatureIndex(FaceFeature.Beard, true));

    SkinToneLeftButton.onClick.AddListener
        (() => ChangeFaceFeatureIndex(FaceFeature.SkinTone, false));
    SkinToneRightButton.onClick.AddListener
        (() => ChangeFaceFeatureIndex(FaceFeature.SkinTone, true));

    PrinterButton.onClick.AddListener
        (() =>
        {
          PrintFaceTeller();
          DeliverFaceTellerToPerson(PersonPosition.Left);
        });

    GrabPaperFromPrinterButton.onClick.AddListener
        (() => TimerController.Instance.GrabFaceTellerFromPrinter());
  }

  private void ChangeFaceFeatureIndex(FaceFeature feature, bool goingUp)
  {
    switch (feature)
    {
      case FaceFeature.Head:
        if (goingUp)
        {
          if (_headIndex == _shuffledHead.Count - 1)
            _headIndex = 0;
          else
            _headIndex++;
        }
        else
        {
          if (_headIndex == 0)
            _headIndex = _shuffledHead.Count - 1;
          else
            _headIndex--;
        }
        break;

      case FaceFeature.Hair:
        if (goingUp)
        {
          if (_hairIndex == _shuffledHair.Count - 1)
            _hairIndex = 0;
          else
            _hairIndex++;
        }
        else
        {
          if (_hairIndex == 0)
            _hairIndex = _shuffledHair.Count - 1;
          else
            _hairIndex--;
        }
        break;

      case FaceFeature.Eyebrows:
        if (goingUp)
        {
          if (_eyebrowsIndex == _shuffledEyebrows.Count - 1)
            _eyebrowsIndex = 0;
          else
            _eyebrowsIndex++;
        }
        else
        {
          if (_eyebrowsIndex == 0)
            _eyebrowsIndex = _shuffledEyebrows.Count - 1;
          else
            _eyebrowsIndex--;
        }
        break;

      case FaceFeature.Eyes:
        if (goingUp)
        {
          if (_eyesIndex == _shuffledEyes.Count - 1)
            _eyesIndex = 0;
          else
            _eyesIndex++;
        }
        else
        {
          if (_eyesIndex == 0)
            _eyesIndex = _shuffledEyes.Count - 1;
          else
            _eyesIndex--;
        }
        break;

      case FaceFeature.Nose:
        if (goingUp)
        {
          if (_noseIndex == _shuffledNose.Count - 1)
            _noseIndex = 0;
          else
            _noseIndex++;
        }
        else
        {
          if (_noseIndex == 0)
            _noseIndex = _shuffledNose.Count - 1;
          else
            _noseIndex--;
        }
        break;

      case FaceFeature.Mouth:
        if (goingUp)
        {
          if (_mouthIndex == _shuffledMouth.Count - 1)
            _mouthIndex = 0;
          else
            _mouthIndex++;
        }
        else
        {
          if (_mouthIndex == 0)
            _mouthIndex = _shuffledMouth.Count - 1;
          else
            _mouthIndex--;
        }
        break;

      case FaceFeature.Detail:
        if (goingUp)
        {
          if (_detailIndex == _shuffledDetail.Count - 1)
            _detailIndex = 0;
          else
            _detailIndex++;
        }
        else
        {
          if (_detailIndex == 0)
            _detailIndex = _shuffledDetail.Count - 1;
          else
            _detailIndex--;
        }
        break;

      case FaceFeature.Beard:
        if (goingUp)
        {
          if (_beardIndex == _shuffledBeard.Count - 1)
            _beardIndex = 0;
          else
            _beardIndex++;
        }
        else
        {
          if (_beardIndex == 0)
            _beardIndex = _shuffledBeard.Count - 1;
          else
            _beardIndex--;
        }
        break;

      case FaceFeature.SkinTone:
        if (goingUp)
        {
          if (_skinToneIndex == _shuffledSkinTone.Count - 1)
            _skinToneIndex = 0;
          else
            _skinToneIndex++;
        }
        else
        {
          if (_skinToneIndex == 0)
            _skinToneIndex = _shuffledSkinTone.Count - 1;
          else
            _skinToneIndex--;
        }
        break;

      default: break;
    }
  }

  private void PrintFaceTeller()
  {
    TimerController.Instance.StartPrinting();
    PrinterButton.interactable = false;
  }

  private void DeliverFaceTellerToPerson(PersonPosition person)
  {
    if (person == PersonPosition.Left)
    {
      TimerController.Instance.LeftRequestFaceFeatures.ForEach(lrf =>
      {
        switch (lrf)
        {
          case FaceFeature.Head:
            if (TimerController.Instance.LeftRequestFaceFeaturesDetailed.Any(ffd => ffd == _shuffledHead.ElementAt(_headIndex)))
              TimerController.Instance.NumberOfLeftCorrectMatches++;

            break;

          case FaceFeature.Hair:
            if (TimerController.Instance.LeftRequestFaceFeaturesDetailed.Any(ffd => ffd == _shuffledHair.ElementAt(_hairIndex)))
              TimerController.Instance.NumberOfLeftCorrectMatches++;

            break;

          case FaceFeature.Eyebrows:
            if (TimerController.Instance.LeftRequestFaceFeaturesDetailed.Any(ffd => ffd == _shuffledEyebrows.ElementAt(_eyebrowsIndex)))
              TimerController.Instance.NumberOfLeftCorrectMatches++;

            break;

          case FaceFeature.Eyes:
            if (TimerController.Instance.LeftRequestFaceFeaturesDetailed.Any(ffd => ffd == _shuffledEyes.ElementAt(_eyesIndex)))
              TimerController.Instance.NumberOfLeftCorrectMatches++;

            break;

          case FaceFeature.Nose:
            if (TimerController.Instance.LeftRequestFaceFeaturesDetailed.Any(ffd => ffd == _shuffledNose.ElementAt(_noseIndex)))
              TimerController.Instance.NumberOfLeftCorrectMatches++;

            break;

          case FaceFeature.Mouth:
            if (TimerController.Instance.LeftRequestFaceFeaturesDetailed.Any(ffd => ffd == _shuffledMouth.ElementAt(_mouthIndex)))
              TimerController.Instance.NumberOfLeftCorrectMatches++;

            break;

          case FaceFeature.Detail:
            if (TimerController.Instance.LeftRequestFaceFeaturesDetailed.Any(ffd => ffd == _shuffledDetail.ElementAt(_detailIndex)))
              TimerController.Instance.NumberOfLeftCorrectMatches++;

            break;

          case FaceFeature.Beard:
            if (TimerController.Instance.LeftRequestFaceFeaturesDetailed.Any(ffd => ffd == _shuffledBeard.ElementAt(_beardIndex)))
              TimerController.Instance.NumberOfLeftCorrectMatches++;

            break;

          case FaceFeature.SkinTone:
            if (TimerController.Instance.LeftRequestFaceFeaturesDetailed.Any(ffd => ffd == _shuffledSkinTone.ElementAt(_skinToneIndex)))
              TimerController.Instance.NumberOfLeftCorrectMatches++;

            break;

          default: break;
        }
      });
    }
    else
    {
      TimerController.Instance.RightRequestFaceFeatures.ForEach(rrf =>
      {
        switch (rrf)
        {
          case FaceFeature.Head:
            if (TimerController.Instance.LeftRequestFaceFeaturesDetailed.Any(ffd => ffd == _shuffledHead.ElementAt(_headIndex)))
              TimerController.Instance.NumberOfRightCorrectMatches++;

            break;

          case FaceFeature.Hair:
            if (TimerController.Instance.LeftRequestFaceFeaturesDetailed.Any(ffd => ffd == _shuffledHair.ElementAt(_hairIndex)))
              TimerController.Instance.NumberOfRightCorrectMatches++;

            break;

          case FaceFeature.Eyebrows:
            if (TimerController.Instance.LeftRequestFaceFeaturesDetailed.Any(ffd => ffd == _shuffledEyebrows.ElementAt(_eyebrowsIndex)))
              TimerController.Instance.NumberOfRightCorrectMatches++;

            break;

          case FaceFeature.Eyes:
            if (TimerController.Instance.LeftRequestFaceFeaturesDetailed.Any(ffd => ffd == _shuffledEyes.ElementAt(_eyesIndex)))
              TimerController.Instance.NumberOfRightCorrectMatches++;

            break;

          case FaceFeature.Nose:
            if (TimerController.Instance.LeftRequestFaceFeaturesDetailed.Any(ffd => ffd == _shuffledNose.ElementAt(_noseIndex)))
              TimerController.Instance.NumberOfRightCorrectMatches++;

            break;

          case FaceFeature.Mouth:
            if (TimerController.Instance.LeftRequestFaceFeaturesDetailed.Any(ffd => ffd == _shuffledMouth.ElementAt(_mouthIndex)))
              TimerController.Instance.NumberOfRightCorrectMatches++;

            break;

          case FaceFeature.Detail:
            if (TimerController.Instance.LeftRequestFaceFeaturesDetailed.Any(ffd => ffd == _shuffledDetail.ElementAt(_detailIndex)))
              TimerController.Instance.NumberOfRightCorrectMatches++;

            break;

          case FaceFeature.Beard:
            if (TimerController.Instance.LeftRequestFaceFeaturesDetailed.Any(ffd => ffd == _shuffledBeard.ElementAt(_beardIndex)))
              TimerController.Instance.NumberOfRightCorrectMatches++;

            break;

          case FaceFeature.SkinTone:
            if (TimerController.Instance.LeftRequestFaceFeaturesDetailed.Any(ffd => ffd == _shuffledSkinTone.ElementAt(_skinToneIndex)))
              TimerController.Instance.NumberOfRightCorrectMatches++;

            break;

          default: break;
        }
      });
    }

    Debug.Log("Requested items:");
    TimerController.Instance.LeftRequestFaceFeaturesDetailed.ForEach(lff => Debug.Log(lff));
    Debug.Log("Delivered hair items:");
    Debug.Log(_shuffledSkinTone.ElementAt(_skinToneIndex));
    Debug.Log($"Left Correct: {TimerController.Instance.NumberOfLeftCorrectMatches}");

    TimerController.Instance.ResetCorrectNumbers();
  }
}
