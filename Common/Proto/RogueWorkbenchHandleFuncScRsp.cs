// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: RogueWorkbenchHandleFuncScRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from RogueWorkbenchHandleFuncScRsp.proto</summary>
  public static partial class RogueWorkbenchHandleFuncScRspReflection {

    #region Descriptor
    /// <summary>File descriptor for RogueWorkbenchHandleFuncScRsp.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static RogueWorkbenchHandleFuncScRspReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiNSb2d1ZVdvcmtiZW5jaEhhbmRsZUZ1bmNTY1JzcC5wcm90bxoRRVBGUEJJ",
            "TU1HUEcucHJvdG8iaAodUm9ndWVXb3JrYmVuY2hIYW5kbGVGdW5jU2NSc3AS",
            "DwoHcmV0Y29kZRgGIAEoDRITCgtFQUpJSkpPRkhLTBgNIAEoDRIhCgtCT09K",
            "RU9DR0xMSxgMIAEoCzIMLkVQRlBCSU1NR1BHQh6qAhtFZ2dMaW5rLkRhbmhl",
            "bmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.EPFPBIMMGPGReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.RogueWorkbenchHandleFuncScRsp), global::EggLink.DanhengServer.Proto.RogueWorkbenchHandleFuncScRsp.Parser, new[]{ "Retcode", "EAJIJJOFHKL", "BOOJEOCGLLK" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class RogueWorkbenchHandleFuncScRsp : pb::IMessage<RogueWorkbenchHandleFuncScRsp>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<RogueWorkbenchHandleFuncScRsp> _parser = new pb::MessageParser<RogueWorkbenchHandleFuncScRsp>(() => new RogueWorkbenchHandleFuncScRsp());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<RogueWorkbenchHandleFuncScRsp> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.RogueWorkbenchHandleFuncScRspReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RogueWorkbenchHandleFuncScRsp() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RogueWorkbenchHandleFuncScRsp(RogueWorkbenchHandleFuncScRsp other) : this() {
      retcode_ = other.retcode_;
      eAJIJJOFHKL_ = other.eAJIJJOFHKL_;
      bOOJEOCGLLK_ = other.bOOJEOCGLLK_ != null ? other.bOOJEOCGLLK_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RogueWorkbenchHandleFuncScRsp Clone() {
      return new RogueWorkbenchHandleFuncScRsp(this);
    }

    /// <summary>Field number for the "retcode" field.</summary>
    public const int RetcodeFieldNumber = 6;
    private uint retcode_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Retcode {
      get { return retcode_; }
      set {
        retcode_ = value;
      }
    }

    /// <summary>Field number for the "EAJIJJOFHKL" field.</summary>
    public const int EAJIJJOFHKLFieldNumber = 13;
    private uint eAJIJJOFHKL_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint EAJIJJOFHKL {
      get { return eAJIJJOFHKL_; }
      set {
        eAJIJJOFHKL_ = value;
      }
    }

    /// <summary>Field number for the "BOOJEOCGLLK" field.</summary>
    public const int BOOJEOCGLLKFieldNumber = 12;
    private global::EggLink.DanhengServer.Proto.EPFPBIMMGPG bOOJEOCGLLK_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.EPFPBIMMGPG BOOJEOCGLLK {
      get { return bOOJEOCGLLK_; }
      set {
        bOOJEOCGLLK_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as RogueWorkbenchHandleFuncScRsp);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(RogueWorkbenchHandleFuncScRsp other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Retcode != other.Retcode) return false;
      if (EAJIJJOFHKL != other.EAJIJJOFHKL) return false;
      if (!object.Equals(BOOJEOCGLLK, other.BOOJEOCGLLK)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Retcode != 0) hash ^= Retcode.GetHashCode();
      if (EAJIJJOFHKL != 0) hash ^= EAJIJJOFHKL.GetHashCode();
      if (bOOJEOCGLLK_ != null) hash ^= BOOJEOCGLLK.GetHashCode();
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
        output.WriteRawTag(48);
        output.WriteUInt32(Retcode);
      }
      if (bOOJEOCGLLK_ != null) {
        output.WriteRawTag(98);
        output.WriteMessage(BOOJEOCGLLK);
      }
      if (EAJIJJOFHKL != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(EAJIJJOFHKL);
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
        output.WriteRawTag(48);
        output.WriteUInt32(Retcode);
      }
      if (bOOJEOCGLLK_ != null) {
        output.WriteRawTag(98);
        output.WriteMessage(BOOJEOCGLLK);
      }
      if (EAJIJJOFHKL != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(EAJIJJOFHKL);
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
      if (Retcode != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Retcode);
      }
      if (EAJIJJOFHKL != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(EAJIJJOFHKL);
      }
      if (bOOJEOCGLLK_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(BOOJEOCGLLK);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(RogueWorkbenchHandleFuncScRsp other) {
      if (other == null) {
        return;
      }
      if (other.Retcode != 0) {
        Retcode = other.Retcode;
      }
      if (other.EAJIJJOFHKL != 0) {
        EAJIJJOFHKL = other.EAJIJJOFHKL;
      }
      if (other.bOOJEOCGLLK_ != null) {
        if (bOOJEOCGLLK_ == null) {
          BOOJEOCGLLK = new global::EggLink.DanhengServer.Proto.EPFPBIMMGPG();
        }
        BOOJEOCGLLK.MergeFrom(other.BOOJEOCGLLK);
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
          case 48: {
            Retcode = input.ReadUInt32();
            break;
          }
          case 98: {
            if (bOOJEOCGLLK_ == null) {
              BOOJEOCGLLK = new global::EggLink.DanhengServer.Proto.EPFPBIMMGPG();
            }
            input.ReadMessage(BOOJEOCGLLK);
            break;
          }
          case 104: {
            EAJIJJOFHKL = input.ReadUInt32();
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
          case 48: {
            Retcode = input.ReadUInt32();
            break;
          }
          case 98: {
            if (bOOJEOCGLLK_ == null) {
              BOOJEOCGLLK = new global::EggLink.DanhengServer.Proto.EPFPBIMMGPG();
            }
            input.ReadMessage(BOOJEOCGLLK);
            break;
          }
          case 104: {
            EAJIJJOFHKL = input.ReadUInt32();
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
