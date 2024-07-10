// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: RogueSyncContextBoardEvent.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from RogueSyncContextBoardEvent.proto</summary>
  public static partial class RogueSyncContextBoardEventReflection {

    #region Descriptor
    /// <summary>File descriptor for RogueSyncContextBoardEvent.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static RogueSyncContextBoardEventReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiBSb2d1ZVN5bmNDb250ZXh0Qm9hcmRFdmVudC5wcm90byJkChpSb2d1ZVN5",
            "bmNDb250ZXh0Qm9hcmRFdmVudBIfChdCb2FyZEV2ZW50SWRGaWVsZE51bWJl",
            "chgEIAEoDRIlCh1Nb2RpZmllckVmZmVjdFR5cGVGaWVsZE51bWJlchgGIAEo",
            "DUIeqgIbRWdnTGluay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.RogueSyncContextBoardEvent), global::EggLink.DanhengServer.Proto.RogueSyncContextBoardEvent.Parser, new[]{ "BoardEventIdFieldNumber", "ModifierEffectTypeFieldNumber" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class RogueSyncContextBoardEvent : pb::IMessage<RogueSyncContextBoardEvent>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<RogueSyncContextBoardEvent> _parser = new pb::MessageParser<RogueSyncContextBoardEvent>(() => new RogueSyncContextBoardEvent());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<RogueSyncContextBoardEvent> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.RogueSyncContextBoardEventReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RogueSyncContextBoardEvent() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RogueSyncContextBoardEvent(RogueSyncContextBoardEvent other) : this() {
      boardEventIdFieldNumber_ = other.boardEventIdFieldNumber_;
      modifierEffectTypeFieldNumber_ = other.modifierEffectTypeFieldNumber_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RogueSyncContextBoardEvent Clone() {
      return new RogueSyncContextBoardEvent(this);
    }

    /// <summary>Field number for the "BoardEventIdFieldNumber" field.</summary>
    public const int BoardEventIdFieldNumberFieldNumber = 4;
    private uint boardEventIdFieldNumber_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint BoardEventIdFieldNumber {
      get { return boardEventIdFieldNumber_; }
      set {
        boardEventIdFieldNumber_ = value;
      }
    }

    /// <summary>Field number for the "ModifierEffectTypeFieldNumber" field.</summary>
    public const int ModifierEffectTypeFieldNumberFieldNumber = 6;
    private uint modifierEffectTypeFieldNumber_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ModifierEffectTypeFieldNumber {
      get { return modifierEffectTypeFieldNumber_; }
      set {
        modifierEffectTypeFieldNumber_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as RogueSyncContextBoardEvent);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(RogueSyncContextBoardEvent other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (BoardEventIdFieldNumber != other.BoardEventIdFieldNumber) return false;
      if (ModifierEffectTypeFieldNumber != other.ModifierEffectTypeFieldNumber) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (BoardEventIdFieldNumber != 0) hash ^= BoardEventIdFieldNumber.GetHashCode();
      if (ModifierEffectTypeFieldNumber != 0) hash ^= ModifierEffectTypeFieldNumber.GetHashCode();
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
      if (BoardEventIdFieldNumber != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(BoardEventIdFieldNumber);
      }
      if (ModifierEffectTypeFieldNumber != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(ModifierEffectTypeFieldNumber);
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
      if (BoardEventIdFieldNumber != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(BoardEventIdFieldNumber);
      }
      if (ModifierEffectTypeFieldNumber != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(ModifierEffectTypeFieldNumber);
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
      if (BoardEventIdFieldNumber != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(BoardEventIdFieldNumber);
      }
      if (ModifierEffectTypeFieldNumber != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ModifierEffectTypeFieldNumber);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(RogueSyncContextBoardEvent other) {
      if (other == null) {
        return;
      }
      if (other.BoardEventIdFieldNumber != 0) {
        BoardEventIdFieldNumber = other.BoardEventIdFieldNumber;
      }
      if (other.ModifierEffectTypeFieldNumber != 0) {
        ModifierEffectTypeFieldNumber = other.ModifierEffectTypeFieldNumber;
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
          case 32: {
            BoardEventIdFieldNumber = input.ReadUInt32();
            break;
          }
          case 48: {
            ModifierEffectTypeFieldNumber = input.ReadUInt32();
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
          case 32: {
            BoardEventIdFieldNumber = input.ReadUInt32();
            break;
          }
          case 48: {
            ModifierEffectTypeFieldNumber = input.ReadUInt32();
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
