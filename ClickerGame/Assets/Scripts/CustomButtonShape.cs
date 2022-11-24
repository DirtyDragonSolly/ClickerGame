using UnityEngine;
using UnityEngine.UI;

public class CustomButtonShape : MonoBehaviour
{
    private readonly float alpha = 0.1f;    
    
    void Update()
    {        
        GetComponent<Image>().alphaHitTestMinimumThreshold = alpha;
    }
}
