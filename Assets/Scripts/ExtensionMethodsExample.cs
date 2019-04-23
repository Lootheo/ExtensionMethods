using System.Collections;
using UnityEngine;

public class ExtensionMethodsExample : MonoBehaviour
{
    public GameObject cube;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(ColorChanger());

        transform.MoveUp(5.0f);
        
    }

    IEnumerator ColorChanger()
    {
        while (true)
        {
            cube.TurnRed();
            yield return new WaitForSeconds(1.0f);
            cube.TurnWhite();
            yield return new WaitForSeconds(1.0f);
            cube.transform.MoveUp(3.0f);
            yield return new WaitForSeconds(1.0f);
            cube.transform.MoveDown(3.0f);
            yield return new WaitForSeconds(1.0f);
        }
    }

}
