// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: QuestStatus.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from QuestStatus.proto</summary>
  public static partial class QuestStatusReflection {

    #region Descriptor
    /// <summary>File descriptor for QuestStatus.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static QuestStatusReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChFRdWVzdFN0YXR1cy5wcm90bypjCgtRdWVzdFN0YXR1cxIOCgpRVUVTVF9O",
            "T05FEAASDwoLUVVFU1RfRE9JTkcQARIQCgxRVUVTVF9GSU5JU0gQAhIPCgtR",
            "VUVTVF9DTE9TRRADEhAKDFFVRVNUX0RFTEVURRAEQh6qAhtFZ2dMaW5rLkRh",
            "bmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::EggLink.DanhengServer.Proto.QuestStatus), }, null, null));
    }
    #endregion

  }
  #region Enums
  public enum QuestStatus {
    [pbr::OriginalName("QUEST_NONE")] QuestNone = 0,
    [pbr::OriginalName("QUEST_DOING")] QuestDoing = 1,
    [pbr::OriginalName("QUEST_FINISH")] QuestFinish = 2,
    [pbr::OriginalName("QUEST_CLOSE")] QuestClose = 3,
    [pbr::OriginalName("QUEST_DELETE")] QuestDelete = 4,
  }

  #endregion

}

#endregion Designer generated code