// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: TravelBrochureRemovePasterScRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from TravelBrochureRemovePasterScRsp.proto</summary>
  public static partial class TravelBrochureRemovePasterScRspReflection {

    #region Descriptor
    /// <summary>File descriptor for TravelBrochureRemovePasterScRsp.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static TravelBrochureRemovePasterScRspReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiVUcmF2ZWxCcm9jaHVyZVJlbW92ZVBhc3RlclNjUnNwLnByb3RvGhFHTkFQ",
            "S0dMQUVORi5wcm90byJVCh9UcmF2ZWxCcm9jaHVyZVJlbW92ZVBhc3RlclNj",
            "UnNwEiEKC0xKRUhNT0RKQktOGAogASgLMgwuR05BUEtHTEFFTkYSDwoHcmV0",
            "Y29kZRgBIAEoDUIeqgIbRWdnTGluay5EYW5oZW5nU2VydmVyLlByb3RvYgZw",
            "cm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.GNAPKGLAENFReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.TravelBrochureRemovePasterScRsp), global::EggLink.DanhengServer.Proto.TravelBrochureRemovePasterScRsp.Parser, new[]{ "LJEHMODJBKN", "Retcode" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class TravelBrochureRemovePasterScRsp : pb::IMessage<TravelBrochureRemovePasterScRsp>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<TravelBrochureRemovePasterScRsp> _parser = new pb::MessageParser<TravelBrochureRemovePasterScRsp>(() => new TravelBrochureRemovePasterScRsp());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<TravelBrochureRemovePasterScRsp> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.TravelBrochureRemovePasterScRspReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TravelBrochureRemovePasterScRsp() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TravelBrochureRemovePasterScRsp(TravelBrochureRemovePasterScRsp other) : this() {
      lJEHMODJBKN_ = other.lJEHMODJBKN_ != null ? other.lJEHMODJBKN_.Clone() : null;
      retcode_ = other.retcode_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TravelBrochureRemovePasterScRsp Clone() {
      return new TravelBrochureRemovePasterScRsp(this);
    }

    /// <summary>Field number for the "LJEHMODJBKN" field.</summary>
    public const int LJEHMODJBKNFieldNumber = 10;
    private global::EggLink.DanhengServer.Proto.GNAPKGLAENF lJEHMODJBKN_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.GNAPKGLAENF LJEHMODJBKN {
      get { return lJEHMODJBKN_; }
      set {
        lJEHMODJBKN_ = value;
      }
    }

    /// <summary>Field number for the "retcode" field.</summary>
    public const int RetcodeFieldNumber = 1;
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
      return Equals(other as TravelBrochureRemovePasterScRsp);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(TravelBrochureRemovePasterScRsp other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(LJEHMODJBKN, other.LJEHMODJBKN)) return false;
      if (Retcode != other.Retcode) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (lJEHMODJBKN_ != null) hash ^= LJEHMODJBKN.GetHashCode();
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
      if (Retcode != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(Retcode);
      }
      if (lJEHMODJBKN_ != null) {
        output.WriteRawTag(82);
        output.WriteMessage(LJEHMODJBKN);
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
        output.WriteRawTag(8);
        output.WriteUInt32(Retcode);
      }
      if (lJEHMODJBKN_ != null) {
        output.WriteRawTag(82);
        output.WriteMessage(LJEHMODJBKN);
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
      if (lJEHMODJBKN_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(LJEHMODJBKN);
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
    public void MergeFrom(TravelBrochureRemovePasterScRsp other) {
      if (other == null) {
        return;
      }
      if (other.lJEHMODJBKN_ != null) {
        if (lJEHMODJBKN_ == null) {
          LJEHMODJBKN = new global::EggLink.DanhengServer.Proto.GNAPKGLAENF();
        }
        LJEHMODJBKN.MergeFrom(other.LJEHMODJBKN);
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
          case 8: {
            Retcode = input.ReadUInt32();
            break;
          }
          case 82: {
            if (lJEHMODJBKN_ == null) {
              LJEHMODJBKN = new global::EggLink.DanhengServer.Proto.GNAPKGLAENF();
            }
            input.ReadMessage(LJEHMODJBKN);
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
            Retcode = input.ReadUInt32();
            break;
          }
          case 82: {
            if (lJEHMODJBKN_ == null) {
              LJEHMODJBKN = new global::EggLink.DanhengServer.Proto.GNAPKGLAENF();
            }
            input.ReadMessage(LJEHMODJBKN);
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
