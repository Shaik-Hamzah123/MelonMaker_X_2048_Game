// using UnityEngine;

// [CreateAssetMenu(menuName = "Tile State")]
// public class TileState : ScriptableObject
// {
//     public int number;
//     public Color backgroundColor;
//     public Color textColor;
// }

using UnityEngine;

// DS for what is the bg of tile and the image
[CreateAssetMenu(menuName = "Tile State")]
public class TileState : ScriptableObject  
{
    public int number;
    public Color backgroundColor;
    public Sprite tileImage; // Image to be displayed on the tile
}
