using System;
using Microsoft.Xna.Framework;

namespace Celeste.Mod.SaveTags {
    public class SaveTagsModule : EverestModule {
        public static SaveTagsModule Instance { get; private set; }

        public override Type SettingsType => typeof(SaveTagsModuleSettings);
        public static SaveTagsModuleSettings Settings => (SaveTagsModuleSettings) Instance._Settings;

        public override Type SessionType => typeof(SaveTagsModuleSession);
        public static SaveTagsModuleSession Session => (SaveTagsModuleSession) Instance._Session;

        public override Type SaveDataType => typeof(SaveTagsModuleSaveData);
        public static SaveTagsModuleSaveData SaveData => (SaveTagsModuleSaveData) Instance._SaveData;

        public SaveTagsModule() {
            Instance = this;
#if DEBUG
            // debug builds use verbose logging
            Logger.SetLogLevel(nameof(SaveTagsModule), LogLevel.Verbose);
#else
            // release builds use info logging to reduce spam in log files
            Logger.SetLogLevel(nameof(SaveTagsModule), LogLevel.Info);
#endif
        }

        public override void Load() {
            // TODO: apply any hooks that should always be active
        }

        public override void Unload() {
            // TODO: unapply any hooks applied in Load()
        }
    }
}
