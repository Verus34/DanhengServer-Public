// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: GetSingleRedDotParamGroupScRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from GetSingleRedDotParamGroupScRsp.proto</summary>
  public static partial class GetSingleRedDotParamGroupScRspReflection {

    #region Descriptor
    /// <summary>File descriptor for GetSingleRedDotParamGroupScRsp.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GetSingleRedDotParamGroupScRspReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiRHZXRTaW5nbGVSZWREb3RQYXJhbUdyb3VwU2NSc3AucHJvdG8aEUtPSk9D",
            "R0ZMQkhBLnByb3RvIo0BCh5HZXRTaW5nbGVSZWREb3RQYXJhbUdyb3VwU2NS",
            "c3ASIQoLQUxJUEJIQUlERU0YCSABKAsyDC5LT0pPQ0dGTEJIQRIQCghncm91",
            "cF9pZBgEIAEoDRITCgtPR0VHREFCTURNUBgGIAEoDRIPCgdyZXRjb2RlGAIg",
            "ASgNEhAKCHBhbmVsX2lkGAggASgNQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2",
            "ZXIuUHJvdG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.KOJOCGFLBHAReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.GetSingleRedDotParamGroupScRsp), global::EggLink.DanhengServer.Proto.GetSingleRedDotParamGroupScRsp.Parser, new[]{ "ALIPBHAIDEM", "GroupId", "OGEGDABMDMP", "Retcode", "PanelId" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class GetSingleRedDotParamGroupScRsp : pb::IMessage<GetSingleRedDotParamGroupScRsp>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<GetSingleRedDotParamGroupScRsp> _parser = new pb::MessageParser<GetSingleRedDotParamGroupScRsp>(() => new GetSingleRedDotParamGroupScRsp());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<GetSingleRedDotParamGroupScRsp> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.GetSingleRedDotParamGroupScRspReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetSingleRedDotParamGroupScRsp() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetSingleRedDotParamGroupScRsp(GetSingleRedDotParamGroupScRsp other) : this() {
      aLIPBHAIDEM_ = other.aLIPBHAIDEM_ != null ? other.aLIPBHAIDEM_.Clone() : null;
      groupId_ = other.groupId_;
      oGEGDABMDMP_ = other.oGEGDABMDMP_;
      retcode_ = other.retcode_;
      panelId_ = other.panelId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetSingleRedDotParamGroupScRsp Clone() {
      return new GetSingleRedDotParamGroupScRsp(this);
    }

    /// <summary>Field number for the "ALIPBHAIDEM" field.</summary>
    public const int ALIPBHAIDEMFieldNumber = 9;
    private global::EggLink.DanhengServer.Proto.KOJOCGFLBHA aLIPBHAIDEM_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.KOJOCGFLBHA ALIPBHAIDEM {
      get { return aLIPBHAIDEM_; }
      set {
        aLIPBHAIDEM_ = value;
      }
    }

    /// <summary>Field number for the "group_id" field.</summary>
    public const int GroupIdFieldNumber = 4;
    private uint groupId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint GroupId {
      get { return groupId_; }
      set {
        groupId_ = value;
      }
    }

    /// <summary>Field number for the "OGEGDABMDMP" field.</summary>
    public const int OGEGDABMDMPFieldNumber = 6;
    private uint oGEGDABMDMP_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint OGEGDABMDMP {
      get { return oGEGDABMDMP_; }
      set {
        oGEGDABMDMP_ = value;
      }
    }

    /// <summary>Field number for the "retcode" field.</summary>
    public const int RetcodeFieldNumber = 2;
    private uint retcode_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Retcode {
      get { return retcode_; }
      set {
        retcode_ = value;
      }
    }

    /// <summary>Field number for the "panel_id" field.</summary>
    public const int PanelIdFieldNumber = 8;
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
      return Equals(other as GetSingleRedDotParamGroupScRsp);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(GetSingleRedDotParamGroupScRsp other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(ALIPBHAIDEM, other.ALIPBHAIDEM)) return false;
      if (GroupId != other.GroupId) return false;
      if (OGEGDABMDMP != other.OGEGDABMDMP) return false;
      if (Retcode != other.Retcode) return false;
      if (PanelId != other.PanelId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (aLIPBHAIDEM_ != null) hash ^= ALIPBHAIDEM.GetHashCode();
      if (GroupId != 0) hash ^= GroupId.GetHashCode();
      if (OGEGDABMDMP != 0) hash ^= OGEGDABMDMP.GetHashCode();
      if (Retcode != 0) hash ^= Retcode.GetHashCode();
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
      if (Retcode != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(Retcode);
      }
      if (GroupId != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(GroupId);
      }
      if (OGEGDABMDMP != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(OGEGDABMDMP);
      }
      if (PanelId != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(PanelId);
      }
      if (aLIPBHAIDEM_ != null) {
        output.WriteRawTag(74);
        output.WriteMessage(ALIPBHAIDEM);
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
      if (Retcode != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(Retcode);
      }
      if (GroupId != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(GroupId);
      }
      if (OGEGDABMDMP != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(OGEGDABMDMP);
      }
      if (PanelId != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(PanelId);
      }
      if (aLIPBHAIDEM_ != null) {
        output.WriteRawTag(74);
        output.WriteMessage(ALIPBHAIDEM);
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
      if (aLIPBHAIDEM_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(ALIPBHAIDEM);
      }
      if (GroupId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(GroupId);
      }
      if (OGEGDABMDMP != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(OGEGDABMDMP);
      }
      if (Retcode != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Retcode);
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
    public void MergeFrom(GetSingleRedDotParamGroupScRsp other) {
      if (other == null) {
        return;
      }
      if (other.aLIPBHAIDEM_ != null) {
        if (aLIPBHAIDEM_ == null) {
          ALIPBHAIDEM = new global::EggLink.DanhengServer.Proto.KOJOCGFLBHA();
        }
        ALIPBHAIDEM.MergeFrom(other.ALIPBHAIDEM);
      }
      if (other.GroupId != 0) {
        GroupId = other.GroupId;
      }
      if (other.OGEGDABMDMP != 0) {
        OGEGDABMDMP = other.OGEGDABMDMP;
      }
      if (other.Retcode != 0) {
        Retcode = other.Retcode;
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
          case 16: {
            Retcode = input.ReadUInt32();
            break;
          }
          case 32: {
            GroupId = input.ReadUInt32();
            break;
          }
          case 48: {
            OGEGDABMDMP = input.ReadUInt32();
            break;
          }
          case 64: {
            PanelId = input.ReadUInt32();
            break;
          }
          case 74: {
            if (aLIPBHAIDEM_ == null) {
              ALIPBHAIDEM = new global::EggLink.DanhengServer.Proto.KOJOCGFLBHA();
            }
            input.ReadMessage(ALIPBHAIDEM);
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
            Retcode = input.ReadUInt32();
            break;
          }
          case 32: {
            GroupId = input.ReadUInt32();
            break;
          }
          case 48: {
            OGEGDABMDMP = input.ReadUInt32();
            break;
          }
          case 64: {
            PanelId = input.ReadUInt32();
            break;
          }
          case 74: {
            if (aLIPBHAIDEM_ == null) {
              ALIPBHAIDEM = new global::EggLink.DanhengServer.Proto.KOJOCGFLBHA();
            }
            input.ReadMessage(ALIPBHAIDEM);
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
