// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: EnterStrongChallengeActivityStageScRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from EnterStrongChallengeActivityStageScRsp.proto</summary>
  public static partial class EnterStrongChallengeActivityStageScRspReflection {

    #region Descriptor
    /// <summary>File descriptor for EnterStrongChallengeActivityStageScRsp.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static EnterStrongChallengeActivityStageScRspReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CixFbnRlclN0cm9uZ0NoYWxsZW5nZUFjdGl2aXR5U3RhZ2VTY1JzcC5wcm90",
            "bxoVU2NlbmVCYXR0bGVJbmZvLnByb3RvInIKJkVudGVyU3Ryb25nQ2hhbGxl",
            "bmdlQWN0aXZpdHlTdGFnZVNjUnNwEiUKC2JhdHRsZV9pbmZvGAUgASgLMhAu",
            "U2NlbmVCYXR0bGVJbmZvEg8KB3JldGNvZGUYDCABKA0SEAoIc3RhZ2VfaWQY",
            "AyABKA1CHqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.SceneBattleInfoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.EnterStrongChallengeActivityStageScRsp), global::EggLink.DanhengServer.Proto.EnterStrongChallengeActivityStageScRsp.Parser, new[]{ "BattleInfo", "Retcode", "StageId" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class EnterStrongChallengeActivityStageScRsp : pb::IMessage<EnterStrongChallengeActivityStageScRsp>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<EnterStrongChallengeActivityStageScRsp> _parser = new pb::MessageParser<EnterStrongChallengeActivityStageScRsp>(() => new EnterStrongChallengeActivityStageScRsp());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<EnterStrongChallengeActivityStageScRsp> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.EnterStrongChallengeActivityStageScRspReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public EnterStrongChallengeActivityStageScRsp() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public EnterStrongChallengeActivityStageScRsp(EnterStrongChallengeActivityStageScRsp other) : this() {
      battleInfo_ = other.battleInfo_ != null ? other.battleInfo_.Clone() : null;
      retcode_ = other.retcode_;
      stageId_ = other.stageId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public EnterStrongChallengeActivityStageScRsp Clone() {
      return new EnterStrongChallengeActivityStageScRsp(this);
    }

    /// <summary>Field number for the "battle_info" field.</summary>
    public const int BattleInfoFieldNumber = 5;
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
    public const int RetcodeFieldNumber = 12;
    private uint retcode_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Retcode {
      get { return retcode_; }
      set {
        retcode_ = value;
      }
    }

    /// <summary>Field number for the "stage_id" field.</summary>
    public const int StageIdFieldNumber = 3;
    private uint stageId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint StageId {
      get { return stageId_; }
      set {
        stageId_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as EnterStrongChallengeActivityStageScRsp);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(EnterStrongChallengeActivityStageScRsp other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(BattleInfo, other.BattleInfo)) return false;
      if (Retcode != other.Retcode) return false;
      if (StageId != other.StageId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (battleInfo_ != null) hash ^= BattleInfo.GetHashCode();
      if (Retcode != 0) hash ^= Retcode.GetHashCode();
      if (StageId != 0) hash ^= StageId.GetHashCode();
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
      if (StageId != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(StageId);
      }
      if (battleInfo_ != null) {
        output.WriteRawTag(42);
        output.WriteMessage(BattleInfo);
      }
      if (Retcode != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(Retcode);
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
      if (StageId != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(StageId);
      }
      if (battleInfo_ != null) {
        output.WriteRawTag(42);
        output.WriteMessage(BattleInfo);
      }
      if (Retcode != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(Retcode);
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
      if (StageId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(StageId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(EnterStrongChallengeActivityStageScRsp other) {
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
      if (other.StageId != 0) {
        StageId = other.StageId;
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
            StageId = input.ReadUInt32();
            break;
          }
          case 42: {
            if (battleInfo_ == null) {
              BattleInfo = new global::EggLink.DanhengServer.Proto.SceneBattleInfo();
            }
            input.ReadMessage(BattleInfo);
            break;
          }
          case 96: {
            Retcode = input.ReadUInt32();
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
            StageId = input.ReadUInt32();
            break;
          }
          case 42: {
            if (battleInfo_ == null) {
              BattleInfo = new global::EggLink.DanhengServer.Proto.SceneBattleInfo();
            }
            input.ReadMessage(BattleInfo);
            break;
          }
          case 96: {
            Retcode = input.ReadUInt32();
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
