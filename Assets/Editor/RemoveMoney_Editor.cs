using UnityEngine;
using System.Collections;
using UnityEditor;

[CustomEditor (typeof(RemoveMoney))]
public class RemoveMoney_Editor : Editor {

    public override void OnInspectorGUI()
    {
        RemoveMoney myTarget = (RemoveMoney)target;

        myTarget.moneyLoserFactor = EditorGUILayout.IntField("Money Loser Factor", myTarget.moneyLoserFactor);
        EditorGUILayout.LabelField("Level", myTarget.cashToLose.ToString());
    }

}
