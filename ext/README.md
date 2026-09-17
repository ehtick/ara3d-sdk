# ext — Windows-only SDK extensions

Projects here depend on Windows APIs, native Windows binaries, or WPF/WinForms. They are
published as individual NuGet packages and included in the `Ara3D.SDK.IO` / `Ara3D.SDK`
meta-packages where noted.

| Project | Role |
| --- | --- |
| [Ara3D.Utils.Wpf](Ara3D.Utils.Wpf) | WPF controls and dialog helpers |

**Not in `ext/`** (see repo root folders):

- [`src/`](../src/) — supported cross-platform libraries and meta-packages
- [`plugins/`](../plugins/) — the Bowerbird plug-in host
- [`integrations/`](../integrations/) — optional third-party loaders (e.g. Assimp)
