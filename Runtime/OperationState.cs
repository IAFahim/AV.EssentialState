using BovineLabs.Core.ObjectManagement;
using UnityEngine;

[HelpURL("https://github.com/IAFahim/AV.EssentialState")]

namespace AV.EssentialState.Runtime
{
    [CreateAssetMenu(
        fileName = nameof(OperationState),
        menuName = "AV/" + nameof(EssentialState) + "/" + nameof(OperationState) + "/New")
    ]
    public class OperationState : ScriptableObject, IUID
    {
        [SerializeField] private int id;

        public int ID
        {
            get => id;
            set => id = value;
        }
    }
}