// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: KABCHPBEJKK.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from KABCHPBEJKK.proto</summary>
  public static partial class KABCHPBEJKKReflection {

    #region Descriptor
    /// <summary>File descriptor for KABCHPBEJKK.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static KABCHPBEJKKReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChFLQUJDSFBCRUpLSy5wcm90byrRAQoLS0FCQ0hQQkVKS0sSIAocSEVBUlRf",
            "RElBTF9TVEVQX1RZUEVfTUlTU0lORxAAEh0KGUhFQVJUX0RJQUxfU1RFUF9U",
            "WVBFX0ZVTEwQARIdChlIRUFSVF9ESUFMX1NURVBfVFlQRV9MT0NLEAISHwob",
            "SEVBUlRfRElBTF9TVEVQX1RZUEVfVU5MT0NLEAMSHwobSEVBUlRfRElBTF9T",
            "VEVQX1RZUEVfTk9STUFMEAQSIAocSEVBUlRfRElBTF9TVEVQX1RZUEVfQ09O",
            "VFJPTBAFQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3Rv",
            "Mw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::EggLink.DanhengServer.Proto.KABCHPBEJKK), }, null, null));
    }
    #endregion

  }
  #region Enums
  public enum KABCHPBEJKK {
    [pbr::OriginalName("HEART_DIAL_STEP_TYPE_MISSING")] HeartDialStepTypeMissing = 0,
    [pbr::OriginalName("HEART_DIAL_STEP_TYPE_FULL")] HeartDialStepTypeFull = 1,
    [pbr::OriginalName("HEART_DIAL_STEP_TYPE_LOCK")] HeartDialStepTypeLock = 2,
    [pbr::OriginalName("HEART_DIAL_STEP_TYPE_UNLOCK")] HeartDialStepTypeUnlock = 3,
    [pbr::OriginalName("HEART_DIAL_STEP_TYPE_NORMAL")] HeartDialStepTypeNormal = 4,
    [pbr::OriginalName("HEART_DIAL_STEP_TYPE_CONTROL")] HeartDialStepTypeControl = 5,
  }

  #endregion

}

#endregion Designer generated code
