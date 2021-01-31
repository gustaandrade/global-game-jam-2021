using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;
using System.Text;

public class RequestCrush : MonoBehaviour
{
  [Header("Public References")]
  public Text RequestText;
  public Button RequestButton;

  [Header("Public Variables")]
  public List<FaceFeature> MyCrushFeatures;

  private void Awake()
  {
    MyCrushFeatures = new List<FaceFeature>();

    RequestButton.onClick.AddListener(RequestMyCrush);
  }

  private void RequestMyCrush()
  {
    MyCrushFeatures = TimerController.Instance.RequestNextCrushFeatures();

    RequestText.text =
        $"{Constants.RequestIntroBaseTexts.Shuffle().FirstOrDefault()}\n\n" +
        $"{Constants.RequestBaseTexts.Shuffle().FirstOrDefault()} " +
        $"{CombineFaceFeatures(MyCrushFeatures)}\n";
  }

  private string CombineFaceFeatures(List<FaceFeature> faceFeatures)
  {
    var faceStringBuilder = new StringBuilder("");

    faceFeatures.ForEach(ff =>
    {
      if (ff.Equals(faceFeatures.Last()))
      {
        faceStringBuilder.Length = faceStringBuilder.Length - 2;
        faceStringBuilder.Append(" and ");
      }

      switch (ff)
      {
        case FaceFeature.Head:
          var randomHead = Constants.RequestHeadTypeTexts.Shuffle().FirstOrDefault();
          faceStringBuilder.Append(randomHead);
          break;

        case FaceFeature.Hair:
          var randomHairType = Constants.RequestHairTypeTexts.Shuffle().FirstOrDefault();
          var randomHairColor = Constants.RequestHairColorTexts.Shuffle().FirstOrDefault();
          faceStringBuilder.Append(randomHairType);
          faceStringBuilder.Append(" ");
          faceStringBuilder.Append(randomHairColor);
          break;

        case FaceFeature.Eyebrows:
          var randomEyebrow = Constants.RequestEyebrowTypeTexts.Shuffle().FirstOrDefault();
          faceStringBuilder.Append(randomEyebrow);
          break;

        case FaceFeature.Eyes:
          var randomEyesType = Constants.RequestEyesTypeTexts.Shuffle().FirstOrDefault();
          var randomEyesColor = Constants.RequestEyesColorTexts.Shuffle().FirstOrDefault();
          faceStringBuilder.Append(randomEyesType);
          faceStringBuilder.Append(" ");
          faceStringBuilder.Append(randomEyesColor);
          break;

        case FaceFeature.Nose:
          var randomNose = Constants.RequestNoseTypeTexts.Shuffle().FirstOrDefault();
          faceStringBuilder.Append(randomNose);
          break;

        case FaceFeature.Mouth:
          var randomMouth = Constants.RequestMouthTypeTexts.Shuffle().FirstOrDefault();
          faceStringBuilder.Append(randomMouth);
          break;

        case FaceFeature.Detail:
          var randomDetail = Constants.RequestDetailTypeTexts.Shuffle().FirstOrDefault();
          faceStringBuilder.Append(randomDetail);
          break;

        case FaceFeature.Beard:
          var randomBeardType = Constants.RequestBeardTypeTexts.Shuffle().FirstOrDefault();
          var randomBeardColor = Constants.RequestBeardColorTexts.Shuffle().FirstOrDefault();
          faceStringBuilder.Append(randomBeardType);
          faceStringBuilder.Append(" ");
          faceStringBuilder.Append(randomBeardColor);
          break;

        case FaceFeature.SkinTone:
          var randomSkinTone = Constants.RequestSkinToneTypeTexts.Shuffle().FirstOrDefault();
          faceStringBuilder.Append(randomSkinTone);
          break;

        default: break;
      }

      if (!ff.Equals(faceFeatures.Last()))
      {
        faceStringBuilder.Append(", ");
      }
    });

    return faceStringBuilder.ToString();
  }
}
