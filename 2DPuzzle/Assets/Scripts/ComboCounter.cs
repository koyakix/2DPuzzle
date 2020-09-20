using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class ComboCounter : MonoBehaviour
{

    public List<GameObject> DragObjList = new List<GameObject>();

    public int ComboCount => DragObjList.Count;

    public int CurrentComboCount;

    public void AddCombo(GameObject orb)
    {
        DragObjList.Add(orb);
        foreach (var orbs in DragObjList)
        {
            var comboEffect = orbs.GetComponent<OrbController>().ComnboEffect.gameObject;
            if (!comboEffect.activeSelf)
            {
                comboEffect.SetActive(true);
            }
        }
    }

    public void MinusCombo()
    {
        DragObjList.LastOrDefault().GetComponent<OrbController>().ComnboEffect.gameObject.SetActive(false);
        DragObjList.Remove(DragObjList.LastOrDefault());
       
    }

    public void ClearCombo()
    {
        foreach (var orbs in DragObjList)
        {
            var comboEffect = orbs.GetComponent<OrbController>().ComnboEffect.gameObject;
            if (comboEffect.activeSelf)
            {
                comboEffect.SetActive(false);
            }
            
            if (CurrentComboCount <= 6)
            {
                CurrentComboCount++;
            }
            else
            {
                CurrentComboCount += 2;
               
            }
        }
        DragObjList.Clear();      
    }
}
