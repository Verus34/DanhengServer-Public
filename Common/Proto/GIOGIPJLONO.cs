// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: GIOGIPJLONO.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from GIOGIPJLONO.proto</summary>
  public static partial class GIOGIPJLONOReflection {

    #region Descriptor
    /// <summary>File descriptor for GIOGIPJLONO.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GIOGIPJLONOReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChFHSU9HSVBKTE9OTy5wcm90byqhAQoLR0lPR0lQSkxPTk8SIgoeUk9HVUVf",
            "VE9VUk5fU0VUVExFX1JFQVNPTl9OT05FEAASIQodUk9HVUVfVE9VUk5fU0VU",
            "VExFX1JFQVNPTl9XSU4QARIiCh5ST0dVRV9UT1VSTl9TRVRUTEVfUkVBU09O",
            "X0ZBSUwQAhInCiNST0dVRV9UT1VSTl9TRVRUTEVfUkVBU09OX0lOVEVSUlVQ",
            "VBADQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::EggLink.DanhengServer.Proto.GIOGIPJLONO), }, null, null));
    }
    #endregion

  }
  #region Enums
  public enum GIOGIPJLONO {
    [pbr::OriginalName("ROGUE_TOURN_SETTLE_REASON_NONE")] RogueTournSettleReasonNone = 0,
    [pbr::OriginalName("ROGUE_TOURN_SETTLE_REASON_WIN")] RogueTournSettleReasonWin = 1,
    [pbr::OriginalName("ROGUE_TOURN_SETTLE_REASON_FAIL")] RogueTournSettleReasonFail = 2,
    [pbr::OriginalName("ROGUE_TOURN_SETTLE_REASON_INTERRUPT")] RogueTournSettleReasonInterrupt = 3,
  }

  #endregion

}

#endregion Designer generated code
