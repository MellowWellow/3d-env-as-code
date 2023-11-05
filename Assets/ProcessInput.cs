using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;
using UnityEngine;
using YamlDotNet.Serialization;
using YamlDotNet.Serialization.NamingConventions;

public class ProcessInput
{
  public static void Deserial()
  {
    // Specify Input Folder
    string inputFolder = "Input/";
    
    // List all Files in the Input Folder
    string[] files = Directory.GetFiles(inputFolder);

    foreach (string currentFile in files)
    {
      var deserializer = new DeserializerBuilder()
        .WithNamingConvention(CamelCaseNamingConvention.Instance)
        .Build();

      var buildingObject = deserializer.Deserialize<xCollection>(File.ReadAllText(currentFile));

      foreach (var item in buildingObject)
      {
        item.draw(
          buildingObject.collectionXoffset,
          buildingObject.collectionYoffset, 
          buildingObject.collectionZoffset
        );
      }
    }
  }
}