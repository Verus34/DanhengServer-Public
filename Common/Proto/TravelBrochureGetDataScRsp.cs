// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: TravelBrochureGetDataScRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from TravelBrochureGetDataScRsp.proto</summary>
  public static partial class TravelBrochureGetDataScRspReflection {

    #region Descriptor
    /// <summary>File descriptor for TravelBrochureGetDataScRsp.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static TravelBrochureGetDataScRspReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiBUcmF2ZWxCcm9jaHVyZUdldERhdGFTY1JzcC5wcm90bxoRQkJKRUpBTEZI",
            "RU4ucHJvdG8ivgIKGlRyYXZlbEJyb2NodXJlR2V0RGF0YVNjUnNwEg8KB3Jl",
            "dGNvZGUYDiABKA0SEwoLSU1QSEVJRElQR0MYDCABKA0SQQoLQklBR0hPUE5P",
            "RFAYBiADKAsyLC5UcmF2ZWxCcm9jaHVyZUdldERhdGFTY1JzcC5CSUFHSE9Q",
            "Tk9EUEVudHJ5EkEKC01PSVBQRERBT0hNGAcgAygLMiwuVHJhdmVsQnJvY2h1",
            "cmVHZXREYXRhU2NSc3AuTU9JUFBEREFPSE1FbnRyeRpAChBCSUFHSE9QTk9E",
            "UEVudHJ5EgsKA2tleRgBIAEoDRIbCgV2YWx1ZRgCIAEoCzIMLkJCSkVKQUxG",
            "SEVOOgI4ARoyChBNT0lQUEREQU9ITUVudHJ5EgsKA2tleRgBIAEoDRINCgV2",
            "YWx1ZRgCIAEoDToCOAFCHqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90",
            "b2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.BBJEJALFHENReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.TravelBrochureGetDataScRsp), global::EggLink.DanhengServer.Proto.TravelBrochureGetDataScRsp.Parser, new[]{ "Retcode", "IMPHEIDIPGC", "BIAGHOPNODP", "MOIPPDDAOHM" }, null, null, null, new pbr::GeneratedClrTypeInfo[] { null, null, })
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class TravelBrochureGetDataScRsp : pb::IMessage<TravelBrochureGetDataScRsp>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<TravelBrochureGetDataScRsp> _parser = new pb::MessageParser<TravelBrochureGetDataScRsp>(() => new TravelBrochureGetDataScRsp());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<TravelBrochureGetDataScRsp> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.TravelBrochureGetDataScRspReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TravelBrochureGetDataScRsp() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TravelBrochureGetDataScRsp(TravelBrochureGetDataScRsp other) : this() {
      retcode_ = other.retcode_;
      iMPHEIDIPGC_ = other.iMPHEIDIPGC_;
      bIAGHOPNODP_ = other.bIAGHOPNODP_.Clone();
      mOIPPDDAOHM_ = other.mOIPPDDAOHM_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TravelBrochureGetDataScRsp Clone() {
      return new TravelBrochureGetDataScRsp(this);
    }

    /// <summary>Field number for the "retcode" field.</summary>
    public const int RetcodeFieldNumber = 14;
    private uint retcode_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Retcode {
      get { return retcode_; }
      set {
        retcode_ = value;
      }
    }

    /// <summary>Field number for the "IMPHEIDIPGC" field.</summary>
    public const int IMPHEIDIPGCFieldNumber = 12;
    private uint iMPHEIDIPGC_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint IMPHEIDIPGC {
      get { return iMPHEIDIPGC_; }
      set {
        iMPHEIDIPGC_ = value;
      }
    }

    /// <summary>Field number for the "BIAGHOPNODP" field.</summary>
    public const int BIAGHOPNODPFieldNumber = 6;
    private static readonly pbc::MapField<uint, global::EggLink.DanhengServer.Proto.BBJEJALFHEN>.Codec _map_bIAGHOPNODP_codec
        = new pbc::MapField<uint, global::EggLink.DanhengServer.Proto.BBJEJALFHEN>.Codec(pb::FieldCodec.ForUInt32(8, 0), pb::FieldCodec.ForMessage(18, global::EggLink.DanhengServer.Proto.BBJEJALFHEN.Parser), 50);
    private readonly pbc::MapField<uint, global::EggLink.DanhengServer.Proto.BBJEJALFHEN> bIAGHOPNODP_ = new pbc::MapField<uint, global::EggLink.DanhengServer.Proto.BBJEJALFHEN>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::MapField<uint, global::EggLink.DanhengServer.Proto.BBJEJALFHEN> BIAGHOPNODP {
      get { return bIAGHOPNODP_; }
    }

    /// <summary>Field number for the "MOIPPDDAOHM" field.</summary>
    public const int MOIPPDDAOHMFieldNumber = 7;
    private static readonly pbc::MapField<uint, uint>.Codec _map_mOIPPDDAOHM_codec
        = new pbc::MapField<uint, uint>.Codec(pb::FieldCodec.ForUInt32(8, 0), pb::FieldCodec.ForUInt32(16, 0), 58);
    private readonly pbc::MapField<uint, uint> mOIPPDDAOHM_ = new pbc::MapField<uint, uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::MapField<uint, uint> MOIPPDDAOHM {
      get { return mOIPPDDAOHM_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as TravelBrochureGetDataScRsp);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(TravelBrochureGetDataScRsp other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Retcode != other.Retcode) return false;
      if (IMPHEIDIPGC != other.IMPHEIDIPGC) return false;
      if (!BIAGHOPNODP.Equals(other.BIAGHOPNODP)) return false;
      if (!MOIPPDDAOHM.Equals(other.MOIPPDDAOHM)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Retcode != 0) hash ^= Retcode.GetHashCode();
      if (IMPHEIDIPGC != 0) hash ^= IMPHEIDIPGC.GetHashCode();
      hash ^= BIAGHOPNODP.GetHashCode();
      hash ^= MOIPPDDAOHM.GetHashCode();
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
      bIAGHOPNODP_.WriteTo(output, _map_bIAGHOPNODP_codec);
      mOIPPDDAOHM_.WriteTo(output, _map_mOIPPDDAOHM_codec);
      if (IMPHEIDIPGC != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(IMPHEIDIPGC);
      }
      if (Retcode != 0) {
        output.WriteRawTag(112);
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
      bIAGHOPNODP_.WriteTo(ref output, _map_bIAGHOPNODP_codec);
      mOIPPDDAOHM_.WriteTo(ref output, _map_mOIPPDDAOHM_codec);
      if (IMPHEIDIPGC != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(IMPHEIDIPGC);
      }
      if (Retcode != 0) {
        output.WriteRawTag(112);
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
      if (Retcode != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Retcode);
      }
      if (IMPHEIDIPGC != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(IMPHEIDIPGC);
      }
      size += bIAGHOPNODP_.CalculateSize(_map_bIAGHOPNODP_codec);
      size += mOIPPDDAOHM_.CalculateSize(_map_mOIPPDDAOHM_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(TravelBrochureGetDataScRsp other) {
      if (other == null) {
        return;
      }
      if (other.Retcode != 0) {
        Retcode = other.Retcode;
      }
      if (other.IMPHEIDIPGC != 0) {
        IMPHEIDIPGC = other.IMPHEIDIPGC;
      }
      bIAGHOPNODP_.MergeFrom(other.bIAGHOPNODP_);
      mOIPPDDAOHM_.MergeFrom(other.mOIPPDDAOHM_);
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
          case 50: {
            bIAGHOPNODP_.AddEntriesFrom(input, _map_bIAGHOPNODP_codec);
            break;
          }
          case 58: {
            mOIPPDDAOHM_.AddEntriesFrom(input, _map_mOIPPDDAOHM_codec);
            break;
          }
          case 96: {
            IMPHEIDIPGC = input.ReadUInt32();
            break;
          }
          case 112: {
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
          case 50: {
            bIAGHOPNODP_.AddEntriesFrom(ref input, _map_bIAGHOPNODP_codec);
            break;
          }
          case 58: {
            mOIPPDDAOHM_.AddEntriesFrom(ref input, _map_mOIPPDDAOHM_codec);
            break;
          }
          case 96: {
            IMPHEIDIPGC = input.ReadUInt32();
            break;
          }
          case 112: {
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