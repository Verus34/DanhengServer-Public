// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: SharePunkLordMonsterScRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from SharePunkLordMonsterScRsp.proto</summary>
  public static partial class SharePunkLordMonsterScRspReflection {

    #region Descriptor
    /// <summary>File descriptor for SharePunkLordMonsterScRsp.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static SharePunkLordMonsterScRspReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch9TaGFyZVB1bmtMb3JkTW9uc3RlclNjUnNwLnByb3RvGhdQdW5rTG9yZFNo",
            "YXJlVHlwZS5wcm90byJ2ChlTaGFyZVB1bmtMb3JkTW9uc3RlclNjUnNwEg8K",
            "B3JldGNvZGUYBiABKA0SEgoKbW9uc3Rlcl9pZBgOIAEoDRILCgN1aWQYDSAB",
            "KA0SJwoLTERHTU1CS1BJSk0YDyABKA4yEi5QdW5rTG9yZFNoYXJlVHlwZUIe",
            "qgIbRWdnTGluay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.PunkLordShareTypeReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.SharePunkLordMonsterScRsp), global::EggLink.DanhengServer.Proto.SharePunkLordMonsterScRsp.Parser, new[]{ "Retcode", "MonsterId", "Uid", "LDGMMBKPIJM" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class SharePunkLordMonsterScRsp : pb::IMessage<SharePunkLordMonsterScRsp>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<SharePunkLordMonsterScRsp> _parser = new pb::MessageParser<SharePunkLordMonsterScRsp>(() => new SharePunkLordMonsterScRsp());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<SharePunkLordMonsterScRsp> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.SharePunkLordMonsterScRspReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SharePunkLordMonsterScRsp() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SharePunkLordMonsterScRsp(SharePunkLordMonsterScRsp other) : this() {
      retcode_ = other.retcode_;
      monsterId_ = other.monsterId_;
      uid_ = other.uid_;
      lDGMMBKPIJM_ = other.lDGMMBKPIJM_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SharePunkLordMonsterScRsp Clone() {
      return new SharePunkLordMonsterScRsp(this);
    }

    /// <summary>Field number for the "retcode" field.</summary>
    public const int RetcodeFieldNumber = 6;
    private uint retcode_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Retcode {
      get { return retcode_; }
      set {
        retcode_ = value;
      }
    }

    /// <summary>Field number for the "monster_id" field.</summary>
    public const int MonsterIdFieldNumber = 14;
    private uint monsterId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint MonsterId {
      get { return monsterId_; }
      set {
        monsterId_ = value;
      }
    }

    /// <summary>Field number for the "uid" field.</summary>
    public const int UidFieldNumber = 13;
    private uint uid_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Uid {
      get { return uid_; }
      set {
        uid_ = value;
      }
    }

    /// <summary>Field number for the "LDGMMBKPIJM" field.</summary>
    public const int LDGMMBKPIJMFieldNumber = 15;
    private global::EggLink.DanhengServer.Proto.PunkLordShareType lDGMMBKPIJM_ = global::EggLink.DanhengServer.Proto.PunkLordShareType.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.PunkLordShareType LDGMMBKPIJM {
      get { return lDGMMBKPIJM_; }
      set {
        lDGMMBKPIJM_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as SharePunkLordMonsterScRsp);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(SharePunkLordMonsterScRsp other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Retcode != other.Retcode) return false;
      if (MonsterId != other.MonsterId) return false;
      if (Uid != other.Uid) return false;
      if (LDGMMBKPIJM != other.LDGMMBKPIJM) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Retcode != 0) hash ^= Retcode.GetHashCode();
      if (MonsterId != 0) hash ^= MonsterId.GetHashCode();
      if (Uid != 0) hash ^= Uid.GetHashCode();
      if (LDGMMBKPIJM != global::EggLink.DanhengServer.Proto.PunkLordShareType.None) hash ^= LDGMMBKPIJM.GetHashCode();
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
        output.WriteRawTag(48);
        output.WriteUInt32(Retcode);
      }
      if (Uid != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(Uid);
      }
      if (MonsterId != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(MonsterId);
      }
      if (LDGMMBKPIJM != global::EggLink.DanhengServer.Proto.PunkLordShareType.None) {
        output.WriteRawTag(120);
        output.WriteEnum((int) LDGMMBKPIJM);
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
        output.WriteRawTag(48);
        output.WriteUInt32(Retcode);
      }
      if (Uid != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(Uid);
      }
      if (MonsterId != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(MonsterId);
      }
      if (LDGMMBKPIJM != global::EggLink.DanhengServer.Proto.PunkLordShareType.None) {
        output.WriteRawTag(120);
        output.WriteEnum((int) LDGMMBKPIJM);
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
      if (Retcode != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Retcode);
      }
      if (MonsterId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(MonsterId);
      }
      if (Uid != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Uid);
      }
      if (LDGMMBKPIJM != global::EggLink.DanhengServer.Proto.PunkLordShareType.None) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) LDGMMBKPIJM);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(SharePunkLordMonsterScRsp other) {
      if (other == null) {
        return;
      }
      if (other.Retcode != 0) {
        Retcode = other.Retcode;
      }
      if (other.MonsterId != 0) {
        MonsterId = other.MonsterId;
      }
      if (other.Uid != 0) {
        Uid = other.Uid;
      }
      if (other.LDGMMBKPIJM != global::EggLink.DanhengServer.Proto.PunkLordShareType.None) {
        LDGMMBKPIJM = other.LDGMMBKPIJM;
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
          case 48: {
            Retcode = input.ReadUInt32();
            break;
          }
          case 104: {
            Uid = input.ReadUInt32();
            break;
          }
          case 112: {
            MonsterId = input.ReadUInt32();
            break;
          }
          case 120: {
            LDGMMBKPIJM = (global::EggLink.DanhengServer.Proto.PunkLordShareType) input.ReadEnum();
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
          case 48: {
            Retcode = input.ReadUInt32();
            break;
          }
          case 104: {
            Uid = input.ReadUInt32();
            break;
          }
          case 112: {
            MonsterId = input.ReadUInt32();
            break;
          }
          case 120: {
            LDGMMBKPIJM = (global::EggLink.DanhengServer.Proto.PunkLordShareType) input.ReadEnum();
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
