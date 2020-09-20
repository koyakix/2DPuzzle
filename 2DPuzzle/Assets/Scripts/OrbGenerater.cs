using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbGenerater : MonoBehaviour
{

    [SerializeField] Transform m_orbGenerater =null;
    [SerializeField] List<GameObject> m_orbObjects = new List<GameObject>();
    [SerializeField] ComboCounter m_comboCounter = null;
    private int m_maxOrbCount = 20;
    public List<GameObject> OrbList = new List<GameObject>();

    // Start is called before the first frame update
    void Start()
    {
        OrbGenerate(m_maxOrbCount);
    }

    public void OrbGenerate(int generateOrbCount)
    {
        for (int i = 0; generateOrbCount>i; i++)
        {
            var orb = Instantiate(m_orbObjects[Random.Range(0,4)], m_orbGenerater);
            orb.GetComponent<OrbController>().comboCounter = m_comboCounter;
            orb.GetComponent<Rigidbody2D>().AddForce(new Vector2(Random.Range(-4, 4), Random.Range(-4, 0)));
            orb.GetComponent<OrbController>().OrbGenerater = this;
            OrbList.Add(orb);
        }
    }
}
