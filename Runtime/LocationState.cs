using BovineLabs.Core.ObjectManagement;
using UnityEngine;

namespace AV.EssentialState.Runtime
{
    [HelpURL("https://github.com/IAFahim/AV.EssentialState")]
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