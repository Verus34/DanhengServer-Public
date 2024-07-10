// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: RogueMiracleSelectInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from RogueMiracleSelectInfo.proto</summary>
  public static partial class RogueMiracleSelectInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for RogueMiracleSelectInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static RogueMiracleSelectInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChxSb2d1ZU1pcmFjbGVTZWxlY3RJbmZvLnByb3RvImkKFlJvZ3VlTWlyYWNs",
            "ZVNlbGVjdEluZm8SEwoLS0FBTEtFTU1GSkEYBCABKA0SGwoTc2VsZWN0X21p",
            "cmFjbGVfbGlzdBgPIAMoDRIdChVtaXJhY2xlX2hhbmRib29rX2xpc3QYASAD",
            "KA1CHqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.RogueMiracleSelectInfo), global::EggLink.DanhengServer.Proto.RogueMiracleSelectInfo.Parser, new[]{ "KAALKEMMFJA", "SelectMiracleList", "MiracleHandbookList" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class RogueMiracleSelectInfo : pb::IMessage<RogueMiracleSelectInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<RogueMiracleSelectInfo> _parser = new pb::MessageParser<RogueMiracleSelectInfo>(() => new RogueMiracleSelectInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<RogueMiracleSelectInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.RogueMiracleSelectInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RogueMiracleSelectInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RogueMiracleSelectInfo(RogueMiracleSelectInfo other) : this() {
      kAALKEMMFJA_ = other.kAALKEMMFJA_;
      selectMiracleList_ = other.selectMiracleList_.Clone();
      miracleHandbookList_ = other.miracleHandbookList_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RogueMiracleSelectInfo Clone() {
      return new RogueMiracleSelectInfo(this);
    }

    /// <summary>Field number for the "KAALKEMMFJA" field.</summary>
    public const int KAALKEMMFJAFieldNumber = 4;
    private uint kAALKEMMFJA_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint KAALKEMMFJA {
      get { return kAALKEMMFJA_; }
      set {
        kAALKEMMFJA_ = value;
      }
    }

    /// <summary>Field number for the "select_miracle_list" field.</summary>
    public const int SelectMiracleListFieldNumber = 15;
    private static readonly pb::FieldCodec<uint> _repeated_selectMiracleList_codec
        = pb::FieldCodec.ForUInt32(122);
    private readonly pbc::RepeatedField<uint> selectMiracleList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> SelectMiracleList {
      get { return selectMiracleList_; }
    }

    /// <summary>Field number for the "miracle_handbook_list" field.</summary>
    public const int MiracleHandbookListFieldNumber = 1;
    private static readonly pb::FieldCodec<uint> _repeated_miracleHandbookList_codec
        = pb::FieldCodec.ForUInt32(10);
    private readonly pbc::RepeatedField<uint> miracleHandbookList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> MiracleHandbookList {
      get { return miracleHandbookList_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as RogueMiracleSelectInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(RogueMiracleSelectInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (KAALKEMMFJA != other.KAALKEMMFJA) return false;
      if(!selectMiracleList_.Equals(other.selectMiracleList_)) return false;
      if(!miracleHandbookList_.Equals(other.miracleHandbookList_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (KAALKEMMFJA != 0) hash ^= KAALKEMMFJA.GetHashCode();
      hash ^= selectMiracleList_.GetHashCode();
      hash ^= miracleHandbookList_.GetHashCode();
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
      miracleHandbookList_.WriteTo(output, _repeated_miracleHandbookList_codec);
      if (KAALKEMMFJA != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(KAALKEMMFJA);
      }
      selectMiracleList_.WriteTo(output, _repeated_selectMiracleList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      miracleHandbookList_.WriteTo(ref output, _repeated_miracleHandbookList_codec);
      if (KAALKEMMFJA != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(KAALKEMMFJA);
      }
      selectMiracleList_.WriteTo(ref output, _repeated_selectMiracleList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (KAALKEMMFJA != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(KAALKEMMFJA);
      }
      size += selectMiracleList_.CalculateSize(_repeated_selectMiracleList_codec);
      size += miracleHandbookList_.CalculateSize(_repeated_miracleHandbookList_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(RogueMiracleSelectInfo other) {
      if (other == null) {
        return;
      }
      if (other.KAALKEMMFJA != 0) {
        KAALKEMMFJA = other.KAALKEMMFJA;
      }
      selectMiracleList_.Add(other.selectMiracleList_);
      miracleHandbookList_.Add(other.miracleHandbookList_);
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
          case 10:
          case 8: {
            miracleHandbookList_.AddEntriesFrom(input, _repeated_miracleHandbookList_codec);
            break;
          }
          case 32: {
            KAALKEMMFJA = input.ReadUInt32();
            break;
          }
          case 122:
          case 120: {
            selectMiracleList_.AddEntriesFrom(input, _repeated_selectMiracleList_codec);
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
          case 10:
          case 8: {
            miracleHandbookList_.AddEntriesFrom(ref input, _repeated_miracleHandbookList_codec);
            break;
          }
          case 32: {
            KAALKEMMFJA = input.ReadUInt32();
            break;
          }
          case 122:
          case 120: {
            selectMiracleList_.AddEntriesFrom(ref input, _repeated_selectMiracleList_codec);
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
