/*
 * Copyright 2020 Google Inc. All Rights Reserved.
 * Use of this source code is governed by a BSD-style
 * license that can be found in the LICENSE file or at
 * https://developers.google.com/open-source/licenses/bsd
 */

// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/api/field_behavior.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Api {

  /// <summary>Holder for reflection information generated from google/api/field_behavior.proto</summary>
  public static partial class FieldBehaviorReflection {

    #region Descriptor
    /// <summary>File descriptor for google/api/field_behavior.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static FieldBehaviorReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch9nb29nbGUvYXBpL2ZpZWxkX2JlaGF2aW9yLnByb3RvEgpnb29nbGUuYXBp",
            "GiBnb29nbGUvcHJvdG9idWYvZGVzY3JpcHRvci5wcm90byp7Cg1GaWVsZEJl",
            "aGF2aW9yEh4KGkZJRUxEX0JFSEFWSU9SX1VOU1BFQ0lGSUVEEAASDAoIT1BU",
            "SU9OQUwQARIMCghSRVFVSVJFRBACEg8KC09VVFBVVF9PTkxZEAMSDgoKSU5Q",
            "VVRfT05MWRAEEg0KCUlNTVVUQUJMRRAFOlEKDmZpZWxkX2JlaGF2aW9yEh0u",
            "Z29vZ2xlLnByb3RvYnVmLkZpZWxkT3B0aW9ucxicCCADKA4yGS5nb29nbGUu",
            "YXBpLkZpZWxkQmVoYXZpb3JCcAoOY29tLmdvb2dsZS5hcGlCEkZpZWxkQmVo",
            "YXZpb3JQcm90b1ABWkFnb29nbGUuZ29sYW5nLm9yZy9nZW5wcm90by9nb29n",
            "bGVhcGlzL2FwaS9hbm5vdGF0aW9uczthbm5vdGF0aW9uc6ICBEdBUEliBnBy",
            "b3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Protobuf.Reflection.DescriptorReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::Google.Api.FieldBehavior), }, new pb::Extension[] { FieldBehaviorExtensions.FieldBehavior }, null));
    }
    #endregion

  }
  /// <summary>Holder for extension identifiers generated from the top level of google/api/field_behavior.proto</summary>
  public static partial class FieldBehaviorExtensions {
    /// <summary>
    /// A designation of a specific field behavior (required, output only, etc.)
    /// in protobuf messages.
    ///
    /// Examples:
    ///
    ///   string name = 1 [(google.api.field_behavior) = REQUIRED];
    ///   State state = 1 [(google.api.field_behavior) = OUTPUT_ONLY];
    ///   google.protobuf.Duration ttl = 1
    ///     [(google.api.field_behavior) = INPUT_ONLY];
    ///   google.protobuf.Timestamp expire_time = 1
    ///     [(google.api.field_behavior) = OUTPUT_ONLY,
    ///      (google.api.field_behavior) = IMMUTABLE];
    /// </summary>
    public static readonly pb::RepeatedExtension<global::Google.Protobuf.Reflection.FieldOptions, global::Google.Api.FieldBehavior> FieldBehavior =
      new pb::RepeatedExtension<global::Google.Protobuf.Reflection.FieldOptions, global::Google.Api.FieldBehavior>(1052, pb::FieldCodec.ForEnum(8418, x => (int) x, x => (global::Google.Api.FieldBehavior) x));
  }

  #region Enums
  /// <summary>
  /// An indicator of the behavior of a given field (for example, that a field
  /// is required in requests, or given as output but ignored as input).
  /// This **does not** change the behavior in protocol buffers itself; it only
  /// denotes the behavior and may affect how API tooling handles the field.
  ///
  /// Note: This enum **may** receive new values in the future.
  /// </summary>
  public enum FieldBehavior {
    /// <summary>
    /// Conventional default for enums. Do not use this.
    /// </summary>
    [pbr::OriginalName("FIELD_BEHAVIOR_UNSPECIFIED")] Unspecified = 0,
    /// <summary>
    /// Specifically denotes a field as optional.
    /// While all fields in protocol buffers are optional, this may be specified
    /// for emphasis if appropriate.
    /// </summary>
    [pbr::OriginalName("OPTIONAL")] Optional = 1,
    /// <summary>
    /// Denotes a field as required.
    /// This indicates that the field **must** be provided as part of the request,
    /// and failure to do so will cause an error (usually `INVALID_ARGUMENT`).
    /// </summary>
    [pbr::OriginalName("REQUIRED")] Required = 2,
    /// <summary>
    /// Denotes a field as output only.
    /// This indicates that the field is provided in responses, but including the
    /// field in a request does nothing (the server *must* ignore it and
    /// *must not* throw an error as a result of the field's presence).
    /// </summary>
    [pbr::OriginalName("OUTPUT_ONLY")] OutputOnly = 3,
    /// <summary>
    /// Denotes a field as input only.
    /// This indicates that the field is provided in requests, and the
    /// corresponding field is not included in output.
    /// </summary>
    [pbr::OriginalName("INPUT_ONLY")] InputOnly = 4,
    /// <summary>
    /// Denotes a field as immutable.
    /// This indicates that the field may be set once in a request to create a
    /// resource, but may not be changed thereafter.
    /// </summary>
    [pbr::OriginalName("IMMUTABLE")] Immutable = 5,
  }

  #endregion

}

#endregion Designer generated code
