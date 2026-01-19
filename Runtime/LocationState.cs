using BovineLabs.Core.ObjectManagement;
using UnityEngine;

[HelpURL("https://github.com/IAFahim/AV.EssentialState")]

namespace AV.EssentialState.Runtime
{
    [CreateAssetMenu(
        fileName = nameof(LocationState),
        menuName = "AV/" + nameof(EssentialState) + "/" + nameof(LocationState) + "/New")
    ]
    public class LocationState : ScriptableObject, IUID
    {
        [SerializeField] private int id;

        public int ID
        {
            get => id;
            set => id = value;
        }
    }
}