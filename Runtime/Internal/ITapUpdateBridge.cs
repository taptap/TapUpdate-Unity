using TapTap.Common;
using System;

namespace TapTap.Update.Internal {
    public interface ITapUpdateBridge {
        void UpdateGame(Action onCancel);
    }
}