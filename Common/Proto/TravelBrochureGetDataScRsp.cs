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
            "CiBUcmF2ZWxCcm9jaHVyZUdldERhdGFTY1JzcC5wcm90bxoRR05BUEtHTEFF",
            "TkYucHJvdG8ivwIKGlRyYXZlbEJyb2NodXJlR2V0RGF0YVNjUnNwEkEKC0hE",
            "T05QQkxLTktFGAEgAygLMiwuVHJhdmVsQnJvY2h1cmVHZXREYXRhU2NSc3Au",
            "SERPTlBCTEtOS0VFbnRyeRJBCgtLTEVMQklNSlBJSBgEIAMoCzIsLlRyYXZl",
            "bEJyb2NodXJlR2V0RGF0YVNjUnNwLktMRUxCSU1KUElIRW50cnkSFAoMY3Vz",
            "dG9tX3ZhbHVlGAogASgNEg8KB3JldGNvZGUYDCABKA0aQAoQSERPTlBCTEtO",
            "S0VFbnRyeRILCgNrZXkYASABKA0SGwoFdmFsdWUYAiABKAsyDC5HTkFQS0dM",
            "QUVORjoCOAEaMgoQS0xFTEJJTUpQSUhFbnRyeRILCgNrZXkYASABKA0SDQoF",
            "dmFsdWUYAiABKA06AjgBQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJv",
            "dG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.GNAPKGLAENFReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.TravelBrochureGetDataScRsp), global::EggLink.DanhengServer.Proto.TravelBrochureGetDataScRsp.Parser, new[]{ "HDONPBLKNKE", "KLELBIMJPIH", "CustomValue", "Retcode" }, null, null, null, new pbr::GeneratedClrTypeInfo[] { null, null, })
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
      hDONPBLKNKE_ = other.hDONPBLKNKE_.Clone();
      kLELBIMJPIH_ = other.kLELBIMJPIH_.Clone();
      customValue_ = other.customValue_;
      retcode_ = other.retcode_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TravelBrochureGetDataScRsp Clone() {
      return new TravelBrochureGetDataScRsp(this);
    }

    /// <summary>Field number for the "HDONPBLKNKE" field.</summary>
    public const int HDONPBLKNKEFieldNumber = 1;
    private static readonly pbc::MapField<uint, global::EggLink.DanhengServer.Proto.GNAPKGLAENF>.Codec _map_hDONPBLKNKE_codec
        = new pbc::MapField<uint, global::EggLink.DanhengServer.Proto.GNAPKGLAENF>.Codec(pb::FieldCodec.ForUInt32(8, 0), pb::FieldCodec.ForMessage(18, global::EggLink.DanhengServer.Proto.GNAPKGLAENF.Parser), 10);
    private readonly pbc::MapField<uint, global::EggLink.DanhengServer.Proto.GNAPKGLAENF> hDONPBLKNKE_ = new pbc::MapField<uint, global::EggLink.DanhengServer.Proto.GNAPKGLAENF>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::MapField<uint, global::EggLink.DanhengServer.Proto.GNAPKGLAENF> HDONPBLKNKE {
      get { return hDONPBLKNKE_; }
    }

    /// <summary>Field number for the "KLELBIMJPIH" field.</summary>
    public const int KLELBIMJPIHFieldNumber = 4;
    private static readonly pbc::MapField<uint, uint>.Codec _map_kLELBIMJPIH_codec
        = new pbc::MapField<uint, uint>.Codec(pb::FieldCodec.ForUInt32(8, 0), pb::FieldCodec.ForUInt32(16, 0), 34);
    private readonly pbc::MapField<uint, uint> kLELBIMJPIH_ = new pbc::MapField<uint, uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::MapField<uint, uint> KLELBIMJPIH {
      get { return kLELBIMJPIH_; }
    }

    /// <summary>Field number for the "custom_value" field.</summary>
    public const int CustomValueFieldNumber = 10;
    private uint customValue_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint CustomValue {
      get { return customValue_; }
      set {
        customValue_ = value;
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
      if (!HDONPBLKNKE.Equals(other.HDONPBLKNKE)) return false;
      if (!KLELBIMJPIH.Equals(other.KLELBIMJPIH)) return false;
      if (CustomValue != other.CustomValue) return false;
      if (Retcode != other.Retcode) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= HDONPBLKNKE.GetHashCode();
      hash ^= KLELBIMJPIH.GetHashCode();
      if (CustomValue != 0) hash ^= CustomValue.GetHashCode();
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
      hDONPBLKNKE_.WriteTo(output, _map_hDONPBLKNKE_codec);
      kLELBIMJPIH_.WriteTo(output, _map_kLELBIMJPIH_codec);
      if (CustomValue != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(CustomValue);
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
      hDONPBLKNKE_.WriteTo(ref output, _map_hDONPBLKNKE_codec);
      kLELBIMJPIH_.WriteTo(ref output, _map_kLELBIMJPIH_codec);
      if (CustomValue != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(CustomValue);
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
      size += hDONPBLKNKE_.CalculateSize(_map_hDONPBLKNKE_codec);
      size += kLELBIMJPIH_.CalculateSize(_map_kLELBIMJPIH_codec);
      if (CustomValue != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(CustomValue);
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
    public void MergeFrom(TravelBrochureGetDataScRsp other) {
      if (other == null) {
        return;
      }
      hDONPBLKNKE_.MergeFrom(other.hDONPBLKNKE_);
      kLELBIMJPIH_.MergeFrom(other.kLELBIMJPIH_);
      if (other.CustomValue != 0) {
        CustomValue = other.CustomValue;
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
          case 10: {
            hDONPBLKNKE_.AddEntriesFrom(input, _map_hDONPBLKNKE_codec);
            break;
          }
          case 34: {
            kLELBIMJPIH_.AddEntriesFrom(input, _map_kLELBIMJPIH_codec);
            break;
          }
          case 80: {
            CustomValue = input.ReadUInt32();
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
          case 10: {
            hDONPBLKNKE_.AddEntriesFrom(ref input, _map_hDONPBLKNKE_codec);
            break;
          }
          case 34: {
            kLELBIMJPIH_.AddEntriesFrom(ref input, _map_kLELBIMJPIH_codec);
            break;
          }
          case 80: {
            CustomValue = input.ReadUInt32();
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
