﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SFML.Graphics
{
    public partial class RenderImage
    {
        ////////////////////////////////////////////////////////////
        /// <summary>
        /// Handle the destruction of the object
        /// </summary>
        /// <param name="disposing">Is the GC disposing the object, or is it an explicit call ?</param>
        ////////////////////////////////////////////////////////////
        protected override void Destroy(bool disposing)
        {
            if (!disposing)
                Context.Global.SetActive(true);

            var t = ThisRaw;

            if (t != IntPtr.Zero)
                sfRenderImage_Destroy(t);

            if (disposing)
            {
                myDefaultView.Dispose();
                myImage.Dispose();
            }

            if (!disposing)
                Context.Global.SetActive(false);
        }
    }
}
