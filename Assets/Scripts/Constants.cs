using System.Collections.Generic;

public static class Constants
{
  public static List<FaceFeature> AllFaceFeatures = new List<FaceFeature> {
    FaceFeature.Head,
    FaceFeature.Hair,
    FaceFeature.Eyebrows,
    FaceFeature.Eyes,
    FaceFeature.Nose,
    FaceFeature.Mouth,
    FaceFeature.Detail,
    FaceFeature.Beard,
    FaceFeature.SkinTone,
  };

  public static List<string> RequestBaseTexts = new List<string> {
      "My crush has",
  };

  public static List<string> RequestHairTypeTexts = new List<string> {
    "a curly",
    "a long",
    "a short",
    "a medium"
  };

  public static List<string> RequestHairColorTexts = new List<string> {
    "brown hairstyle",
    "black hairstyle",
    "blonde hairstyle",
    "gray hairstyle",
    "red hairstyle",
  };

  public static List<string> RequestBeardTypeTexts = new List<string> {
    "a thin",
    "a pirate",
    "a thick",
    "a fluff"
  };

  public static List<string> RequestBeardColorTexts = new List<string> {
    "brown moustache",
    "black moustache",
    "blonde moustache",
    "gray moustache",
    "red moustache",
  };

  public static List<string> RequestEyesTypeTexts = new List<string> {
    "squinted",
    "lively",
    "drowsy",
    "wild"
  };

  public static List<string> RequestEyesColorTexts = new List<string> {
    "brown eyes",
    "black eyes",
    "blonde eyes",
    "green eyes",
    "gray eyes",
  };

  public static List<string> RequestEyebrowTypeTexts = new List<string> {
    "a thin eyebrow",
    "a thick eyebrow",
    "a bushy eyebrow",
    "a unibrow"
  };

  public static List<string> RequestHeadTypeTexts = new List<string> {
    "a circular face",
    "a round face",
    "a square face"
  };

  public static List<string> RequestNoseTypeTexts = new List<string> {
    "a ractangle nose",
    "a triangle nose",
    "a circular nose",
    "a flat nose"
  };

  public static List<string> RequestMouthTypeTexts = new List<string> {
    "a dry smile",
    "an innocent smile",
    "voluptuous lips",
    "a timid smile",
    "a big smile"
  };

  public static List<string> RequestDetailTypeTexts = new List<string> {
    "wrinkles",
    "a beauty mark"
  };

  public static List<string> RequestSkinToneTypeTexts = new List<string> {
    "is asian",
    "is black",
    "is latinx",
    "is white",
    "is an alien"
  };

  public static List<string> RequestIntroBaseTexts = new List<string> {
    "Hi there, can you help me?",
    "Is this the Crush Booth™?",
    "Help me! I have a subway crush!",
    "It's an emergency! A love emergency!",
    "GIBE CRUSH PLS",
    "Are you the one who makes the sketches?",
  };
}

public enum FaceFeature
{
  Head = 1,
  Hair = 2,
  Eyebrows = 3,
  Eyes = 4,
  Nose = 5,
  Mouth = 6,
  Detail = 7,
  Beard = 8,
  SkinTone = 9
}
