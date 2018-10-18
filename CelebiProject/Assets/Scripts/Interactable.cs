
using UnityEngine;

public class Interactable : MonoBehaviour
{
    public int timeState;
   

    public void TransferEnergy()
    {
        timeState++;
        Debug.Log(timeState);
            
    }
   

}
