// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: QuitTreasureDungeonCsReq.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from QuitTreasureDungeonCsReq.proto</summary>
  public static partial class QuitTreasureDungeonCsReqReflection {

    #region Descriptor
    /// <summary>File descriptor for QuitTreasureDungeonCsReq.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static QuitTreasureDungeonCsReqReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch5RdWl0VHJlYXN1cmVEdW5nZW9uQ3NSZXEucHJvdG8iRAoYUXVpdFRyZWFz",
            "dXJlRHVuZ2VvbkNzUmVxEhMKC0dERUdNRkpGTERGGA8gASgIEhMKC0NQQ0dQ",
            "R0JES0RHGAIgASgNQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9i",
            "BnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.QuitTreasureDungeonCsReq), global::EggLink.DanhengServer.Proto.QuitTreasureDungeonCsReq.Parser, new[]{ "GDEGMFJFLDF", "CPCGPGBDKDG" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class QuitTreasureDungeonCsReq : pb::IMessage<QuitTreasureDungeonCsReq>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<QuitTreasureDungeonCsReq> _parser = new pb::MessageParser<QuitTreasureDungeonCsReq>(() => new QuitTreasureDungeonCsReq());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<QuitTreasureDungeonCsReq> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.QuitTreasureDungeonCsReqReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public QuitTreasureDungeonCsReq() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public QuitTreasureDungeonCsReq(QuitTreasureDungeonCsReq other) : this() {
      gDEGMFJFLDF_ = other.gDEGMFJFLDF_;
      cPCGPGBDKDG_ = other.cPCGPGBDKDG_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public QuitTreasureDungeonCsReq Clone() {
      return new QuitTreasureDungeonCsReq(this);
    }

    /// <summary>Field number for the "GDEGMFJFLDF" field.</summary>
    public const int GDEGMFJFLDFFieldNumber = 15;
    private bool gDEGMFJFLDF_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool GDEGMFJFLDF {
      get { return gDEGMFJFLDF_; }
      set {
        gDEGMFJFLDF_ = value;
      }
    }

    /// <summary>Field number for the "CPCGPGBDKDG" field.</summary>
    public const int CPCGPGBDKDGFieldNumber = 2;
    private uint cPCGPGBDKDG_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint CPCGPGBDKDG {
      get { return cPCGPGBDKDG_; }
      set {
        cPCGPGBDKDG_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as QuitTreasureDungeonCsReq);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(QuitTreasureDungeonCsReq other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (GDEGMFJFLDF != other.GDEGMFJFLDF) return false;
      if (CPCGPGBDKDG != other.CPCGPGBDKDG) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (GDEGMFJFLDF != false) hash ^= GDEGMFJFLDF.GetHashCode();
      if (CPCGPGBDKDG != 0) hash ^= CPCGPGBDKDG.GetHashCode();
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
      if (CPCGPGBDKDG != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(CPCGPGBDKDG);
      }
      if (GDEGMFJFLDF != false) {
        output.WriteRawTag(120);
        output.WriteBool(GDEGMFJFLDF);
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
      if (CPCGPGBDKDG != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(CPCGPGBDKDG);
      }
      if (GDEGMFJFLDF != false) {
        output.WriteRawTag(120);
        output.WriteBool(GDEGMFJFLDF);
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
      if (GDEGMFJFLDF != false) {
        size += 1 + 1;
      }
      if (CPCGPGBDKDG != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(CPCGPGBDKDG);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(QuitTreasureDungeonCsReq other) {
      if (other == null) {
        return;
      }
      if (other.GDEGMFJFLDF != false) {
        GDEGMFJFLDF = other.GDEGMFJFLDF;
      }
      if (other.CPCGPGBDKDG != 0) {
        CPCGPGBDKDG = other.CPCGPGBDKDG;
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
            CPCGPGBDKDG = input.ReadUInt32();
            break;
          }
          case 120: {
            GDEGMFJFLDF = input.ReadBool();
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
            CPCGPGBDKDG = input.ReadUInt32();
            break;
          }
          case 120: {
            GDEGMFJFLDF = input.ReadBool();
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
