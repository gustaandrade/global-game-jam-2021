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

  [Range(4, 9)]
  public int FeaturesToShuffle = 4;

  public List<FaceFeature> ShuffledFaceFeatures;

  private void Awake()
  {
    if (Instance == null)
      Instance = this;

    ShuffledFaceFeatures = new List<FaceFeature>();
  }

  private void Update()
  {
    CurrentGlobalTimer += Time.deltaTime;
  }

  public List<FaceFeature> RequestNextCrushFeatures()
  {
    var tempList = Constants.AllFaceFeatures;
    return tempList.Shuffle().Take(FeaturesToShuffle).ToList();
  }
}

