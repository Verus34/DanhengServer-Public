// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: ChessRogueMoveCellNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from ChessRogueMoveCellNotify.proto</summary>
  public static partial class ChessRogueMoveCellNotifyReflection {

    #region Descriptor
    /// <summary>File descriptor for ChessRogueMoveCellNotify.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ChessRogueMoveCellNotifyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch5DaGVzc1JvZ3VlTW92ZUNlbGxOb3RpZnkucHJvdG8aDkNlbGxJbmZvLnBy",
            "b3RvIl0KGENoZXNzUm9ndWVNb3ZlQ2VsbE5vdGlmeRIXCgRjZWxsGA0gASgL",
            "MgkuQ2VsbEluZm8SEwoLQkdJRVBJQ0JGQkQYAyABKA0SEwoLQ1BFUEhHSkNG",
            "RUwYCSABKA1CHqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJv",
            "dG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.CellInfoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.ChessRogueMoveCellNotify), global::EggLink.DanhengServer.Proto.ChessRogueMoveCellNotify.Parser, new[]{ "Cell", "BGIEPICBFBD", "CPEPHGJCFEL" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class ChessRogueMoveCellNotify : pb::IMessage<ChessRogueMoveCellNotify>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ChessRogueMoveCellNotify> _parser = new pb::MessageParser<ChessRogueMoveCellNotify>(() => new ChessRogueMoveCellNotify());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ChessRogueMoveCellNotify> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.ChessRogueMoveCellNotifyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ChessRogueMoveCellNotify() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ChessRogueMoveCellNotify(ChessRogueMoveCellNotify other) : this() {
      cell_ = other.cell_ != null ? other.cell_.Clone() : null;
      bGIEPICBFBD_ = other.bGIEPICBFBD_;
      cPEPHGJCFEL_ = other.cPEPHGJCFEL_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ChessRogueMoveCellNotify Clone() {
      return new ChessRogueMoveCellNotify(this);
    }

    /// <summary>Field number for the "cell" field.</summary>
    public const int CellFieldNumber = 13;
    private global::EggLink.DanhengServer.Proto.CellInfo cell_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.CellInfo Cell {
      get { return cell_; }
      set {
        cell_ = value;
      }
    }

    /// <summary>Field number for the "BGIEPICBFBD" field.</summary>
    public const int BGIEPICBFBDFieldNumber = 3;
    private uint bGIEPICBFBD_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint BGIEPICBFBD {
      get { return bGIEPICBFBD_; }
      set {
        bGIEPICBFBD_ = value;
      }
    }

    /// <summary>Field number for the "CPEPHGJCFEL" field.</summary>
    public const int CPEPHGJCFELFieldNumber = 9;
    private uint cPEPHGJCFEL_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint CPEPHGJCFEL {
      get { return cPEPHGJCFEL_; }
      set {
        cPEPHGJCFEL_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ChessRogueMoveCellNotify);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ChessRogueMoveCellNotify other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Cell, other.Cell)) return false;
      if (BGIEPICBFBD != other.BGIEPICBFBD) return false;
      if (CPEPHGJCFEL != other.CPEPHGJCFEL) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (cell_ != null) hash ^= Cell.GetHashCode();
      if (BGIEPICBFBD != 0) hash ^= BGIEPICBFBD.GetHashCode();
      if (CPEPHGJCFEL != 0) hash ^= CPEPHGJCFEL.GetHashCode();
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
      if (BGIEPICBFBD != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(BGIEPICBFBD);
      }
      if (CPEPHGJCFEL != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(CPEPHGJCFEL);
      }
      if (cell_ != null) {
        output.WriteRawTag(106);
        output.WriteMessage(Cell);
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
      if (BGIEPICBFBD != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(BGIEPICBFBD);
      }
      if (CPEPHGJCFEL != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(CPEPHGJCFEL);
      }
      if (cell_ != null) {
        output.WriteRawTag(106);
        output.WriteMessage(Cell);
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
      if (cell_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Cell);
      }
      if (BGIEPICBFBD != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(BGIEPICBFBD);
      }
      if (CPEPHGJCFEL != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(CPEPHGJCFEL);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(ChessRogueMoveCellNotify other) {
      if (other == null) {
        return;
      }
      if (other.cell_ != null) {
        if (cell_ == null) {
          Cell = new global::EggLink.DanhengServer.Proto.CellInfo();
        }
        Cell.MergeFrom(other.Cell);
      }
      if (other.BGIEPICBFBD != 0) {
        BGIEPICBFBD = other.BGIEPICBFBD;
      }
      if (other.CPEPHGJCFEL != 0) {
        CPEPHGJCFEL = other.CPEPHGJCFEL;
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
          case 24: {
            BGIEPICBFBD = input.ReadUInt32();
            break;
          }
          case 72: {
            CPEPHGJCFEL = input.ReadUInt32();
            break;
          }
          case 106: {
            if (cell_ == null) {
              Cell = new global::EggLink.DanhengServer.Proto.CellInfo();
            }
            input.ReadMessage(Cell);
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
          case 24: {
            BGIEPICBFBD = input.ReadUInt32();
            break;
          }
          case 72: {
            CPEPHGJCFEL = input.ReadUInt32();
            break;
          }
          case 106: {
            if (cell_ == null) {
              Cell = new global::EggLink.DanhengServer.Proto.CellInfo();
            }
            input.ReadMessage(Cell);
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
