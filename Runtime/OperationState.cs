using BovineLabs.Core.ObjectManagement;
using UnityEngine;

namespace AV.EssentialState.Runtime
{
    [HelpURL("https://github.com/IAFahim/AV.EssentialState")]
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