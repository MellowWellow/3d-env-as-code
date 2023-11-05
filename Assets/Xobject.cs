using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class xCollection : IEnumerable<xObject>
{
  public int collectionXoffset { get; set; }
  public int collectionYoffset { get; set; }
  public int collectionZoffset { get; set; }

  public List <xObject> xObjects = new List<xObject> ();

  public IEnumerator<xObject> GetEnumerator()
  {
    return xObjects.GetEnumerator();
  }

  IEnumerator IEnumerable.GetEnumerator()
  {
    return GetEnumerator();
  }

  public xObject this[int index] => xObjects[index];
  public int Count => xObjects.Count;
}

public class xObject
{
  public string name { get; set; }
  public string type { get; set; }
  public string color { get; set; }
  public float width { get; set; }
  public float length { get; set; }
  public float height { get; set; }
  public float xoffset { get; set; }
  public float yoffset { get; set; }
  public float zoffset { get; set; }

  public void draw(int collectionXoffset, int collectionYoffset, int collectionZoffset)
  {
    GameObject currentObject = null;
    
    // Draw Object
    switch (type)
    {
      case "cube":
        currentObject = GameObject.CreatePrimitive(PrimitiveType.Cube);
        break;
      
      case "sphere":
        currentObject = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        break;
      
      case "capsule":
        currentObject = GameObject.CreatePrimitive(PrimitiveType.Capsule);
        break;

      case "cylinder":
        currentObject = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
        break;

      case "plane":
        currentObject = GameObject.CreatePrimitive(PrimitiveType.Plane);
        break;

      default:
        break;
    }

    // Scale Object
    currentObject.transform.localScale = new Vector3(width, height, length);

    // Move Object
    currentObject.transform.localPosition = new Vector3(
      xoffset + collectionXoffset, 
      yoffset + collectionYoffset, 
      zoffset + collectionZoffset
    );

    // Set Color
    switch (color) 
    {
      case "black": 
        currentObject.GetComponent<MeshRenderer>().material.color = Color.black;
        break;
      
      case "blue":
        currentObject.GetComponent<MeshRenderer>().material.color = Color.blue;
        break;

      case "clear":
        currentObject.GetComponent<MeshRenderer>().material.color = Color.clear;
        break;

      case "cyan":
        currentObject.GetComponent<MeshRenderer>().material.color = Color.cyan;
        break;

      case "gray":
        currentObject.GetComponent<MeshRenderer>().material.color = Color.gray;
        break;

      case "grey":
        currentObject.GetComponent<MeshRenderer>().material.color = Color.grey;
        break;

      case "green":
        currentObject.GetComponent<MeshRenderer>().material.color = Color.green;
        break;

      case "magenta":
        currentObject.GetComponent<MeshRenderer>().material.color = Color.magenta;
        break;

      case "red":
        currentObject.GetComponent<MeshRenderer>().material.color = Color.red;
        break;

      case "white":
        currentObject.GetComponent<MeshRenderer>().material.color = Color.white;
        break;
      
      default:
        break;
    }
  }
}