// -----------------------------------------------------------------------
// <copyright file="ISmoother.cs">
// Triangle.NET code by Christian Woltering, http://triangle.codeplex.com/
// </copyright>
// -----------------------------------------------------------------------

namespace UnityEditor.U2D.TriangleNet.Smoothing
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    /// <summary>
    /// Interface for mesh smoothers.
    /// </summary>
    public interface ISmoother
    {
        void Smooth();
    }
}
