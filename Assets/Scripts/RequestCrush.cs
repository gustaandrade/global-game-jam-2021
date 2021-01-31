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
  public List<string> MyCrushFeaturesDetailed;

  private void Awake()
  {
    MyCrushFeatures = new List<FaceFeature>();
    MyCrushFeaturesDetailed = new List<string>();

    RequestButton.onClick.AddListener(RequestMyCrush);
  }

  public void RequestMyCrush()
  {
    //TODO: DETERMINE POSITION
    MyCrushFeatures = TimerController.Instance.RequestNextCrushFeatures(PersonPosition.Left);

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
          var randomHead = Constants.RequestHeadTexts.Shuffle().FirstOrDefault();
          faceStringBuilder.Append(randomHead);
          MyCrushFeaturesDetailed.Add(randomHead);
          break;

        case FaceFeature.Hair:
          var randomHair = Constants.RequestHairTexts.Shuffle().FirstOrDefault();
          faceStringBuilder.Append(randomHair);
          MyCrushFeaturesDetailed.Add(randomHair);
          break;

        case FaceFeature.Eyebrows:
          var randomEyebrow = Constants.RequestEyebrowsTexts.Shuffle().FirstOrDefault();
          faceStringBuilder.Append(randomEyebrow);
          MyCrushFeaturesDetailed.Add(randomEyebrow);
          break;

        case FaceFeature.Eyes:
          var randomEyes = Constants.RequestEyesTexts.Shuffle().FirstOrDefault();
          faceStringBuilder.Append(randomEyes);
          MyCrushFeaturesDetailed.Add(randomEyes);
          break;

        case FaceFeature.Nose:
          var randomNose = Constants.RequestNoseTexts.Shuffle().FirstOrDefault();
          faceStringBuilder.Append(randomNose);
          MyCrushFeaturesDetailed.Add(randomNose);
          break;

        case FaceFeature.Mouth:
          var randomMouth = Constants.RequestMouthTexts.Shuffle().FirstOrDefault();
          faceStringBuilder.Append(randomMouth);
          MyCrushFeaturesDetailed.Add(randomMouth);
          break;

        case FaceFeature.Detail:
          var randomDetail = Constants.RequestDetailTexts.Shuffle().FirstOrDefault();
          faceStringBuilder.Append(randomDetail);
          MyCrushFeaturesDetailed.Add(randomDetail);
          break;

        case FaceFeature.Beard:
          var randomBeard = Constants.RequestBeardTexts.Shuffle().FirstOrDefault();
          faceStringBuilder.Append(randomBeard);
          MyCrushFeaturesDetailed.Add(randomBeard);
          break;

        case FaceFeature.SkinTone:
          var randomSkinTone = Constants.RequestSkinToneTexts.Shuffle().FirstOrDefault();
          faceStringBuilder.Append(randomSkinTone);
          MyCrushFeaturesDetailed.Add(randomSkinTone);
          break;

        default: break;
      }

      if (!ff.Equals(faceFeatures.Last()))
      {
        faceStringBuilder.Append(", ");
      }
    });

    TimerController.Instance.RecordCrushFeaturesDetailed(MyCrushFeaturesDetailed, PersonPosition.Left);

    return faceStringBuilder.Append(".").ToString();
  }
}
