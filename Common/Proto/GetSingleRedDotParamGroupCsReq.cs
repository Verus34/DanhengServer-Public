// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: GetSingleRedDotParamGroupCsReq.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from GetSingleRedDotParamGroupCsReq.proto</summary>
  public static partial class GetSingleRedDotParamGroupCsReqReflection {

    #region Descriptor
    /// <summary>File descriptor for GetSingleRedDotParamGroupCsReq.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GetSingleRedDotParamGroupCsReqReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiRHZXRTaW5nbGVSZWREb3RQYXJhbUdyb3VwQ3NSZXEucHJvdG8iWQoeR2V0",
            "U2luZ2xlUmVkRG90UGFyYW1Hcm91cENzUmVxEhMKC09HRUdEQUJNRE1QGAMg",
            "ASgNEhAKCGdyb3VwX2lkGAEgASgNEhAKCHBhbmVsX2lkGAwgASgNQh6qAhtF",
            "Z2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.GetSingleRedDotParamGroupCsReq), global::EggLink.DanhengServer.Proto.GetSingleRedDotParamGroupCsReq.Parser, new[]{ "OGEGDABMDMP", "GroupId", "PanelId" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class GetSingleRedDotParamGroupCsReq : pb::IMessage<GetSingleRedDotParamGroupCsReq>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<GetSingleRedDotParamGroupCsReq> _parser = new pb::MessageParser<GetSingleRedDotParamGroupCsReq>(() => new GetSingleRedDotParamGroupCsReq());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<GetSingleRedDotParamGroupCsReq> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.GetSingleRedDotParamGroupCsReqReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetSingleRedDotParamGroupCsReq() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetSingleRedDotParamGroupCsReq(GetSingleRedDotParamGroupCsReq other) : this() {
      oGEGDABMDMP_ = other.oGEGDABMDMP_;
      groupId_ = other.groupId_;
      panelId_ = other.panelId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetSingleRedDotParamGroupCsReq Clone() {
      return new GetSingleRedDotParamGroupCsReq(this);
    }

    /// <summary>Field number for the "OGEGDABMDMP" field.</summary>
    public const int OGEGDABMDMPFieldNumber = 3;
    private uint oGEGDABMDMP_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint OGEGDABMDMP {
      get { return oGEGDABMDMP_; }
      set {
        oGEGDABMDMP_ = value;
      }
    }

    /// <summary>Field number for the "group_id" field.</summary>
    public const int GroupIdFieldNumber = 1;
    private uint groupId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint GroupId {
      get { return groupId_; }
      set {
        groupId_ = value;
      }
    }

    /// <summary>Field number for the "panel_id" field.</summary>
    public const int PanelIdFieldNumber = 12;
    private uint panelId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint PanelId {
      get { return panelId_; }
      set {
        panelId_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as GetSingleRedDotParamGroupCsReq);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(GetSingleRedDotParamGroupCsReq other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (OGEGDABMDMP != other.OGEGDABMDMP) return false;
      if (GroupId != other.GroupId) return false;
      if (PanelId != other.PanelId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (OGEGDABMDMP != 0) hash ^= OGEGDABMDMP.GetHashCode();
      if (GroupId != 0) hash ^= GroupId.GetHashCode();
      if (PanelId != 0) hash ^= PanelId.GetHashCode();
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
      if (GroupId != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(GroupId);
      }
      if (OGEGDABMDMP != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(OGEGDABMDMP);
      }
      if (PanelId != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(PanelId);
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
      if (GroupId != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(GroupId);
      }
      if (OGEGDABMDMP != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(OGEGDABMDMP);
      }
      if (PanelId != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(PanelId);
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
      if (OGEGDABMDMP != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(OGEGDABMDMP);
      }
      if (GroupId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(GroupId);
      }
      if (PanelId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(PanelId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(GetSingleRedDotParamGroupCsReq other) {
      if (other == null) {
        return;
      }
      if (other.OGEGDABMDMP != 0) {
        OGEGDABMDMP = other.OGEGDABMDMP;
      }
      if (other.GroupId != 0) {
        GroupId = other.GroupId;
      }
      if (other.PanelId != 0) {
        PanelId = other.PanelId;
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
            GroupId = input.ReadUInt32();
            break;
          }
          case 24: {
            OGEGDABMDMP = input.ReadUInt32();
            break;
          }
          case 96: {
            PanelId = input.ReadUInt32();
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
            GroupId = input.ReadUInt32();
            break;
          }
          case 24: {
            OGEGDABMDMP = input.ReadUInt32();
            break;
          }
          case 96: {
            PanelId = input.ReadUInt32();
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
