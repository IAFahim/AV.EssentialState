using UnityEngine;

[HelpURL("https://github.com/IAFahim/AV.EssentialState")]
[AddComponentMenu("AV/EssentialState/StateProcessMono")]

namespace AV.EssentialState.Runtime
{
    public class StateProcessMono : MonoBehaviour
    {
        public StateProcess process;
        public StateProcess.EventId eventID;

        private void Start()
        {
            process.Start();
        }

        public void Update()
        {
            process.DispatchEvent(eventID);
        }
    }
}