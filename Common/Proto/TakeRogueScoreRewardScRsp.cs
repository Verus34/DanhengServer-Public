// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: TakeRogueScoreRewardScRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from TakeRogueScoreRewardScRsp.proto</summary>
  public static partial class TakeRogueScoreRewardScRspReflection {

    #region Descriptor
    /// <summary>File descriptor for TakeRogueScoreRewardScRsp.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static TakeRogueScoreRewardScRspReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch9UYWtlUm9ndWVTY29yZVJld2FyZFNjUnNwLnByb3RvGhpSb2d1ZVNjb3Jl",
            "UmV3YXJkSW5mby5wcm90bxoOSXRlbUxpc3QucHJvdG8ikAEKGVRha2VSb2d1",
            "ZVNjb3JlUmV3YXJkU2NSc3ASDwoHcG9vbF9pZBgIIAEoDRIPCgdyZXRjb2Rl",
            "GAMgASgNEjYKF3JvZ3VlX3Njb3JlX3Jld2FyZF9pbmZvGAUgASgLMhUuUm9n",
            "dWVTY29yZVJld2FyZEluZm8SGQoGcmV3YXJkGA0gASgLMgkuSXRlbUxpc3RC",
            "HqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.RogueScoreRewardInfoReflection.Descriptor, global::EggLink.DanhengServer.Proto.ItemListReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.TakeRogueScoreRewardScRsp), global::EggLink.DanhengServer.Proto.TakeRogueScoreRewardScRsp.Parser, new[]{ "PoolId", "Retcode", "RogueScoreRewardInfo", "Reward" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class TakeRogueScoreRewardScRsp : pb::IMessage<TakeRogueScoreRewardScRsp>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<TakeRogueScoreRewardScRsp> _parser = new pb::MessageParser<TakeRogueScoreRewardScRsp>(() => new TakeRogueScoreRewardScRsp());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<TakeRogueScoreRewardScRsp> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.TakeRogueScoreRewardScRspReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TakeRogueScoreRewardScRsp() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TakeRogueScoreRewardScRsp(TakeRogueScoreRewardScRsp other) : this() {
      poolId_ = other.poolId_;
      retcode_ = other.retcode_;
      rogueScoreRewardInfo_ = other.rogueScoreRewardInfo_ != null ? other.rogueScoreRewardInfo_.Clone() : null;
      reward_ = other.reward_ != null ? other.reward_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TakeRogueScoreRewardScRsp Clone() {
      return new TakeRogueScoreRewardScRsp(this);
    }

    /// <summary>Field number for the "pool_id" field.</summary>
    public const int PoolIdFieldNumber = 8;
    private uint poolId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint PoolId {
      get { return poolId_; }
      set {
        poolId_ = value;
      }
    }

    /// <summary>Field number for the "retcode" field.</summary>
    public const int RetcodeFieldNumber = 3;
    private uint retcode_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Retcode {
      get { return retcode_; }
      set {
        retcode_ = value;
      }
    }

    /// <summary>Field number for the "rogue_score_reward_info" field.</summary>
    public const int RogueScoreRewardInfoFieldNumber = 5;
    private global::EggLink.DanhengServer.Proto.RogueScoreRewardInfo rogueScoreRewardInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.RogueScoreRewardInfo RogueScoreRewardInfo {
      get { return rogueScoreRewardInfo_; }
      set {
        rogueScoreRewardInfo_ = value;
      }
    }

    /// <summary>Field number for the "reward" field.</summary>
    public const int RewardFieldNumber = 13;
    private global::EggLink.DanhengServer.Proto.ItemList reward_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.ItemList Reward {
      get { return reward_; }
      set {
        reward_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as TakeRogueScoreRewardScRsp);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(TakeRogueScoreRewardScRsp other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (PoolId != other.PoolId) return false;
      if (Retcode != other.Retcode) return false;
      if (!object.Equals(RogueScoreRewardInfo, other.RogueScoreRewardInfo)) return false;
      if (!object.Equals(Reward, other.Reward)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (PoolId != 0) hash ^= PoolId.GetHashCode();
      if (Retcode != 0) hash ^= Retcode.GetHashCode();
      if (rogueScoreRewardInfo_ != null) hash ^= RogueScoreRewardInfo.GetHashCode();
      if (reward_ != null) hash ^= Reward.GetHashCode();
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
      if (Retcode != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(Retcode);
      }
      if (rogueScoreRewardInfo_ != null) {
        output.WriteRawTag(42);
        output.WriteMessage(RogueScoreRewardInfo);
      }
      if (PoolId != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(PoolId);
      }
      if (reward_ != null) {
        output.WriteRawTag(106);
        output.WriteMessage(Reward);
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
      if (Retcode != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(Retcode);
      }
      if (rogueScoreRewardInfo_ != null) {
        output.WriteRawTag(42);
        output.WriteMessage(RogueScoreRewardInfo);
      }
      if (PoolId != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(PoolId);
      }
      if (reward_ != null) {
        output.WriteRawTag(106);
        output.WriteMessage(Reward);
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
      if (PoolId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(PoolId);
      }
      if (Retcode != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Retcode);
      }
      if (rogueScoreRewardInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(RogueScoreRewardInfo);
      }
      if (reward_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Reward);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(TakeRogueScoreRewardScRsp other) {
      if (other == null) {
        return;
      }
      if (other.PoolId != 0) {
        PoolId = other.PoolId;
      }
      if (other.Retcode != 0) {
        Retcode = other.Retcode;
      }
      if (other.rogueScoreRewardInfo_ != null) {
        if (rogueScoreRewardInfo_ == null) {
          RogueScoreRewardInfo = new global::EggLink.DanhengServer.Proto.RogueScoreRewardInfo();
        }
        RogueScoreRewardInfo.MergeFrom(other.RogueScoreRewardInfo);
      }
      if (other.reward_ != null) {
        if (reward_ == null) {
          Reward = new global::EggLink.DanhengServer.Proto.ItemList();
        }
        Reward.MergeFrom(other.Reward);
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
            Retcode = input.ReadUInt32();
            break;
          }
          case 42: {
            if (rogueScoreRewardInfo_ == null) {
              RogueScoreRewardInfo = new global::EggLink.DanhengServer.Proto.RogueScoreRewardInfo();
            }
            input.ReadMessage(RogueScoreRewardInfo);
            break;
          }
          case 64: {
            PoolId = input.ReadUInt32();
            break;
          }
          case 106: {
            if (reward_ == null) {
              Reward = new global::EggLink.DanhengServer.Proto.ItemList();
            }
            input.ReadMessage(Reward);
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
            Retcode = input.ReadUInt32();
            break;
          }
          case 42: {
            if (rogueScoreRewardInfo_ == null) {
              RogueScoreRewardInfo = new global::EggLink.DanhengServer.Proto.RogueScoreRewardInfo();
            }
            input.ReadMessage(RogueScoreRewardInfo);
            break;
          }
          case 64: {
            PoolId = input.ReadUInt32();
            break;
          }
          case 106: {
            if (reward_ == null) {
              Reward = new global::EggLink.DanhengServer.Proto.ItemList();
            }
            input.ReadMessage(Reward);
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
