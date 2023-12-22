using MonoMod.ModInterop;

namespace Celeste.Mod.SaveTags {
    /// <summary>
    /// Provides export functions for other mods to import.
    /// If you do not need to export any functions, delete this class and the corresponding call
    /// to ModInterop() in <see cref="SaveTagsModule.Load"/>
    /// </summary>
    [ModExportName("SaveTags")]
    public static class SaveTagsExports {
        // TODO: add your mod's exports, if required
    }
}
