// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: RogueTournFormulaInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from RogueTournFormulaInfo.proto</summary>
  public static partial class RogueTournFormulaInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for RogueTournFormulaInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static RogueTournFormulaInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChtSb2d1ZVRvdXJuRm9ybXVsYUluZm8ucHJvdG8aFUZvcm11bGFUeXBlSW5m",
            "by5wcm90bxoRRm9ybXVsYUluZm8ucHJvdG8ibQoVUm9ndWVUb3VybkZvcm11",
            "bGFJbmZvEicKEWdhbWVfZm9ybXVsYV9pbmZvGAsgAygLMgwuRm9ybXVsYUlu",
            "Zm8SKwoRZm9ybXVsYV90eXBlX2luZm8YDCABKAsyEC5Gb3JtdWxhVHlwZUlu",
            "Zm9CHqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.FormulaTypeInfoReflection.Descriptor, global::EggLink.DanhengServer.Proto.FormulaInfoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.RogueTournFormulaInfo), global::EggLink.DanhengServer.Proto.RogueTournFormulaInfo.Parser, new[]{ "GameFormulaInfo", "FormulaTypeInfo" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class RogueTournFormulaInfo : pb::IMessage<RogueTournFormulaInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<RogueTournFormulaInfo> _parser = new pb::MessageParser<RogueTournFormulaInfo>(() => new RogueTournFormulaInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<RogueTournFormulaInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.RogueTournFormulaInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RogueTournFormulaInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RogueTournFormulaInfo(RogueTournFormulaInfo other) : this() {
      gameFormulaInfo_ = other.gameFormulaInfo_.Clone();
      formulaTypeInfo_ = other.formulaTypeInfo_ != null ? other.formulaTypeInfo_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RogueTournFormulaInfo Clone() {
      return new RogueTournFormulaInfo(this);
    }

    /// <summary>Field number for the "game_formula_info" field.</summary>
    public const int GameFormulaInfoFieldNumber = 11;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.FormulaInfo> _repeated_gameFormulaInfo_codec
        = pb::FieldCodec.ForMessage(90, global::EggLink.DanhengServer.Proto.FormulaInfo.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.FormulaInfo> gameFormulaInfo_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.FormulaInfo>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.FormulaInfo> GameFormulaInfo {
      get { return gameFormulaInfo_; }
    }

    /// <summary>Field number for the "formula_type_info" field.</summary>
    public const int FormulaTypeInfoFieldNumber = 12;
    private global::EggLink.DanhengServer.Proto.FormulaTypeInfo formulaTypeInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.FormulaTypeInfo FormulaTypeInfo {
      get { return formulaTypeInfo_; }
      set {
        formulaTypeInfo_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as RogueTournFormulaInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(RogueTournFormulaInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!gameFormulaInfo_.Equals(other.gameFormulaInfo_)) return false;
      if (!object.Equals(FormulaTypeInfo, other.FormulaTypeInfo)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= gameFormulaInfo_.GetHashCode();
      if (formulaTypeInfo_ != null) hash ^= FormulaTypeInfo.GetHashCode();
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
      gameFormulaInfo_.WriteTo(output, _repeated_gameFormulaInfo_codec);
      if (formulaTypeInfo_ != null) {
        output.WriteRawTag(98);
        output.WriteMessage(FormulaTypeInfo);
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
      gameFormulaInfo_.WriteTo(ref output, _repeated_gameFormulaInfo_codec);
      if (formulaTypeInfo_ != null) {
        output.WriteRawTag(98);
        output.WriteMessage(FormulaTypeInfo);
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
      size += gameFormulaInfo_.CalculateSize(_repeated_gameFormulaInfo_codec);
      if (formulaTypeInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(FormulaTypeInfo);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(RogueTournFormulaInfo other) {
      if (other == null) {
        return;
      }
      gameFormulaInfo_.Add(other.gameFormulaInfo_);
      if (other.formulaTypeInfo_ != null) {
        if (formulaTypeInfo_ == null) {
          FormulaTypeInfo = new global::EggLink.DanhengServer.Proto.FormulaTypeInfo();
        }
        FormulaTypeInfo.MergeFrom(other.FormulaTypeInfo);
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
          case 90: {
            gameFormulaInfo_.AddEntriesFrom(input, _repeated_gameFormulaInfo_codec);
            break;
          }
          case 98: {
            if (formulaTypeInfo_ == null) {
              FormulaTypeInfo = new global::EggLink.DanhengServer.Proto.FormulaTypeInfo();
            }
            input.ReadMessage(FormulaTypeInfo);
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
          case 90: {
            gameFormulaInfo_.AddEntriesFrom(ref input, _repeated_gameFormulaInfo_codec);
            break;
          }
          case 98: {
            if (formulaTypeInfo_ == null) {
              FormulaTypeInfo = new global::EggLink.DanhengServer.Proto.FormulaTypeInfo();
            }
            input.ReadMessage(FormulaTypeInfo);
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
