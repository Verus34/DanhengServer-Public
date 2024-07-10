// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: StartTimedCocoonStageScRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from StartTimedCocoonStageScRsp.proto</summary>
  public static partial class StartTimedCocoonStageScRspReflection {

    #region Descriptor
    /// <summary>File descriptor for StartTimedCocoonStageScRsp.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static StartTimedCocoonStageScRspReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiBTdGFydFRpbWVkQ29jb29uU3RhZ2VTY1JzcC5wcm90bxoVU2NlbmVCYXR0",
            "bGVJbmZvLnByb3RvInUKGlN0YXJ0VGltZWRDb2Nvb25TdGFnZVNjUnNwEiUK",
            "C2JhdHRsZV9pbmZvGAEgASgLMhAuU2NlbmVCYXR0bGVJbmZvEg8KB3JldGNv",
            "ZGUYDSABKA0SEQoJY29jb29uX2lkGAQgASgNEgwKBHdhdmUYDiABKA1CHqoC",
            "G0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.SceneBattleInfoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.StartTimedCocoonStageScRsp), global::EggLink.DanhengServer.Proto.StartTimedCocoonStageScRsp.Parser, new[]{ "BattleInfo", "Retcode", "CocoonId", "Wave" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class StartTimedCocoonStageScRsp : pb::IMessage<StartTimedCocoonStageScRsp>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<StartTimedCocoonStageScRsp> _parser = new pb::MessageParser<StartTimedCocoonStageScRsp>(() => new StartTimedCocoonStageScRsp());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<StartTimedCocoonStageScRsp> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.StartTimedCocoonStageScRspReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public StartTimedCocoonStageScRsp() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public StartTimedCocoonStageScRsp(StartTimedCocoonStageScRsp other) : this() {
      battleInfo_ = other.battleInfo_ != null ? other.battleInfo_.Clone() : null;
      retcode_ = other.retcode_;
      cocoonId_ = other.cocoonId_;
      wave_ = other.wave_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public StartTimedCocoonStageScRsp Clone() {
      return new StartTimedCocoonStageScRsp(this);
    }

    /// <summary>Field number for the "battle_info" field.</summary>
    public const int BattleInfoFieldNumber = 1;
    private global::EggLink.DanhengServer.Proto.SceneBattleInfo battleInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.SceneBattleInfo BattleInfo {
      get { return battleInfo_; }
      set {
        battleInfo_ = value;
      }
    }

    /// <summary>Field number for the "retcode" field.</summary>
    public const int RetcodeFieldNumber = 13;
    private uint retcode_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Retcode {
      get { return retcode_; }
      set {
        retcode_ = value;
      }
    }

    /// <summary>Field number for the "cocoon_id" field.</summary>
    public const int CocoonIdFieldNumber = 4;
    private uint cocoonId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint CocoonId {
      get { return cocoonId_; }
      set {
        cocoonId_ = value;
      }
    }

    /// <summary>Field number for the "wave" field.</summary>
    public const int WaveFieldNumber = 14;
    private uint wave_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Wave {
      get { return wave_; }
      set {
        wave_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as StartTimedCocoonStageScRsp);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(StartTimedCocoonStageScRsp other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(BattleInfo, other.BattleInfo)) return false;
      if (Retcode != other.Retcode) return false;
      if (CocoonId != other.CocoonId) return false;
      if (Wave != other.Wave) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (battleInfo_ != null) hash ^= BattleInfo.GetHashCode();
      if (Retcode != 0) hash ^= Retcode.GetHashCode();
      if (CocoonId != 0) hash ^= CocoonId.GetHashCode();
      if (Wave != 0) hash ^= Wave.GetHashCode();
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
      if (battleInfo_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(BattleInfo);
      }
      if (CocoonId != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(CocoonId);
      }
      if (Retcode != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(Retcode);
      }
      if (Wave != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(Wave);
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
      if (battleInfo_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(BattleInfo);
      }
      if (CocoonId != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(CocoonId);
      }
      if (Retcode != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(Retcode);
      }
      if (Wave != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(Wave);
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
      if (battleInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(BattleInfo);
      }
      if (Retcode != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Retcode);
      }
      if (CocoonId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(CocoonId);
      }
      if (Wave != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Wave);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(StartTimedCocoonStageScRsp other) {
      if (other == null) {
        return;
      }
      if (other.battleInfo_ != null) {
        if (battleInfo_ == null) {
          BattleInfo = new global::EggLink.DanhengServer.Proto.SceneBattleInfo();
        }
        BattleInfo.MergeFrom(other.BattleInfo);
      }
      if (other.Retcode != 0) {
        Retcode = other.Retcode;
      }
      if (other.CocoonId != 0) {
        CocoonId = other.CocoonId;
      }
      if (other.Wave != 0) {
        Wave = other.Wave;
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
          case 10: {
            if (battleInfo_ == null) {
              BattleInfo = new global::EggLink.DanhengServer.Proto.SceneBattleInfo();
            }
            input.ReadMessage(BattleInfo);
            break;
          }
          case 32: {
            CocoonId = input.ReadUInt32();
            break;
          }
          case 104: {
            Retcode = input.ReadUInt32();
            break;
          }
          case 112: {
            Wave = input.ReadUInt32();
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
          case 10: {
            if (battleInfo_ == null) {
              BattleInfo = new global::EggLink.DanhengServer.Proto.SceneBattleInfo();
            }
            input.ReadMessage(BattleInfo);
            break;
          }
          case 32: {
            CocoonId = input.ReadUInt32();
            break;
          }
          case 104: {
            Retcode = input.ReadUInt32();
            break;
          }
          case 112: {
            Wave = input.ReadUInt32();
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
