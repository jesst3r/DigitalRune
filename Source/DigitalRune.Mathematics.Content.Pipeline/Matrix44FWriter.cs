﻿// DigitalRune Engine - Copyright (C) DigitalRune GmbH
// This file is subject to the terms and conditions defined in
// file 'LICENSE.TXT', which is part of this source code package.

using DigitalRune.Mathematics.Algebra;
using Microsoft.Xna.Framework.Content.Pipeline;
using Microsoft.Xna.Framework.Content.Pipeline.Serialization.Compiler;


namespace DigitalRune.Mathematics.Content.Pipeline
{
  /// <summary>
  /// Writes a <see cref="Matrix44F"/> to binary format.
  /// </summary>
  [ContentTypeWriter]
  public class Matrix44FWriter : ContentTypeWriter<Matrix44F>
  {
    /// <summary>
    /// Gets the assembly qualified name of the runtime target type.
    /// </summary>
    /// <param name="targetPlatform">The target platform.</param>
    /// <returns>The qualified name.</returns>
    public override string GetRuntimeType(TargetPlatform targetPlatform)
    {
      return typeof(Matrix44F).AssemblyQualifiedName;
    }


    /// <summary>
    /// Gets the assembly qualified name of the runtime loader for this type.
    /// </summary>
    /// <param name="targetPlatform">Name of the platform.</param>
    /// <returns>Name of the runtime loader.</returns>
    public override string GetRuntimeReader(TargetPlatform targetPlatform)
    {
      return typeof(Matrix44FReader).AssemblyQualifiedName;
    }


    /// <summary>
    /// Compiles a strongly typed object into binary format.
    /// </summary>
    /// <param name="output">The content writer serializing the value.</param>
    /// <param name="value">The value to write.</param>
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods")]
    protected override void Write(ContentWriter output, Matrix44F value)
    {
      output.Write(value.M00);
      output.Write(value.M01);
      output.Write(value.M02);
      output.Write(value.M03);
      output.Write(value.M10);
      output.Write(value.M11);
      output.Write(value.M12);
      output.Write(value.M13);
      output.Write(value.M20);
      output.Write(value.M21);
      output.Write(value.M22);
      output.Write(value.M23);
      output.Write(value.M30);
      output.Write(value.M31);
      output.Write(value.M32);
      output.Write(value.M33);
    }
  }
}
