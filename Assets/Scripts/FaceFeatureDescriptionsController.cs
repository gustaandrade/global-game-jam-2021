using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FaceFeatureDescriptionsController : MonoBehaviour
{
  public List<FaceFeatureDescriptions> FaceDescriptions;

  private FaceFeatureDescriptions _modelDescription;

  private void Awake()
  {
    FaceDescriptions = new List<FaceFeatureDescriptions>();

    LoadResources();
  }

  private void LoadResources()
  {
    var sprite1 = Resources.Load<Sprite>("FaceFeatures/cabelos360x500");
    var sprite2 = Resources.Load<Sprite>("FaceFeatures/cabelos360x500_1");

    // _modelDescription.DefaultSprite = Resources.Load<Sprite>("FaceFeatures/cabelos360x500_0");
    // _modelDescription.SpriteDescription = "a short black hairstyle";
    // FaceDescriptions.Add(_modelDescription);

    // _modelDescription.DefaultSprite = Resources.Load<Sprite>("FaceFeatures/cabelos360x500");
    // _modelDescription.SpriteDescription = "a short brown hairstyle";
    // FaceDescriptions.Add(_modelDescription);
  }
}
