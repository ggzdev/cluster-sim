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


namespace cluster_sim.graphics {
    public static class Graphics {
        public static void draw_line(Vector2f point1, Vector2f point2, Color col, int line_width, RenderWindow display) {
            VertexArray line = new VertexArray(PrimitiveType.Lines, 2);
            line[0] = new Vertex(point1, col);
            line[1] = new Vertex(point2, col);
            display.Draw(line);
        }

        public static void draw_circleOutline(Vector2f center, float radius, Color outline_col, int line_width, RenderWindow display) {
            CircleShape circle = new CircleShape();
            circle.Position = center;
            circle.Radius = radius;
            circle.FillColor = Color.Transparent;
            circle.OutlineColor = outline_col;
            circle.OutlineThickness = line_width;

            display.Draw(circle);
        }

        public static void draw_curve(Vector2f point1, Vector2f point2, Color col, int line_width, Vector2f ctrlpoint1, Vector2f ctrlpoint2, RenderWindow display) {
            VertexArray curve = new VertexArray(PrimitiveType.LineStrip);
            int STEPS = 50;

            for(int i = 0; i < STEPS; i++) {
                float t = (float)i / STEPS;
                float mT = 1 - t;
                float x = mT * mT * mT * point1.X + 3 * mT * mT * t * ctrlpoint1.X + 3 * mT * t * t * ctrlpoint2.X + t * t * t * point2.X;
                float y = mT * mT * mT * point1.Y + 3 * mT * mT * t * ctrlpoint1.Y + 3 * mT * t * t * ctrlpoint2.Y + t * t * t * point2.Y;

                curve.Append(new Vertex(new Vector2f(x, y), Color.White));
            }

            display.Draw(curve);
        }
    }
}