// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: MonopolyTakeRaffleTicketRewardScRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from MonopolyTakeRaffleTicketRewardScRsp.proto</summary>
  public static partial class MonopolyTakeRaffleTicketRewardScRspReflection {

    #region Descriptor
    /// <summary>File descriptor for MonopolyTakeRaffleTicketRewardScRsp.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static MonopolyTakeRaffleTicketRewardScRspReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CilNb25vcG9seVRha2VSYWZmbGVUaWNrZXRSZXdhcmRTY1JzcC5wcm90bxoO",
            "SXRlbUxpc3QucHJvdG8igAEKI01vbm9wb2x5VGFrZVJhZmZsZVRpY2tldFJl",
            "d2FyZFNjUnNwEh4KC3Jld2FyZF9saXN0GAYgASgLMgkuSXRlbUxpc3QSEwoL",
            "TklHRkhGQkJITEEYAyABKA0SEwoLT0pFS0pNR0tQSUwYCCABKA0SDwoHcmV0",
            "Y29kZRgPIAEoDUIeqgIbRWdnTGluay5EYW5oZW5nU2VydmVyLlByb3RvYgZw",
            "cm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.ItemListReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.MonopolyTakeRaffleTicketRewardScRsp), global::EggLink.DanhengServer.Proto.MonopolyTakeRaffleTicketRewardScRsp.Parser, new[]{ "RewardList", "NIGFHFBBHLA", "OJEKJMGKPIL", "Retcode" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class MonopolyTakeRaffleTicketRewardScRsp : pb::IMessage<MonopolyTakeRaffleTicketRewardScRsp>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<MonopolyTakeRaffleTicketRewardScRsp> _parser = new pb::MessageParser<MonopolyTakeRaffleTicketRewardScRsp>(() => new MonopolyTakeRaffleTicketRewardScRsp());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<MonopolyTakeRaffleTicketRewardScRsp> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.MonopolyTakeRaffleTicketRewardScRspReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MonopolyTakeRaffleTicketRewardScRsp() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MonopolyTakeRaffleTicketRewardScRsp(MonopolyTakeRaffleTicketRewardScRsp other) : this() {
      rewardList_ = other.rewardList_ != null ? other.rewardList_.Clone() : null;
      nIGFHFBBHLA_ = other.nIGFHFBBHLA_;
      oJEKJMGKPIL_ = other.oJEKJMGKPIL_;
      retcode_ = other.retcode_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MonopolyTakeRaffleTicketRewardScRsp Clone() {
      return new MonopolyTakeRaffleTicketRewardScRsp(this);
    }

    /// <summary>Field number for the "reward_list" field.</summary>
    public const int RewardListFieldNumber = 6;
    private global::EggLink.DanhengServer.Proto.ItemList rewardList_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.ItemList RewardList {
      get { return rewardList_; }
      set {
        rewardList_ = value;
      }
    }

    /// <summary>Field number for the "NIGFHFBBHLA" field.</summary>
    public const int NIGFHFBBHLAFieldNumber = 3;
    private uint nIGFHFBBHLA_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint NIGFHFBBHLA {
      get { return nIGFHFBBHLA_; }
      set {
        nIGFHFBBHLA_ = value;
      }
    }

    /// <summary>Field number for the "OJEKJMGKPIL" field.</summary>
    public const int OJEKJMGKPILFieldNumber = 8;
    private uint oJEKJMGKPIL_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint OJEKJMGKPIL {
      get { return oJEKJMGKPIL_; }
      set {
        oJEKJMGKPIL_ = value;
      }
    }

    /// <summary>Field number for the "retcode" field.</summary>
    public const int RetcodeFieldNumber = 15;
    private uint retcode_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Retcode {
      get { return retcode_; }
      set {
        retcode_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as MonopolyTakeRaffleTicketRewardScRsp);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(MonopolyTakeRaffleTicketRewardScRsp other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(RewardList, other.RewardList)) return false;
      if (NIGFHFBBHLA != other.NIGFHFBBHLA) return false;
      if (OJEKJMGKPIL != other.OJEKJMGKPIL) return false;
      if (Retcode != other.Retcode) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (rewardList_ != null) hash ^= RewardList.GetHashCode();
      if (NIGFHFBBHLA != 0) hash ^= NIGFHFBBHLA.GetHashCode();
      if (OJEKJMGKPIL != 0) hash ^= OJEKJMGKPIL.GetHashCode();
      if (Retcode != 0) hash ^= Retcode.GetHashCode();
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
      if (NIGFHFBBHLA != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(NIGFHFBBHLA);
      }
      if (rewardList_ != null) {
        output.WriteRawTag(50);
        output.WriteMessage(RewardList);
      }
      if (OJEKJMGKPIL != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(OJEKJMGKPIL);
      }
      if (Retcode != 0) {
        output.WriteRawTag(120);
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
      if (NIGFHFBBHLA != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(NIGFHFBBHLA);
      }
      if (rewardList_ != null) {
        output.WriteRawTag(50);
        output.WriteMessage(RewardList);
      }
      if (OJEKJMGKPIL != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(OJEKJMGKPIL);
      }
      if (Retcode != 0) {
        output.WriteRawTag(120);
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
      if (rewardList_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(RewardList);
      }
      if (NIGFHFBBHLA != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(NIGFHFBBHLA);
      }
      if (OJEKJMGKPIL != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(OJEKJMGKPIL);
      }
      if (Retcode != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Retcode);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(MonopolyTakeRaffleTicketRewardScRsp other) {
      if (other == null) {
        return;
      }
      if (other.rewardList_ != null) {
        if (rewardList_ == null) {
          RewardList = new global::EggLink.DanhengServer.Proto.ItemList();
        }
        RewardList.MergeFrom(other.RewardList);
      }
      if (other.NIGFHFBBHLA != 0) {
        NIGFHFBBHLA = other.NIGFHFBBHLA;
      }
      if (other.OJEKJMGKPIL != 0) {
        OJEKJMGKPIL = other.OJEKJMGKPIL;
      }
      if (other.Retcode != 0) {
        Retcode = other.Retcode;
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
            NIGFHFBBHLA = input.ReadUInt32();
            break;
          }
          case 50: {
            if (rewardList_ == null) {
              RewardList = new global::EggLink.DanhengServer.Proto.ItemList();
            }
            input.ReadMessage(RewardList);
            break;
          }
          case 64: {
            OJEKJMGKPIL = input.ReadUInt32();
            break;
          }
          case 120: {
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
            NIGFHFBBHLA = input.ReadUInt32();
            break;
          }
          case 50: {
            if (rewardList_ == null) {
              RewardList = new global::EggLink.DanhengServer.Proto.ItemList();
            }
            input.ReadMessage(RewardList);
            break;
          }
          case 64: {
            OJEKJMGKPIL = input.ReadUInt32();
            break;
          }
          case 120: {
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
