using UnityEngine;

[CreateAssetMenu(fileName = "New Object", menuName = "Item/New Object")]
public class ScripteableObject : ScriptableObject
{

    public string objectName;

    public string objectDescription;

    public Sprite objectSprite;
    
    public string objectPrize;
    
    public float objectType;
}