// cluster-sim -- an open-source, highly customizable instrument cluster simulator
// Copyright (c) 2024 Kian Schmalzl. All rights reserved. Licensed under MIT-License
// https://www.github.com/ggzdev/cluster-sim

using System;
using System.Collections;
using System.Collections.Generic;

using System.IO;
using System.Threading;
using System.Diagnostics;
using System.Data;
using System.Runtime.InteropServices;
using System.Text;
using System.Numerics;

using ImGuiNET;
using ClickableTransparentOverlay;

using SFML.Audio;
using SFML.Graphics;
using SFML.System;
using SFML.Window;

using cluster_sim.data;


namespace cluster_sim.graphics {
    public static class ImGuiContent {
        public static void render_content() {
            ImGui.Begin("cluster-sim controller");
            ImGui.TextDisabled($"Version: {cluster_sim_data.application_version}");
            ImGui.TextDisabled($"Currently loaded: CLUSTER_NAME");
            ImGui.Dummy(new Vector2(x: 0, y: 2.5f));
            
            ImGui.End();
        }
    }
}