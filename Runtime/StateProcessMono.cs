using UnityEngine;

namespace AV.EssentialState.Runtime
{
    [HelpURL("https://github.com/IAFahim/AV.EssentialState")]
    [AddComponentMenu("AV/EssentialState/StateProcessMono")]
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