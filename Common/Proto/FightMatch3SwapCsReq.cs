// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: FightMatch3SwapCsReq.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from FightMatch3SwapCsReq.proto</summary>
  public static partial class FightMatch3SwapCsReqReflection {

    #region Descriptor
    /// <summary>File descriptor for FightMatch3SwapCsReq.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static FightMatch3SwapCsReqReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChpGaWdodE1hdGNoM1N3YXBDc1JlcS5wcm90bxoRSEFJSUtHREhGTU8ucHJv",
            "dG8aEUVHRE9NQ01CS09CLnByb3RvIpQBChRGaWdodE1hdGNoM1N3YXBDc1Jl",
            "cRIhCgtJSUhGQUNKREhCUBgPIAEoCzIMLkhBSUlLR0RIRk1PEhMKC0NIT0NJ",
            "UEJPUE1CGAYgASgNEiEKC0hOTURGTkJQRk5JGAUgAygLMgwuRUdET01DTUJL",
            "T0ISIQoLRktDT0RQS09HR0IYDiABKAsyDC5IQUlJS0dESEZNT0IeqgIbRWdn",
            "TGluay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.HAIIKGDHFMOReflection.Descriptor, global::EggLink.DanhengServer.Proto.EGDOMCMBKOBReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.FightMatch3SwapCsReq), global::EggLink.DanhengServer.Proto.FightMatch3SwapCsReq.Parser, new[]{ "IIHFACJDHBP", "CHOCIPBOPMB", "HNMDFNBPFNI", "FKCODPKOGGB" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class FightMatch3SwapCsReq : pb::IMessage<FightMatch3SwapCsReq>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<FightMatch3SwapCsReq> _parser = new pb::MessageParser<FightMatch3SwapCsReq>(() => new FightMatch3SwapCsReq());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<FightMatch3SwapCsReq> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.FightMatch3SwapCsReqReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FightMatch3SwapCsReq() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FightMatch3SwapCsReq(FightMatch3SwapCsReq other) : this() {
      iIHFACJDHBP_ = other.iIHFACJDHBP_ != null ? other.iIHFACJDHBP_.Clone() : null;
      cHOCIPBOPMB_ = other.cHOCIPBOPMB_;
      hNMDFNBPFNI_ = other.hNMDFNBPFNI_.Clone();
      fKCODPKOGGB_ = other.fKCODPKOGGB_ != null ? other.fKCODPKOGGB_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FightMatch3SwapCsReq Clone() {
      return new FightMatch3SwapCsReq(this);
    }

    /// <summary>Field number for the "IIHFACJDHBP" field.</summary>
    public const int IIHFACJDHBPFieldNumber = 15;
    private global::EggLink.DanhengServer.Proto.HAIIKGDHFMO iIHFACJDHBP_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.HAIIKGDHFMO IIHFACJDHBP {
      get { return iIHFACJDHBP_; }
      set {
        iIHFACJDHBP_ = value;
      }
    }

    /// <summary>Field number for the "CHOCIPBOPMB" field.</summary>
    public const int CHOCIPBOPMBFieldNumber = 6;
    private uint cHOCIPBOPMB_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint CHOCIPBOPMB {
      get { return cHOCIPBOPMB_; }
      set {
        cHOCIPBOPMB_ = value;
      }
    }

    /// <summary>Field number for the "HNMDFNBPFNI" field.</summary>
    public const int HNMDFNBPFNIFieldNumber = 5;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.EGDOMCMBKOB> _repeated_hNMDFNBPFNI_codec
        = pb::FieldCodec.ForMessage(42, global::EggLink.DanhengServer.Proto.EGDOMCMBKOB.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.EGDOMCMBKOB> hNMDFNBPFNI_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.EGDOMCMBKOB>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.EGDOMCMBKOB> HNMDFNBPFNI {
      get { return hNMDFNBPFNI_; }
    }

    /// <summary>Field number for the "FKCODPKOGGB" field.</summary>
    public const int FKCODPKOGGBFieldNumber = 14;
    private global::EggLink.DanhengServer.Proto.HAIIKGDHFMO fKCODPKOGGB_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.HAIIKGDHFMO FKCODPKOGGB {
      get { return fKCODPKOGGB_; }
      set {
        fKCODPKOGGB_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as FightMatch3SwapCsReq);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(FightMatch3SwapCsReq other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(IIHFACJDHBP, other.IIHFACJDHBP)) return false;
      if (CHOCIPBOPMB != other.CHOCIPBOPMB) return false;
      if(!hNMDFNBPFNI_.Equals(other.hNMDFNBPFNI_)) return false;
      if (!object.Equals(FKCODPKOGGB, other.FKCODPKOGGB)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (iIHFACJDHBP_ != null) hash ^= IIHFACJDHBP.GetHashCode();
      if (CHOCIPBOPMB != 0) hash ^= CHOCIPBOPMB.GetHashCode();
      hash ^= hNMDFNBPFNI_.GetHashCode();
      if (fKCODPKOGGB_ != null) hash ^= FKCODPKOGGB.GetHashCode();
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
      hNMDFNBPFNI_.WriteTo(output, _repeated_hNMDFNBPFNI_codec);
      if (CHOCIPBOPMB != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(CHOCIPBOPMB);
      }
      if (fKCODPKOGGB_ != null) {
        output.WriteRawTag(114);
        output.WriteMessage(FKCODPKOGGB);
      }
      if (iIHFACJDHBP_ != null) {
        output.WriteRawTag(122);
        output.WriteMessage(IIHFACJDHBP);
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
      hNMDFNBPFNI_.WriteTo(ref output, _repeated_hNMDFNBPFNI_codec);
      if (CHOCIPBOPMB != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(CHOCIPBOPMB);
      }
      if (fKCODPKOGGB_ != null) {
        output.WriteRawTag(114);
        output.WriteMessage(FKCODPKOGGB);
      }
      if (iIHFACJDHBP_ != null) {
        output.WriteRawTag(122);
        output.WriteMessage(IIHFACJDHBP);
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
      if (iIHFACJDHBP_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(IIHFACJDHBP);
      }
      if (CHOCIPBOPMB != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(CHOCIPBOPMB);
      }
      size += hNMDFNBPFNI_.CalculateSize(_repeated_hNMDFNBPFNI_codec);
      if (fKCODPKOGGB_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(FKCODPKOGGB);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(FightMatch3SwapCsReq other) {
      if (other == null) {
        return;
      }
      if (other.iIHFACJDHBP_ != null) {
        if (iIHFACJDHBP_ == null) {
          IIHFACJDHBP = new global::EggLink.DanhengServer.Proto.HAIIKGDHFMO();
        }
        IIHFACJDHBP.MergeFrom(other.IIHFACJDHBP);
      }
      if (other.CHOCIPBOPMB != 0) {
        CHOCIPBOPMB = other.CHOCIPBOPMB;
      }
      hNMDFNBPFNI_.Add(other.hNMDFNBPFNI_);
      if (other.fKCODPKOGGB_ != null) {
        if (fKCODPKOGGB_ == null) {
          FKCODPKOGGB = new global::EggLink.DanhengServer.Proto.HAIIKGDHFMO();
        }
        FKCODPKOGGB.MergeFrom(other.FKCODPKOGGB);
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
          case 42: {
            hNMDFNBPFNI_.AddEntriesFrom(input, _repeated_hNMDFNBPFNI_codec);
            break;
          }
          case 48: {
            CHOCIPBOPMB = input.ReadUInt32();
            break;
          }
          case 114: {
            if (fKCODPKOGGB_ == null) {
              FKCODPKOGGB = new global::EggLink.DanhengServer.Proto.HAIIKGDHFMO();
            }
            input.ReadMessage(FKCODPKOGGB);
            break;
          }
          case 122: {
            if (iIHFACJDHBP_ == null) {
              IIHFACJDHBP = new global::EggLink.DanhengServer.Proto.HAIIKGDHFMO();
            }
            input.ReadMessage(IIHFACJDHBP);
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
          case 42: {
            hNMDFNBPFNI_.AddEntriesFrom(ref input, _repeated_hNMDFNBPFNI_codec);
            break;
          }
          case 48: {
            CHOCIPBOPMB = input.ReadUInt32();
            break;
          }
          case 114: {
            if (fKCODPKOGGB_ == null) {
              FKCODPKOGGB = new global::EggLink.DanhengServer.Proto.HAIIKGDHFMO();
            }
            input.ReadMessage(FKCODPKOGGB);
            break;
          }
          case 122: {
            if (iIHFACJDHBP_ == null) {
              IIHFACJDHBP = new global::EggLink.DanhengServer.Proto.HAIIKGDHFMO();
            }
            input.ReadMessage(IIHFACJDHBP);
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
