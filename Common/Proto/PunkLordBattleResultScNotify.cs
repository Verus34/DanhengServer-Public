// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: PunkLordBattleResultScNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from PunkLordBattleResultScNotify.proto</summary>
  public static partial class PunkLordBattleResultScNotifyReflection {

    #region Descriptor
    /// <summary>File descriptor for PunkLordBattleResultScNotify.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static PunkLordBattleResultScNotifyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiJQdW5rTG9yZEJhdHRsZVJlc3VsdFNjTm90aWZ5LnByb3RvGhFJSUpBQUpD",
            "Sk5KSS5wcm90bxoaUHVua0xvcmRCYXR0bGVSZWNvcmQucHJvdG8irAEKHFB1",
            "bmtMb3JkQmF0dGxlUmVzdWx0U2NOb3RpZnkSIQoLQ0RFSEhJSUNQTkwYAiAB",
            "KAsyDC5JSUpBQUpDSk5KSRIqCgtBSUdESElKT0dLRxgPIAEoCzIVLlB1bmtM",
            "b3JkQmF0dGxlUmVjb3JkEhMKC0VJTlBPT09DRkpEGA4gASgNEhMKC0RFQkpJ",
            "TkRDSUJCGAwgASgNEhMKC0hIQUFDUE5NQU9MGAEgASgNQh6qAhtFZ2dMaW5r",
            "LkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.IIJAAJCJNJIReflection.Descriptor, global::EggLink.DanhengServer.Proto.PunkLordBattleRecordReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.PunkLordBattleResultScNotify), global::EggLink.DanhengServer.Proto.PunkLordBattleResultScNotify.Parser, new[]{ "CDEHHIICPNL", "AIGDHIJOGKG", "EINPOOOCFJD", "DEBJINDCIBB", "HHAACPNMAOL" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class PunkLordBattleResultScNotify : pb::IMessage<PunkLordBattleResultScNotify>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<PunkLordBattleResultScNotify> _parser = new pb::MessageParser<PunkLordBattleResultScNotify>(() => new PunkLordBattleResultScNotify());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<PunkLordBattleResultScNotify> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.PunkLordBattleResultScNotifyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PunkLordBattleResultScNotify() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PunkLordBattleResultScNotify(PunkLordBattleResultScNotify other) : this() {
      cDEHHIICPNL_ = other.cDEHHIICPNL_ != null ? other.cDEHHIICPNL_.Clone() : null;
      aIGDHIJOGKG_ = other.aIGDHIJOGKG_ != null ? other.aIGDHIJOGKG_.Clone() : null;
      eINPOOOCFJD_ = other.eINPOOOCFJD_;
      dEBJINDCIBB_ = other.dEBJINDCIBB_;
      hHAACPNMAOL_ = other.hHAACPNMAOL_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PunkLordBattleResultScNotify Clone() {
      return new PunkLordBattleResultScNotify(this);
    }

    /// <summary>Field number for the "CDEHHIICPNL" field.</summary>
    public const int CDEHHIICPNLFieldNumber = 2;
    private global::EggLink.DanhengServer.Proto.IIJAAJCJNJI cDEHHIICPNL_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.IIJAAJCJNJI CDEHHIICPNL {
      get { return cDEHHIICPNL_; }
      set {
        cDEHHIICPNL_ = value;
      }
    }

    /// <summary>Field number for the "AIGDHIJOGKG" field.</summary>
    public const int AIGDHIJOGKGFieldNumber = 15;
    private global::EggLink.DanhengServer.Proto.PunkLordBattleRecord aIGDHIJOGKG_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.PunkLordBattleRecord AIGDHIJOGKG {
      get { return aIGDHIJOGKG_; }
      set {
        aIGDHIJOGKG_ = value;
      }
    }

    /// <summary>Field number for the "EINPOOOCFJD" field.</summary>
    public const int EINPOOOCFJDFieldNumber = 14;
    private uint eINPOOOCFJD_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint EINPOOOCFJD {
      get { return eINPOOOCFJD_; }
      set {
        eINPOOOCFJD_ = value;
      }
    }

    /// <summary>Field number for the "DEBJINDCIBB" field.</summary>
    public const int DEBJINDCIBBFieldNumber = 12;
    private uint dEBJINDCIBB_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint DEBJINDCIBB {
      get { return dEBJINDCIBB_; }
      set {
        dEBJINDCIBB_ = value;
      }
    }

    /// <summary>Field number for the "HHAACPNMAOL" field.</summary>
    public const int HHAACPNMAOLFieldNumber = 1;
    private uint hHAACPNMAOL_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint HHAACPNMAOL {
      get { return hHAACPNMAOL_; }
      set {
        hHAACPNMAOL_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as PunkLordBattleResultScNotify);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(PunkLordBattleResultScNotify other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(CDEHHIICPNL, other.CDEHHIICPNL)) return false;
      if (!object.Equals(AIGDHIJOGKG, other.AIGDHIJOGKG)) return false;
      if (EINPOOOCFJD != other.EINPOOOCFJD) return false;
      if (DEBJINDCIBB != other.DEBJINDCIBB) return false;
      if (HHAACPNMAOL != other.HHAACPNMAOL) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (cDEHHIICPNL_ != null) hash ^= CDEHHIICPNL.GetHashCode();
      if (aIGDHIJOGKG_ != null) hash ^= AIGDHIJOGKG.GetHashCode();
      if (EINPOOOCFJD != 0) hash ^= EINPOOOCFJD.GetHashCode();
      if (DEBJINDCIBB != 0) hash ^= DEBJINDCIBB.GetHashCode();
      if (HHAACPNMAOL != 0) hash ^= HHAACPNMAOL.GetHashCode();
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
      if (HHAACPNMAOL != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(HHAACPNMAOL);
      }
      if (cDEHHIICPNL_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(CDEHHIICPNL);
      }
      if (DEBJINDCIBB != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(DEBJINDCIBB);
      }
      if (EINPOOOCFJD != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(EINPOOOCFJD);
      }
      if (aIGDHIJOGKG_ != null) {
        output.WriteRawTag(122);
        output.WriteMessage(AIGDHIJOGKG);
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
      if (HHAACPNMAOL != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(HHAACPNMAOL);
      }
      if (cDEHHIICPNL_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(CDEHHIICPNL);
      }
      if (DEBJINDCIBB != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(DEBJINDCIBB);
      }
      if (EINPOOOCFJD != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(EINPOOOCFJD);
      }
      if (aIGDHIJOGKG_ != null) {
        output.WriteRawTag(122);
        output.WriteMessage(AIGDHIJOGKG);
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
      if (cDEHHIICPNL_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(CDEHHIICPNL);
      }
      if (aIGDHIJOGKG_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(AIGDHIJOGKG);
      }
      if (EINPOOOCFJD != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(EINPOOOCFJD);
      }
      if (DEBJINDCIBB != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(DEBJINDCIBB);
      }
      if (HHAACPNMAOL != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(HHAACPNMAOL);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(PunkLordBattleResultScNotify other) {
      if (other == null) {
        return;
      }
      if (other.cDEHHIICPNL_ != null) {
        if (cDEHHIICPNL_ == null) {
          CDEHHIICPNL = new global::EggLink.DanhengServer.Proto.IIJAAJCJNJI();
        }
        CDEHHIICPNL.MergeFrom(other.CDEHHIICPNL);
      }
      if (other.aIGDHIJOGKG_ != null) {
        if (aIGDHIJOGKG_ == null) {
          AIGDHIJOGKG = new global::EggLink.DanhengServer.Proto.PunkLordBattleRecord();
        }
        AIGDHIJOGKG.MergeFrom(other.AIGDHIJOGKG);
      }
      if (other.EINPOOOCFJD != 0) {
        EINPOOOCFJD = other.EINPOOOCFJD;
      }
      if (other.DEBJINDCIBB != 0) {
        DEBJINDCIBB = other.DEBJINDCIBB;
      }
      if (other.HHAACPNMAOL != 0) {
        HHAACPNMAOL = other.HHAACPNMAOL;
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
          case 8: {
            HHAACPNMAOL = input.ReadUInt32();
            break;
          }
          case 18: {
            if (cDEHHIICPNL_ == null) {
              CDEHHIICPNL = new global::EggLink.DanhengServer.Proto.IIJAAJCJNJI();
            }
            input.ReadMessage(CDEHHIICPNL);
            break;
          }
          case 96: {
            DEBJINDCIBB = input.ReadUInt32();
            break;
          }
          case 112: {
            EINPOOOCFJD = input.ReadUInt32();
            break;
          }
          case 122: {
            if (aIGDHIJOGKG_ == null) {
              AIGDHIJOGKG = new global::EggLink.DanhengServer.Proto.PunkLordBattleRecord();
            }
            input.ReadMessage(AIGDHIJOGKG);
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
          case 8: {
            HHAACPNMAOL = input.ReadUInt32();
            break;
          }
          case 18: {
            if (cDEHHIICPNL_ == null) {
              CDEHHIICPNL = new global::EggLink.DanhengServer.Proto.IIJAAJCJNJI();
            }
            input.ReadMessage(CDEHHIICPNL);
            break;
          }
          case 96: {
            DEBJINDCIBB = input.ReadUInt32();
            break;
          }
          case 112: {
            EINPOOOCFJD = input.ReadUInt32();
            break;
          }
          case 122: {
            if (aIGDHIJOGKG_ == null) {
              AIGDHIJOGKG = new global::EggLink.DanhengServer.Proto.PunkLordBattleRecord();
            }
            input.ReadMessage(AIGDHIJOGKG);
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
