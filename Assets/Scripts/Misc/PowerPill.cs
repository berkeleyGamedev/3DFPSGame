using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerPill : MonoBehaviour
{
    #region Editor Variables
    [SerializeField]
    [Tooltip("The amount of power that this pill restores")]
    private int m_PowerGain;
    public int PowerGain
    {
        get
        {
            return m_PowerGain;
        }
    }
    #endregion
}
