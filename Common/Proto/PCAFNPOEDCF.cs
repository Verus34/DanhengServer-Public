// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: PCAFNPOEDCF.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from PCAFNPOEDCF.proto</summary>
  public static partial class PCAFNPOEDCFReflection {

    #region Descriptor
    /// <summary>File descriptor for PCAFNPOEDCF.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static PCAFNPOEDCFReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChFQQ0FGTlBPRURDRi5wcm90byI3CgtQQ0FGTlBPRURDRhITCgtNT0xDREVL",
            "RUhBRhgIIAMoDRITCgtLQUFMS0VNTUZKQRgCIAEoDUIeqgIbRWdnTGluay5E",
            "YW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.PCAFNPOEDCF), global::EggLink.DanhengServer.Proto.PCAFNPOEDCF.Parser, new[]{ "MOLCDEKEHAF", "KAALKEMMFJA" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class PCAFNPOEDCF : pb::IMessage<PCAFNPOEDCF>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<PCAFNPOEDCF> _parser = new pb::MessageParser<PCAFNPOEDCF>(() => new PCAFNPOEDCF());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<PCAFNPOEDCF> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.PCAFNPOEDCFReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PCAFNPOEDCF() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PCAFNPOEDCF(PCAFNPOEDCF other) : this() {
      mOLCDEKEHAF_ = other.mOLCDEKEHAF_.Clone();
      kAALKEMMFJA_ = other.kAALKEMMFJA_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PCAFNPOEDCF Clone() {
      return new PCAFNPOEDCF(this);
    }

    /// <summary>Field number for the "MOLCDEKEHAF" field.</summary>
    public const int MOLCDEKEHAFFieldNumber = 8;
    private static readonly pb::FieldCodec<uint> _repeated_mOLCDEKEHAF_codec
        = pb::FieldCodec.ForUInt32(66);
    private readonly pbc::RepeatedField<uint> mOLCDEKEHAF_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> MOLCDEKEHAF {
      get { return mOLCDEKEHAF_; }
    }

    /// <summary>Field number for the "KAALKEMMFJA" field.</summary>
    public const int KAALKEMMFJAFieldNumber = 2;
    private uint kAALKEMMFJA_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint KAALKEMMFJA {
      get { return kAALKEMMFJA_; }
      set {
        kAALKEMMFJA_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as PCAFNPOEDCF);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(PCAFNPOEDCF other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!mOLCDEKEHAF_.Equals(other.mOLCDEKEHAF_)) return false;
      if (KAALKEMMFJA != other.KAALKEMMFJA) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= mOLCDEKEHAF_.GetHashCode();
      if (KAALKEMMFJA != 0) hash ^= KAALKEMMFJA.GetHashCode();
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
      if (KAALKEMMFJA != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(KAALKEMMFJA);
      }
      mOLCDEKEHAF_.WriteTo(output, _repeated_mOLCDEKEHAF_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (KAALKEMMFJA != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(KAALKEMMFJA);
      }
      mOLCDEKEHAF_.WriteTo(ref output, _repeated_mOLCDEKEHAF_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      size += mOLCDEKEHAF_.CalculateSize(_repeated_mOLCDEKEHAF_codec);
      if (KAALKEMMFJA != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(KAALKEMMFJA);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(PCAFNPOEDCF other) {
      if (other == null) {
        return;
      }
      mOLCDEKEHAF_.Add(other.mOLCDEKEHAF_);
      if (other.KAALKEMMFJA != 0) {
        KAALKEMMFJA = other.KAALKEMMFJA;
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
          case 16: {
            KAALKEMMFJA = input.ReadUInt32();
            break;
          }
          case 66:
          case 64: {
            mOLCDEKEHAF_.AddEntriesFrom(input, _repeated_mOLCDEKEHAF_codec);
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
          case 16: {
            KAALKEMMFJA = input.ReadUInt32();
            break;
          }
          case 66:
          case 64: {
            mOLCDEKEHAF_.AddEntriesFrom(ref input, _repeated_mOLCDEKEHAF_codec);
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
