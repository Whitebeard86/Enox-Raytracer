﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Enox.Framework
{
    public class Light
    {
        #region fields

        private Vector3 position;
        private float r, g, b;

        #endregion

        #region properties

        public Vector3 Position
        {
            get { return position; }
            set { position = value; }
        }

        public float R
        {
            get { return r; }
            set { r = value; }
        }

        public float G
        {
            get { return g; }
            set { g = value; }
        }

        public float B
        {
            get { return b; }
            set { b = value; }
        }

        #endregion

        #region methods

        public static Light FromString(string content)
        {
            var lines = content.Trim().Split('\n');

            var split = lines[0].Split(' ');
            float red = (float)Convert.ToDecimal(split[0]);
            float green = (float)Convert.ToDecimal(split[1]);
            float blue = (float)Convert.ToDecimal(split[2]);

            Vector3 position = new Vector3()
            {
                X = (float)Convert.ToDecimal(lines[1].Split(' ')[0]),
                Y = (float)Convert.ToDecimal(lines[1].Split(' ')[1]),
                Z = (float)Convert.ToDecimal(lines[1].Split(' ')[2])

            };

            return new Light()
            {
                r = red,
                g = green,
                b = blue,
                position = position
            };
        }

        #endregion
    }
}
