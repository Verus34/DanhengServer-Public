// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: ComposeSelectedRelicCsReq.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from ComposeSelectedRelicCsReq.proto</summary>
  public static partial class ComposeSelectedRelicCsReqReflection {

    #region Descriptor
    /// <summary>File descriptor for ComposeSelectedRelicCsReq.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ComposeSelectedRelicCsReqReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch9Db21wb3NlU2VsZWN0ZWRSZWxpY0NzUmVxLnByb3RvGhJJdGVtQ29zdERh",
            "dGEucHJvdG8ilwEKGUNvbXBvc2VTZWxlY3RlZFJlbGljQ3NSZXESEgoKY29t",
            "cG9zZV9pZBgPIAEoDRIoChFjb21wb3NlX2l0ZW1fbGlzdBgBIAEoCzINLkl0",
            "ZW1Db3N0RGF0YRIVCg1tYWluX2FmZml4X2lkGAQgASgNEg0KBWNvdW50GAgg",
            "ASgNEhYKDmNvbXBvc2Vfc2V0X2lkGAsgASgNQh6qAhtFZ2dMaW5rLkRhbmhl",
            "bmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.ItemCostDataReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.ComposeSelectedRelicCsReq), global::EggLink.DanhengServer.Proto.ComposeSelectedRelicCsReq.Parser, new[]{ "ComposeId", "ComposeItemList", "MainAffixId", "Count", "ComposeSetId" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class ComposeSelectedRelicCsReq : pb::IMessage<ComposeSelectedRelicCsReq>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ComposeSelectedRelicCsReq> _parser = new pb::MessageParser<ComposeSelectedRelicCsReq>(() => new ComposeSelectedRelicCsReq());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ComposeSelectedRelicCsReq> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.ComposeSelectedRelicCsReqReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ComposeSelectedRelicCsReq() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ComposeSelectedRelicCsReq(ComposeSelectedRelicCsReq other) : this() {
      composeId_ = other.composeId_;
      composeItemList_ = other.composeItemList_ != null ? other.composeItemList_.Clone() : null;
      mainAffixId_ = other.mainAffixId_;
      count_ = other.count_;
      composeSetId_ = other.composeSetId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ComposeSelectedRelicCsReq Clone() {
      return new ComposeSelectedRelicCsReq(this);
    }

    /// <summary>Field number for the "compose_id" field.</summary>
    public const int ComposeIdFieldNumber = 15;
    private uint composeId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ComposeId {
      get { return composeId_; }
      set {
        composeId_ = value;
      }
    }

    /// <summary>Field number for the "compose_item_list" field.</summary>
    public const int ComposeItemListFieldNumber = 1;
    private global::EggLink.DanhengServer.Proto.ItemCostData composeItemList_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.ItemCostData ComposeItemList {
      get { return composeItemList_; }
      set {
        composeItemList_ = value;
      }
    }

    /// <summary>Field number for the "main_affix_id" field.</summary>
    public const int MainAffixIdFieldNumber = 4;
    private uint mainAffixId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint MainAffixId {
      get { return mainAffixId_; }
      set {
        mainAffixId_ = value;
      }
    }

    /// <summary>Field number for the "count" field.</summary>
    public const int CountFieldNumber = 8;
    private uint count_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Count {
      get { return count_; }
      set {
        count_ = value;
      }
    }

    /// <summary>Field number for the "compose_set_id" field.</summary>
    public const int ComposeSetIdFieldNumber = 11;
    private uint composeSetId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ComposeSetId {
      get { return composeSetId_; }
      set {
        composeSetId_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ComposeSelectedRelicCsReq);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ComposeSelectedRelicCsReq other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ComposeId != other.ComposeId) return false;
      if (!object.Equals(ComposeItemList, other.ComposeItemList)) return false;
      if (MainAffixId != other.MainAffixId) return false;
      if (Count != other.Count) return false;
      if (ComposeSetId != other.ComposeSetId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (ComposeId != 0) hash ^= ComposeId.GetHashCode();
      if (composeItemList_ != null) hash ^= ComposeItemList.GetHashCode();
      if (MainAffixId != 0) hash ^= MainAffixId.GetHashCode();
      if (Count != 0) hash ^= Count.GetHashCode();
      if (ComposeSetId != 0) hash ^= ComposeSetId.GetHashCode();
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
      if (composeItemList_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(ComposeItemList);
      }
      if (MainAffixId != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(MainAffixId);
      }
      if (Count != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(Count);
      }
      if (ComposeSetId != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(ComposeSetId);
      }
      if (ComposeId != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(ComposeId);
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
      if (composeItemList_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(ComposeItemList);
      }
      if (MainAffixId != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(MainAffixId);
      }
      if (Count != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(Count);
      }
      if (ComposeSetId != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(ComposeSetId);
      }
      if (ComposeId != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(ComposeId);
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
      if (ComposeId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ComposeId);
      }
      if (composeItemList_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(ComposeItemList);
      }
      if (MainAffixId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(MainAffixId);
      }
      if (Count != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Count);
      }
      if (ComposeSetId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ComposeSetId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(ComposeSelectedRelicCsReq other) {
      if (other == null) {
        return;
      }
      if (other.ComposeId != 0) {
        ComposeId = other.ComposeId;
      }
      if (other.composeItemList_ != null) {
        if (composeItemList_ == null) {
          ComposeItemList = new global::EggLink.DanhengServer.Proto.ItemCostData();
        }
        ComposeItemList.MergeFrom(other.ComposeItemList);
      }
      if (other.MainAffixId != 0) {
        MainAffixId = other.MainAffixId;
      }
      if (other.Count != 0) {
        Count = other.Count;
      }
      if (other.ComposeSetId != 0) {
        ComposeSetId = other.ComposeSetId;
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
            if (composeItemList_ == null) {
              ComposeItemList = new global::EggLink.DanhengServer.Proto.ItemCostData();
            }
            input.ReadMessage(ComposeItemList);
            break;
          }
          case 32: {
            MainAffixId = input.ReadUInt32();
            break;
          }
          case 64: {
            Count = input.ReadUInt32();
            break;
          }
          case 88: {
            ComposeSetId = input.ReadUInt32();
            break;
          }
          case 120: {
            ComposeId = input.ReadUInt32();
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
            if (composeItemList_ == null) {
              ComposeItemList = new global::EggLink.DanhengServer.Proto.ItemCostData();
            }
            input.ReadMessage(ComposeItemList);
            break;
          }
          case 32: {
            MainAffixId = input.ReadUInt32();
            break;
          }
          case 64: {
            Count = input.ReadUInt32();
            break;
          }
          case 88: {
            ComposeSetId = input.ReadUInt32();
            break;
          }
          case 120: {
            ComposeId = input.ReadUInt32();
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
