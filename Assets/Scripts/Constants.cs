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

  public static List<string> RequestHairTexts = new List<string> {
    "a curly brown hairstyle",
    "a curly black hairstyle",
    "a curly blonde hairstyle",
    "a curly gray hairstyle",
    "a curly red hairstyle",
    "a long brown hairstyle",
    "a long black hairstyle",
    "a long blonde hairstyle",
    "a long gray hairstyle",
    "a long red hairstyle",
    "a short brown hairstyle",
    "a short black hairstyle",
    "a short blonde hairstyle",
    "a short gray hairstyle",
    "a short red hairstyle",
    "a medium brown hairstyle",
    "a medium black hairstyle",
    "a medium blonde hairstyle",
    "a medium gray hairstyle",
    "a medium red hairstyle"
  };

  public static List<string> RequestBeardTexts = new List<string> {
    "a thin brown moustache",
    "a thin black moustache",
    "a thin blonde moustache",
    "a thin gray moustache",
    "a thin red moustache",
    "a pirate brown moustache",
    "a pirate black moustache",
    "a pirate blonde moustache",
    "a pirate gray moustache",
    "a pirate red moustache",
    "a thick brown moustache",
    "a thick black moustache",
    "a thick blonde moustache",
    "a thick gray moustache",
    "a thick red moustache",
    "a fluff brown moustache",
    "a fluff black moustache",
    "a fluff blonde moustache",
    "a fluff gray moustache",
    "a fluff red moustache"
  };

  public static List<string> RequestEyesTexts = new List<string> {
    "squinted brown eyes",
    "squinted black eyes",
    "squinted blonde eyes",
    "squinted green eyes",
    "squinted gray eyes",
    "lively brown eyes",
    "lively black eyes",
    "lively blonde eyes",
    "lively green eyes",
    "lively gray eyes",
    "drowsy brown eyes",
    "drowsy black eyes",
    "drowsy blonde eyes",
    "drowsy green eyes",
    "drowsy gray eyes",
    "wild brown eyes",
    "wild black eyes",
    "wild blonde eyes",
    "wild green eyes",
    "wild gray eyes"
  };

  public static List<string> RequestEyebrowsTexts = new List<string> {
    "a thin eyebrow",
    "a thick eyebrow",
    "a bushy eyebrow",
    "a unibrow"
  };

  public static List<string> RequestHeadTexts = new List<string> {
    "a circular face",
    "a round face",
    "a square face"
  };

  public static List<string> RequestNoseTexts = new List<string> {
    "a rectangle nose",
    "a triangle nose",
    "a circular nose",
    "a flat nose"
  };

  public static List<string> RequestMouthTexts = new List<string> {
    "a dry smile",
    "an innocent smile",
    "voluptuous lips",
    "a timid smile",
    "a big smile"
  };

  public static List<string> RequestDetailTexts = new List<string> {
    "wrinkles",
    "a beauty mark"
  };

  public static List<string> RequestSkinToneTexts = new List<string> {
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

[System.Serializable]
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
