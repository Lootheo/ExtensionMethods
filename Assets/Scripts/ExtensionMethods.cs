using UnityEngine;

public static class ExtensionMethods
{
    public static void TurnRed(this GameObject gameObjectToTurnRed)
    {
        gameObjectToTurnRed.GetComponent<MeshRenderer>().material.color = Color.red;
    }
    public static void TurnWhite(this GameObject gameObjectToTurnWhite)
    {
        gameObjectToTurnWhite.GetComponent<MeshRenderer>().material.color = Color.white;
    }
    public static void MoveUp(this Transform transformToMoveUp, float amount)
    {
        transformToMoveUp.position += Vector3.up * amount;
    }
    public static void MoveDown(this Transform transformToMoveUp, float amount)
    {
        transformToMoveUp.position += Vector3.down * amount;
    }
}
