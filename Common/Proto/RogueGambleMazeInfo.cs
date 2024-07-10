// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: RogueGambleMazeInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from RogueGambleMazeInfo.proto</summary>
  public static partial class RogueGambleMazeInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for RogueGambleMazeInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static RogueGambleMazeInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChlSb2d1ZUdhbWJsZU1hemVJbmZvLnByb3RvGhFIQUZCSEZCUEtKRC5wcm90",
            "byJeChNSb2d1ZUdhbWJsZU1hemVJbmZvEhMKC21hemVfZW5hYmxlGA4gASgI",
            "Eg8KB21hemVfaWQYAyABKA0SIQoLQ01BUE1HQUVOSEgYCiABKAsyDC5IQUZC",
            "SEZCUEtKREIeqgIbRWdnTGluay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90",
            "bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.HAFBHFBPKJDReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.RogueGambleMazeInfo), global::EggLink.DanhengServer.Proto.RogueGambleMazeInfo.Parser, new[]{ "MazeEnable", "MazeId", "CMAPMGAENHH" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class RogueGambleMazeInfo : pb::IMessage<RogueGambleMazeInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<RogueGambleMazeInfo> _parser = new pb::MessageParser<RogueGambleMazeInfo>(() => new RogueGambleMazeInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<RogueGambleMazeInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.RogueGambleMazeInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RogueGambleMazeInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RogueGambleMazeInfo(RogueGambleMazeInfo other) : this() {
      mazeEnable_ = other.mazeEnable_;
      mazeId_ = other.mazeId_;
      cMAPMGAENHH_ = other.cMAPMGAENHH_ != null ? other.cMAPMGAENHH_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RogueGambleMazeInfo Clone() {
      return new RogueGambleMazeInfo(this);
    }

    /// <summary>Field number for the "maze_enable" field.</summary>
    public const int MazeEnableFieldNumber = 14;
    private bool mazeEnable_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool MazeEnable {
      get { return mazeEnable_; }
      set {
        mazeEnable_ = value;
      }
    }

    /// <summary>Field number for the "maze_id" field.</summary>
    public const int MazeIdFieldNumber = 3;
    private uint mazeId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint MazeId {
      get { return mazeId_; }
      set {
        mazeId_ = value;
      }
    }

    /// <summary>Field number for the "CMAPMGAENHH" field.</summary>
    public const int CMAPMGAENHHFieldNumber = 10;
    private global::EggLink.DanhengServer.Proto.HAFBHFBPKJD cMAPMGAENHH_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.HAFBHFBPKJD CMAPMGAENHH {
      get { return cMAPMGAENHH_; }
      set {
        cMAPMGAENHH_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as RogueGambleMazeInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(RogueGambleMazeInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (MazeEnable != other.MazeEnable) return false;
      if (MazeId != other.MazeId) return false;
      if (!object.Equals(CMAPMGAENHH, other.CMAPMGAENHH)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (MazeEnable != false) hash ^= MazeEnable.GetHashCode();
      if (MazeId != 0) hash ^= MazeId.GetHashCode();
      if (cMAPMGAENHH_ != null) hash ^= CMAPMGAENHH.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (MazeId != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(MazeId);
      }
      if (cMAPMGAENHH_ != null) {
        output.WriteRawTag(82);
        output.WriteMessage(CMAPMGAENHH);
      }
      if (MazeEnable != false) {
        output.WriteRawTag(112);
        output.WriteBool(MazeEnable);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (MazeId != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(MazeId);
      }
      if (cMAPMGAENHH_ != null) {
        output.WriteRawTag(82);
        output.WriteMessage(CMAPMGAENHH);
      }
      if (MazeEnable != false) {
        output.WriteRawTag(112);
        output.WriteBool(MazeEnable);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (MazeEnable != false) {
        size += 1 + 1;
      }
      if (MazeId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(MazeId);
      }
      if (cMAPMGAENHH_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(CMAPMGAENHH);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(RogueGambleMazeInfo other) {
      if (other == null) {
        return;
      }
      if (other.MazeEnable != false) {
        MazeEnable = other.MazeEnable;
      }
      if (other.MazeId != 0) {
        MazeId = other.MazeId;
      }
      if (other.cMAPMGAENHH_ != null) {
        if (cMAPMGAENHH_ == null) {
          CMAPMGAENHH = new global::EggLink.DanhengServer.Proto.HAFBHFBPKJD();
        }
        CMAPMGAENHH.MergeFrom(other.CMAPMGAENHH);
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 24: {
            MazeId = input.ReadUInt32();
            break;
          }
          case 82: {
            if (cMAPMGAENHH_ == null) {
              CMAPMGAENHH = new global::EggLink.DanhengServer.Proto.HAFBHFBPKJD();
            }
            input.ReadMessage(CMAPMGAENHH);
            break;
          }
          case 112: {
            MazeEnable = input.ReadBool();
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 24: {
            MazeId = input.ReadUInt32();
            break;
          }
          case 82: {
            if (cMAPMGAENHH_ == null) {
              CMAPMGAENHH = new global::EggLink.DanhengServer.Proto.HAFBHFBPKJD();
            }
            input.ReadMessage(CMAPMGAENHH);
            break;
          }
          case 112: {
            MazeEnable = input.ReadBool();
            break;
          }
        }
      }
    }
    #endif

  }

  #endregion

}

#endregion Designer generated code
