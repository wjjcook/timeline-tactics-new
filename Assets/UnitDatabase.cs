using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class UnitDatabase : ScriptableObject
{
    public SelectableUnits[] units;

    public int unitCount {
        get {
            return units.Length;
        }
    }

    public SelectableUnits GetUnit(int index){
        return units[index];
    }
}
