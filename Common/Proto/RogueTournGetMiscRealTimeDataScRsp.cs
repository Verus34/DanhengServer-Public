// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: RogueTournGetMiscRealTimeDataScRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from RogueTournGetMiscRealTimeDataScRsp.proto</summary>
  public static partial class RogueTournGetMiscRealTimeDataScRspReflection {

    #region Descriptor
    /// <summary>File descriptor for RogueTournGetMiscRealTimeDataScRsp.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static RogueTournGetMiscRealTimeDataScRspReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CihSb2d1ZVRvdXJuR2V0TWlzY1JlYWxUaW1lRGF0YVNjUnNwLnByb3RvGhFF",
            "SkZMRktGSkJKQy5wcm90bxoRSUJQTklNTE5QTEkucHJvdG8aEUZHT0lBTkhQ",
            "SkhILnByb3RvIp4BCiJSb2d1ZVRvdXJuR2V0TWlzY1JlYWxUaW1lRGF0YVNj",
            "UnNwEiEKC0RIUEtQTE9KSU9EGAcgASgLMgwuRUpGTEZLRkpCSkMSIQoLRUND",
            "Sk1GRkxNTUcYDSABKAsyDC5JQlBOSU1MTlBMSRIhCgtHQ05DS0ZDRk9JRBgM",
            "IAEoCzIMLkZHT0lBTkhQSkhIEg8KB3JldGNvZGUYCyABKA1CHqoCG0VnZ0xp",
            "bmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.EJFLFKFJBJCReflection.Descriptor, global::EggLink.DanhengServer.Proto.IBPNIMLNPLIReflection.Descriptor, global::EggLink.DanhengServer.Proto.FGOIANHPJHHReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.RogueTournGetMiscRealTimeDataScRsp), global::EggLink.DanhengServer.Proto.RogueTournGetMiscRealTimeDataScRsp.Parser, new[]{ "DHPKPLOJIOD", "ECCJMFFLMMG", "GCNCKFCFOID", "Retcode" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class RogueTournGetMiscRealTimeDataScRsp : pb::IMessage<RogueTournGetMiscRealTimeDataScRsp>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<RogueTournGetMiscRealTimeDataScRsp> _parser = new pb::MessageParser<RogueTournGetMiscRealTimeDataScRsp>(() => new RogueTournGetMiscRealTimeDataScRsp());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<RogueTournGetMiscRealTimeDataScRsp> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.RogueTournGetMiscRealTimeDataScRspReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RogueTournGetMiscRealTimeDataScRsp() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RogueTournGetMiscRealTimeDataScRsp(RogueTournGetMiscRealTimeDataScRsp other) : this() {
      dHPKPLOJIOD_ = other.dHPKPLOJIOD_ != null ? other.dHPKPLOJIOD_.Clone() : null;
      eCCJMFFLMMG_ = other.eCCJMFFLMMG_ != null ? other.eCCJMFFLMMG_.Clone() : null;
      gCNCKFCFOID_ = other.gCNCKFCFOID_ != null ? other.gCNCKFCFOID_.Clone() : null;
      retcode_ = other.retcode_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RogueTournGetMiscRealTimeDataScRsp Clone() {
      return new RogueTournGetMiscRealTimeDataScRsp(this);
    }

    /// <summary>Field number for the "DHPKPLOJIOD" field.</summary>
    public const int DHPKPLOJIODFieldNumber = 7;
    private global::EggLink.DanhengServer.Proto.EJFLFKFJBJC dHPKPLOJIOD_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.EJFLFKFJBJC DHPKPLOJIOD {
      get { return dHPKPLOJIOD_; }
      set {
        dHPKPLOJIOD_ = value;
      }
    }

    /// <summary>Field number for the "ECCJMFFLMMG" field.</summary>
    public const int ECCJMFFLMMGFieldNumber = 13;
    private global::EggLink.DanhengServer.Proto.IBPNIMLNPLI eCCJMFFLMMG_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.IBPNIMLNPLI ECCJMFFLMMG {
      get { return eCCJMFFLMMG_; }
      set {
        eCCJMFFLMMG_ = value;
      }
    }

    /// <summary>Field number for the "GCNCKFCFOID" field.</summary>
    public const int GCNCKFCFOIDFieldNumber = 12;
    private global::EggLink.DanhengServer.Proto.FGOIANHPJHH gCNCKFCFOID_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.FGOIANHPJHH GCNCKFCFOID {
      get { return gCNCKFCFOID_; }
      set {
        gCNCKFCFOID_ = value;
      }
    }

    /// <summary>Field number for the "retcode" field.</summary>
    public const int RetcodeFieldNumber = 11;
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
      return Equals(other as RogueTournGetMiscRealTimeDataScRsp);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(RogueTournGetMiscRealTimeDataScRsp other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(DHPKPLOJIOD, other.DHPKPLOJIOD)) return false;
      if (!object.Equals(ECCJMFFLMMG, other.ECCJMFFLMMG)) return false;
      if (!object.Equals(GCNCKFCFOID, other.GCNCKFCFOID)) return false;
      if (Retcode != other.Retcode) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (dHPKPLOJIOD_ != null) hash ^= DHPKPLOJIOD.GetHashCode();
      if (eCCJMFFLMMG_ != null) hash ^= ECCJMFFLMMG.GetHashCode();
      if (gCNCKFCFOID_ != null) hash ^= GCNCKFCFOID.GetHashCode();
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
      if (dHPKPLOJIOD_ != null) {
        output.WriteRawTag(58);
        output.WriteMessage(DHPKPLOJIOD);
      }
      if (Retcode != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(Retcode);
      }
      if (gCNCKFCFOID_ != null) {
        output.WriteRawTag(98);
        output.WriteMessage(GCNCKFCFOID);
      }
      if (eCCJMFFLMMG_ != null) {
        output.WriteRawTag(106);
        output.WriteMessage(ECCJMFFLMMG);
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
      if (dHPKPLOJIOD_ != null) {
        output.WriteRawTag(58);
        output.WriteMessage(DHPKPLOJIOD);
      }
      if (Retcode != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(Retcode);
      }
      if (gCNCKFCFOID_ != null) {
        output.WriteRawTag(98);
        output.WriteMessage(GCNCKFCFOID);
      }
      if (eCCJMFFLMMG_ != null) {
        output.WriteRawTag(106);
        output.WriteMessage(ECCJMFFLMMG);
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
      if (dHPKPLOJIOD_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(DHPKPLOJIOD);
      }
      if (eCCJMFFLMMG_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(ECCJMFFLMMG);
      }
      if (gCNCKFCFOID_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(GCNCKFCFOID);
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
    public void MergeFrom(RogueTournGetMiscRealTimeDataScRsp other) {
      if (other == null) {
        return;
      }
      if (other.dHPKPLOJIOD_ != null) {
        if (dHPKPLOJIOD_ == null) {
          DHPKPLOJIOD = new global::EggLink.DanhengServer.Proto.EJFLFKFJBJC();
        }
        DHPKPLOJIOD.MergeFrom(other.DHPKPLOJIOD);
      }
      if (other.eCCJMFFLMMG_ != null) {
        if (eCCJMFFLMMG_ == null) {
          ECCJMFFLMMG = new global::EggLink.DanhengServer.Proto.IBPNIMLNPLI();
        }
        ECCJMFFLMMG.MergeFrom(other.ECCJMFFLMMG);
      }
      if (other.gCNCKFCFOID_ != null) {
        if (gCNCKFCFOID_ == null) {
          GCNCKFCFOID = new global::EggLink.DanhengServer.Proto.FGOIANHPJHH();
        }
        GCNCKFCFOID.MergeFrom(other.GCNCKFCFOID);
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
          case 58: {
            if (dHPKPLOJIOD_ == null) {
              DHPKPLOJIOD = new global::EggLink.DanhengServer.Proto.EJFLFKFJBJC();
            }
            input.ReadMessage(DHPKPLOJIOD);
            break;
          }
          case 88: {
            Retcode = input.ReadUInt32();
            break;
          }
          case 98: {
            if (gCNCKFCFOID_ == null) {
              GCNCKFCFOID = new global::EggLink.DanhengServer.Proto.FGOIANHPJHH();
            }
            input.ReadMessage(GCNCKFCFOID);
            break;
          }
          case 106: {
            if (eCCJMFFLMMG_ == null) {
              ECCJMFFLMMG = new global::EggLink.DanhengServer.Proto.IBPNIMLNPLI();
            }
            input.ReadMessage(ECCJMFFLMMG);
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
          case 58: {
            if (dHPKPLOJIOD_ == null) {
              DHPKPLOJIOD = new global::EggLink.DanhengServer.Proto.EJFLFKFJBJC();
            }
            input.ReadMessage(DHPKPLOJIOD);
            break;
          }
          case 88: {
            Retcode = input.ReadUInt32();
            break;
          }
          case 98: {
            if (gCNCKFCFOID_ == null) {
              GCNCKFCFOID = new global::EggLink.DanhengServer.Proto.FGOIANHPJHH();
            }
            input.ReadMessage(GCNCKFCFOID);
            break;
          }
          case 106: {
            if (eCCJMFFLMMG_ == null) {
              ECCJMFFLMMG = new global::EggLink.DanhengServer.Proto.IBPNIMLNPLI();
            }
            input.ReadMessage(ECCJMFFLMMG);
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
