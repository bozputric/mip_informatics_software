using System;

namespace system
{
    internal class EventHandler
    {
        private Action<object, EventArgs> cbTrgovineInfo_SelectedIndexChanged;

        public EventHandler(Action<object, EventArgs> cbTrgovineInfo_SelectedIndexChanged)
        {
            this.cbTrgovineInfo_SelectedIndexChanged = cbTrgovineInfo_SelectedIndexChanged;
        }
    }
}