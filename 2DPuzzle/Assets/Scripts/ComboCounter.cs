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
            

                CurrentComboCount++;

        }
        DragObjList.Clear();      
    }


    /// <summary>
    ///  ドロップした最後のボールと次のボールの距離を測定
    /// </summary>
    /// <param name="thisOrbTransform"></param>
    /// <returns></returns>
    public bool CheckCombo(Transform thisOrbTransform)
    {

        float diff = (DragObjList.LastOrDefault().transform.position - thisOrbTransform.position).magnitude;
        
       // Debug.Log("きょり" + diff);

        return diff >= 1.8f;
    }


}
